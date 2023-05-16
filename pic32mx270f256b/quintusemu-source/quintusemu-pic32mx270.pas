//
//    Quintusemu - An emulator for RISC-V 32 IM
//    Copyright (C) 2018  Matthias Koch
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

// Partial port for MIPS, at least emulating the instructions necessary for Mecrisp-Quintus.
// Unknown opcodes are just skipped.

uses crt, sysutils;

var insight : dword = 0;

// ----------------------------------------------------------------------------
//  Nice hex number printing helpers

function byte2hex(zahl : byte) : string;
const
    hexa : array [0..15] of char = '0123456789ABCDEF';
begin
  byte2hex := hexa[zahl shr 4] + hexa[zahl and 15];
end;

function word2hex(zahl : word) : string;
begin
  word2hex := Byte2Hex((zahl and $FF00) shr 8) + Byte2Hex(zahl and $00FF);
end;

function dword2hex(zahl : dword) : string;
begin
  dword2hex := Word2Hex((zahl and $FFFF0000) shr 16) + Word2Hex(zahl and $0000FFFF);
end;

// ----------------------------------------------------------------------------
//  Register definitions for emulator

var registers : array[1..31] of dword;
    result_low, result_high : dword;
    pc : dword;

procedure write_register(register, data : dword);  begin if register <> 0 then registers[register] := data; end;
function read_register(register : dword) : dword;  begin if register <> 0 then read_register := registers[register] else read_register := 0; end;

function get_pc : dword; begin get_pc := pc; end;
procedure set_pc(destination : dword); begin pc := destination; end;

procedure writeregister;
var i : integer;
begin
//  for i :=  0 to 15 do write(i:8, ' '); writeln;
  for i :=  0 to 15 do write(dword2hex(registers[i]), ' ');//  writeln;
//  for i := 16 to 31 do write(i:8, ' '); writeln;
  for i := 31 to 31 do write(dword2hex(registers[i]), ' ');// writeln;
end;

// ----------------------------------------------------------------------------
//  Memory space and IO registers

procedure emit(character : byte);
begin
 // writeln;
 // writeln('Emit: ', inttostr(character));
  if (character = 10) or (character = 13) then writeln
                                          else write(chr(character));
end;

function key : byte;
var character : byte;
begin
  character := ord(readkey) and $FF;
  if character = 27 then halt;
  // writeln('Key', inttostr(character));
  key := character;
end;

const flash_start = $BD000000;
      flash_end   = $BD040000;
      flash_size  = flash_end - flash_start;

      ram_start = $A0000000;
      ram_end   = $A0010000;
      ram_size  = ram_end - ram_start;

      boot_start = $BFC00000;
      boot_end   = $BFC00C00;
      boot_size  = boot_end - boot_start;


var memory_flash : array[0..flash_size] of byte;
    memory_ram   : array[0..ram_size]   of byte;
    memory_boot  : array[0..boot_size]  of byte;

function flash(addr : dword) : boolean;
begin
  flash := (flash_start <= addr) and (addr < flash_end);
end;

function ram(addr : dword) : boolean;
begin
  ram := (ram_start <= addr) and (addr < ram_end);
end;

function boot(addr : dword) : boolean;
begin
  boot := (boot_start <= addr) and (addr < boot_end);
end;

function read8 (addr : dword) : dword;
begin
  read8 := $FF;
  if flash(addr) then read8 := memory_flash[addr - flash_start];
  if   ram(addr) then read8 :=   memory_ram[addr - ram_start];
  if  boot(addr) then read8 :=  memory_boot[addr - boot_start];
end;

function read16(addr : dword) : dword;
begin
  read16 := read8(addr) or read8(addr + 1) shl 8;
end;

function read32(addr : dword) : dword;
begin
  case addr of

   $bf80f400: read32 := 0; // Flash never busy

   $BF806010: read32 := 1; // UART always has a character waiting and is never busy

   $BF806030: read32 := key;

  else
    read32 := read16(addr) or read16(addr + 2) shl 16;
  end;
end;


procedure store8 (addr, data : dword);
begin
  if flash(addr) then memory_flash[addr - flash_start] := data and $FF;
  if   ram(addr) then   memory_ram[addr - ram_start]   := data and $FF;
  if  boot(addr) then  memory_boot[addr - boot_start]  := data and $FF;
end;

procedure store16(addr, data : dword);
begin
  store8(addr,      data        and $FF);
  store8(addr + 1, (data shr 8) and $FF);
end;

var flash_address : dword = $FFFFFFFF;
    flash_data    : dword = $FFFFFFFF;

procedure store32(addr, data : dword);
var coredump : longint;
begin
  // writeln('Store32 ', dword2hex(addr), ' ', dword2hex(data));
  case addr of

    $bf80f420: flash_address := data or $A0000000; // NVMADDR, translate from physical address to logical address
    $bf80f430: flash_data    := data;              // NVMDATA
    $bf80f400: if data = $C001 then store32(flash_address, flash_data);  // NVMCON

    $BF806020: emit(data and $FF);

    $DABBAD00: begin // Special helper to generate binaries with precompiled sources.
                 filecreate('coredump.bin');
                 coredump := fileopen('coredump.bin', fmOpenWrite);
                 filewrite(coredump, memory_flash[0], data - flash_start);
                 fileclose(coredump);
                 halt;
               end;

  else
    store16(addr,      data         and $FFFF);
    store16(addr + 2, (data shr 16) and $FFFF);
  end;
end;

// ----------------------------------------------------------------------------
//  Small utilities

function sar (data, amount : dword) : dword;
begin
  if (data and $80000000) = $80000000 then sar := (data shr amount) or ($FFFFFFFF shl (32 - amount))
                                      else sar :=  data shr amount;
end;

function sign8(data : dword) : dword;
begin
  if (data and $80) = $80 then sign8 := data or $FFFFFF00 else sign8 := data;
end;

function sign16(data : dword) : dword;
begin
  if (data and $8000) = $8000 then sign16 := data or $FFFF0000 else sign16 := data;
end;

function signedless(data1, data2 : longint) : boolean;
begin
  signedless := data1 < data2;
end;

function sign64(data : uint32) : int64;
begin
  if (data and $80000000) = $80000000 then sign64 := data or $FFFFFFFF00000000
                                      else sign64 := data;
end;

// ----------------------------------------------------------------------------
//  Decoders for instruction bit fields

function opcode    (inst : dword) : dword; begin opcode    :=  inst shr 26;          end;

function rs        (inst : dword) : dword; begin rs        := (inst shr 21) and $1F; end;
function rt        (inst : dword) : dword; begin rt        := (inst shr 16) and $1F; end;
function rd        (inst : dword) : dword; begin rd        := (inst shr 11) and $1F; end;
function shamt     (inst : dword) : dword; begin shamt     := (inst shr  6) and $1F; end;

// ----------------------------------------------------------------------------
//  Small utilities for the disassembler

function printregister(register : dword) : string;
begin
  case register of
    0: printregister := 'zero';
  else
    printregister := '$' + inttostr(register);
  end;
end;

// ----------------------------------------------------------------------------
//  Disassembler

function disasm_r_3reg(inst : dword) : string;
begin
  disasm_r_3reg := ' ' + printregister(rd(inst)) + ', ' + printregister(rs(inst)) + ', ' + printregister(rt(inst));
end;

function disasm_r_shift(inst : dword) : string;
begin
  disasm_r_shift := ' ' + printregister(rd(inst)) + ', ' + printregister(rt(inst)) + ' , ' + byte2hex(shamt(inst)) ;
end;


function disassemble_r(addr, inst : dword) : string;
begin

  case (inst and $3F) of

  // -------------------------
     0: disassemble_r := 'sll' +   disasm_r_shift(inst) ;
     2: disassemble_r := 'srl' +   disasm_r_shift(inst) ;
     3: disassemble_r := 'sra' +   disasm_r_shift(inst) ;
     4: disassemble_r := 'sllv' +  disasm_r_3reg(inst) ;
     6: disassemble_r := 'srlv' +  disasm_r_3reg(inst) ;
     7: disassemble_r := 'srav' +  disasm_r_3reg(inst) ;
  // -------------------------
     8: disassemble_r := 'jr' +    disasm_r_3reg(inst) ;
     9: disassemble_r := 'jalr' +  disasm_r_3reg(inst) ;
    10: disassemble_r := 'movz' +  disasm_r_3reg(inst) ;
    11: disassemble_r := 'movn' +  disasm_r_3reg(inst) ;
//    12: disassemble_r := 'syscall' +  disasm_r_3reg(inst) ;
//    13: disassemble_r := 'break' + disasm_r_3reg(inst) ;
//    15: disassemble_r := 'sync' +  disasm_r_3reg(inst) ;
  // -------------------------
    16: disassemble_r := 'mfhi' +  disasm_r_3reg(inst) ;
    17: disassemble_r := 'mthi' +  disasm_r_3reg(inst) ;
    18: disassemble_r := 'mflo' +  disasm_r_3reg(inst) ;
    19: disassemble_r := 'mtlo' +  disasm_r_3reg(inst) ;
  // -------------------------
    24: disassemble_r := 'mult' +  disasm_r_3reg(inst) ;
    25: disassemble_r := 'multu' + disasm_r_3reg(inst) ;
    26: disassemble_r := 'div' +   disasm_r_3reg(inst) ;
    27: disassemble_r := 'divu' +  disasm_r_3reg(inst) ;
  // -------------------------
    32: disassemble_r := 'add' +   disasm_r_3reg(inst) ;
    33: disassemble_r := 'addu' +  disasm_r_3reg(inst) ;
    34: disassemble_r := 'sub' +   disasm_r_3reg(inst) ;
    35: disassemble_r := 'subu' +  disasm_r_3reg(inst) ;
    36: disassemble_r := 'and' +   disasm_r_3reg(inst) ;
    37: disassemble_r := 'or' +    disasm_r_3reg(inst) ;
    38: disassemble_r := 'xor' +   disasm_r_3reg(inst) ;
    39: disassemble_r := 'nor' +   disasm_r_3reg(inst) ;
  // -------------------------
    42: disassemble_r := 'slt' +   disasm_r_3reg(inst) ;
    43: disassemble_r := 'sltu' +  disasm_r_3reg(inst) ;
  // -------------------------
//    48: disassemble_r := 'tge' +   disasm_r_3reg(inst) ;
//    49: disassemble_r := 'tgeu' +  disasm_r_3reg(inst) ;
//    50: disassemble_r := 'tlt' +   disasm_r_3reg(inst) ;
//    51: disassemble_r := 'tltu' +  disasm_r_3reg(inst) ;
//    52: disassemble_r := 'teq' +   disasm_r_3reg(inst) ;
//    54: disassemble_r := 'tne' +   disasm_r_3reg(inst) ;
  // -------------------------

  else
    disassemble_r := 'Unknown R-Opcode ' + printregister(rd(inst)) + ', ' + printregister(rs(inst)) + ', ' + printregister(rt(inst)) + ' , ' + byte2hex(shamt(inst)) ;
  end;

end;

function disassemble_j(addr, inst : dword) : string;
begin
  disassemble_j := ' ' + dword2hex(((inst and $03FFFFFF) shl 2) or (addr and $F0000000));
end;

function disassemble_i_branch(addr, inst : dword) : string;
begin
  disassemble_i_branch := ' ' + printregister(rs(inst)) + ', ' + printregister(rt(inst)) + ', ' + dword2hex((sign16(inst and $FFFF) shl 2) + addr + 4);
end;

function disassemble_i(addr, inst : dword) : string;
begin
  disassemble_i := ' ' + printregister(rt(inst)) + ', ' + printregister(rs(inst)) + ', ' + word2hex(inst and $FFFF);
end;

function disassemble_i_loadstore(addr, inst : dword) : string;
begin
  disassemble_i_loadstore := ' ' + printregister(rt(inst)) + ', ' + word2hex(inst and $FFFF) + ' (' + printregister(rs(inst)) + ')';
end;

function disassemble_regimm(addr, inst : dword) : string;
begin

  case rt(inst) of

    0: { bltz }   disassemble_regimm := 'bltz' +  disassemble_i_branch(addr, inst) ;
    1: { bgez }   disassemble_regimm := 'bgez' +  disassemble_i_branch(addr, inst) ;

  else

    disassemble_regimm := 'Unknown RegImm-Opcode ' + printregister(rd(inst)) + ', ' + printregister(rs(inst)) + ', ' + printregister(rt(inst)) + ' , ' + byte2hex(shamt(inst)) ;

  end;
end;

// ----------------------------------------------------------------------------

function disassemble(addr, inst : dword) : string;
begin
  if inst = $00000000 then begin disassemble := 'nop'; exit; end else disassemble := '';

  case opcode(inst) of

     0: disassemble :=           disassemble_r (addr, inst);
     1: disassemble :=           disassemble_regimm (addr, inst);
     2: disassemble := 'j'     + disassemble_j (addr, inst);
     3: disassemble := 'jal'   + disassemble_j (addr, inst);
     4: disassemble := 'beq'   + disassemble_i_branch (addr, inst);
     5: disassemble := 'bne'   + disassemble_i_branch (addr, inst);
     6: disassemble := 'blez'  + disassemble_i_branch (addr, inst);
     7: disassemble := 'bgtz'  + disassemble_i_branch (addr, inst);
   // -------------------------------------------------------------------------
     8: disassemble := 'addi'  + disassemble_i (addr, inst);
     9: disassemble := 'addiu' + disassemble_i (addr, inst);
    10: disassemble := 'slti'  + disassemble_i (addr, inst);
    11: disassemble := 'sltiu' + disassemble_i (addr, inst);
    12: disassemble := 'andi'  + disassemble_i (addr, inst);
    13: disassemble := 'ori '  + disassemble_i (addr, inst);
    14: disassemble := 'xori'  + disassemble_i (addr, inst);
    15: disassemble := 'lui '  + disassemble_i (addr, inst);
  // -------------------------------------------------------------------------
    16: disassemble := 'cop0';

//    20: disassemble := 'beql'  + disassemble_i_branch (addr, inst);
//    21: disassemble := 'bnel'  + disassemble_i_branch (addr, inst);
//    22: disassemble := 'blezl' + disassemble_i_branch (addr, inst);
//    23: disassemble := 'bgtzl' + disassemble_i_branch (addr, inst);

  // -------------------------------------------------------------------------

    28: if (inst and $3F) = 2 then
        disassemble := 'mul' +  disasm_r_3reg(inst) ;

  // -------------------------------------------------------------------------
    32: disassemble := 'lb'  + disassemble_i_loadstore (addr, inst);
    33: disassemble := 'lh'  + disassemble_i_loadstore (addr, inst);
//    34: disassemble := 'lwl' + disassemble_i_loadstore (addr, inst);
    35: disassemble := 'lw'  + disassemble_i_loadstore (addr, inst);
    36: disassemble := 'lbu' + disassemble_i_loadstore (addr, inst);
  //  37: disassemble := 'lhu' + disassemble_i_loadstore (addr, inst);
//    38: disassemble := 'lwr' + disassemble_i_loadstore (addr, inst);
  // -------------------------------------------------------------------------
    40: disassemble := 'sb'  + disassemble_i_loadstore (addr, inst);
  //  41: disassemble := 'sh'  + disassemble_i_loadstore (addr, inst);
//    42: disassemble := 'swl' + disassemble_i_loadstore (addr, inst);
    43: disassemble := 'sw'  + disassemble_i_loadstore (addr, inst);

//    46: disassemble := 'swr' + disassemble_i (addr, inst);
  // -------------------------------------------------------------------------

  else
    // disassemble := 'Unknown opcode ' + dword2hex(opcode(inst));
      disassemble := '?';
  end;

end;

// ----------------------------------------------------------------------------
//  Emulator

procedure execute(addr : dword);

var inst : dword;
    destination : dword;
    inc_pc : boolean;

    ud1, ud2, ud : uint64;
    d1, d2, d : int64;

    signed1, signed2, signed : int32;
    unsigned1, unsigned2, unsigned : uint32;

begin
  inst := read32(addr);

  // Disassemble every executed processor instruction for a while:
  if insight > 0 then begin write(dword2hex(addr), ' ', dword2hex(inst), ' : ');  writeregister;  writeln(disassemble(addr,inst)); dec(insight); end;


  inc_pc := true;

  case opcode(inst) of

     // -----------------------------------------------------------------------
     0: // R-Format Opcodes
     // -----------------------------------------------------------------------

begin

  case (inst and $3F) of

  // -------------------------
     0: { sll }   write_register( rd(inst),      read_register(rt(inst)) shl shamt(inst)  );
     2: { srl }   write_register( rd(inst),      read_register(rt(inst)) shr shamt(inst)  );
     3: { sra }   write_register( rd(inst),  sar(read_register(rt(inst)),    shamt(inst)) );
     4: { sllv }  write_register( rd(inst),      read_register(rt(inst)) shl (read_register(rs(inst)) and $1F)  );
     6: { srlv }  write_register( rd(inst),      read_register(rt(inst)) shr (read_register(rs(inst)) and $1F)  );
     7: { srav }  write_register( rd(inst),  sar(read_register(rt(inst)),    (read_register(rs(inst)) and $1F)) );
  // -------------------------
     8: { jr }    begin                                     destination := read_register(rs(inst)); execute(addr + 4); set_pc(destination); inc_pc := false; end;
     9: { jalr }  begin write_register(rd(inst), addr + 8); destination := read_register(rs(inst)); execute(addr + 4); set_pc(destination); inc_pc := false; end;
    10: { movz }  if read_register(rt(inst)) =  0 then write_register(rd(inst), read_register(rs(inst)));
    11: { movn }  if read_register(rt(inst)) <> 0 then write_register(rd(inst), read_register(rs(inst)));
//    12: { syscall }
//    13: { break }
//    15: { sync }
  // -------------------------
    16: { mfhi }  write_register(rd(inst), result_high);
    17: { mthi }  result_high := read_register(rs(inst));
    18: { mflo }  write_register(rd(inst), result_low);
    19: { mtlo }  result_low := read_register(rs(inst));
  // -------------------------
    24: { mult }  begin
                    d1 := sign64(read_register(rs(inst)));
                    d2 := sign64(read_register(rt(inst)));
                    d := d1 * d2;
                    result_low  := d and $FFFFFFFF;
                    result_high := d shr 32;
                  end;

    25: { multu } begin
                    ud1 := read_register(rs(inst));
                    ud2 := read_register(rt(inst));
                    ud := ud1 * ud2;
                    result_low  := ud and $FFFFFFFF;
                    result_high := ud shr 32;
                  end;

    26: { div }   begin
                    signed1 := read_register(rs(inst));
                    signed2 := read_register(rt(inst));

                    signed := signed1 div signed2;
                    result_low  := signed;

                    signed := signed1 mod signed2;
                    result_high := signed;
                  end;

    27: { divu }  begin
                    unsigned1 := read_register(rs(inst));
                    unsigned2 := read_register(rt(inst));

                    unsigned := unsigned1 div unsigned2;
                    result_low  := unsigned;

                    unsigned := unsigned1 mod unsigned2;
                    result_high := unsigned;
                  end;
  // -------------------------
    32: { add }   write_register( rd(inst),  read_register(rs(inst))  +  read_register(rt(inst)) );
    33: { addu }  write_register( rd(inst),  read_register(rs(inst))  +  read_register(rt(inst)) );
    34: { sub }   write_register( rd(inst),  read_register(rs(inst))  -  read_register(rt(inst)) );
    35: { subu }  write_register( rd(inst),  read_register(rs(inst))  -  read_register(rt(inst)) );
    36: { and }   write_register( rd(inst),  read_register(rs(inst)) and read_register(rt(inst)) );
    37: { or }    write_register( rd(inst),  read_register(rs(inst))  or read_register(rt(inst)) );
    38: { xor }   write_register( rd(inst),  read_register(rs(inst)) xor read_register(rt(inst)) );
    39: { nor }   write_register( rd(inst), (read_register(rs(inst))  or read_register(rt(inst))) xor $FFFFFFFF );
  // -------------------------
    42: { slt }   if signedless(read_register(rs(inst)),  read_register(rt(inst))) then write_register(rd(inst), 1) else write_register(rd(inst), 0); // slti
    43: { sltu }  if            read_register(rs(inst)) < read_register(rt(inst))  then write_register(rd(inst), 1) else write_register(rd(inst), 0); // sltiu
  // -------------------------
 //   48: { tge }   disasm_r_3reg(inst) ;
 //   49: { tgeu }  disasm_r_3reg(inst) ;
 //   50: { tlt }   disasm_r_3reg(inst) ;
 //   51: { tltu }  disasm_r_3reg(inst) ;
 //   52: { teq }   disasm_r_3reg(inst) ;
 //   54: { tne }   disasm_r_3reg(inst) ;
  // -------------------------

  else
    writeln('Unknown R-Opcode ' + dword2hex(addr) + ' : ' + dword2hex(opcode(inst)));
    halt;
  end;

end;

     // -----------------------------------------------------------------------
     1: // RegImm - Opcodes
     // -----------------------------------------------------------------------

begin

  case rt(inst) of

    0: { bltz }   if  (read_register(rs(inst)) and $80000000) = $80000000                                              then begin execute(addr + 4); set_pc((sign16(inst and $FFFF) shl 2) + addr + 4); inc_pc := false; end;
    1: { bgez }   if ((read_register(rs(inst)) and $80000000) = $00000000) and (read_register(rs(inst)) <> $00000000)  then begin execute(addr + 4); set_pc((sign16(inst and $FFFF) shl 2) + addr + 4); inc_pc := false; end;

  else
    writeln('Unknown RegImm-Opcode ' + dword2hex(addr) + ' : ' + dword2hex(opcode(inst)));
    halt;
  end;

end;

     // -----------------------------------------------------------------------
     //  All other opcodes carrying immediate values
     // -----------------------------------------------------------------------

     2: { j }     begin                               destination := ((inst and $03FFFFFF) shl 2) or (addr and $F0000000); execute(addr + 4); set_pc(destination); inc_pc := false; end;
     3: { jal }   begin write_register(31, addr + 8); destination := ((inst and $03FFFFFF) shl 2) or (addr and $F0000000); execute(addr + 4); set_pc(destination); inc_pc := false; end;
     4: { beq }   if  read_register(rs(inst))  = read_register(rt(inst))  then begin execute(addr + 4); set_pc((sign16(inst and $FFFF) shl 2) + addr + 4 ); inc_pc := false; end;
     5: { bne }   if  read_register(rs(inst)) <> read_register(rt(inst))  then begin execute(addr + 4); set_pc((sign16(inst and $FFFF) shl 2) + addr + 4 ); inc_pc := false; end;
     6: { blez }  if      (read_register(rs(inst)) = 0) or ((read_register(rs(inst)) and $80000000) = $80000000)   then begin execute(addr + 4); set_pc((sign16(inst and $FFFF) shl 2) + addr + 4); inc_pc := false; end;
     7: { bgtz }  if not ((read_register(rs(inst)) = 0) or ((read_register(rs(inst)) and $80000000) = $80000000) ) then begin execute(addr + 4); set_pc((sign16(inst and $FFFF) shl 2) + addr + 4); inc_pc := false; end;
   // -------------------------------------------------------------------------
     8: { addi }  write_register(rt(inst), read_register(rs(inst)) +   sign16((inst and $FFFF)));
     9: { addiu } write_register(rt(inst), read_register(rs(inst)) +   sign16((inst and $FFFF)));
    10: { slti }  if signedless(read_register(rs(inst)),  sign16(inst and $FFFF)) then write_register(rt(inst), 1) else write_register(rt(inst), 0); // slti
    11: { sltiu } if            read_register(rs(inst)) < sign16(inst and $FFFF)  then write_register(rt(inst), 1) else write_register(rt(inst), 0); // sltiu
    12: { andi }  write_register(rt(inst), read_register(rs(inst)) and (inst and $FFFF));
    13: { ori  }  write_register(rt(inst), read_register(rs(inst)) or  (inst and $FFFF));
    14: { xori }  write_register(rt(inst), read_register(rs(inst)) xor (inst and $FFFF));
    15: { lui  }  write_register(rt(inst), (inst and $FFFF) shl 16);
  // -------------------------------------------------------------------------
    16: begin end; // Nothing to do with COP0

//    20: { beql }
//    21: { bnel }
//    22: { blezl }
//    23: { bgtzl }

  // -------------------------------------------------------------------------
    28: { mul } if (inst and $3F) = 2 then
                  write_register( rd(inst),  read_register(rs(inst))  *  read_register(rt(inst)) );
  // -------------------------------------------------------------------------
    32: { lb }    write_register(rt(inst), sign8 (read8 (read_register(rs(inst)) + sign16(inst and $FFFF))));
    33: { lh }    write_register(rt(inst), sign16(read16(read_register(rs(inst)) + sign16(inst and $FFFF))));
//    34: { lwl }
    35: { lw }    write_register(rt(inst),        read32(read_register(rs(inst)) + sign16(inst and $FFFF)));
    36: { lbu }   write_register(rt(inst),        read8 (read_register(rs(inst)) + sign16(inst and $FFFF)));
    37: { lhu }   write_register(rt(inst),        read16(read_register(rs(inst)) + sign16(inst and $FFFF)));
//    38: { lwr }
  // -------------------------------------------------------------------------
    40: { sb }    store8 (read_register(rs(inst)) + sign16(inst and $FFFF), read_register(rt(inst)));
    41: { sh }    store16(read_register(rs(inst)) + sign16(inst and $FFFF), read_register(rt(inst)));
//    42: { swl }
    43: { sw }    store32(read_register(rs(inst)) + sign16(inst and $FFFF), read_register(rt(inst)));
//    46: { swr }
  // -------------------------------------------------------------------------

    // Special for emulator: Activate disassembly !
    47: insight := inst and $FFFF;

  else
    writeln('Unknown opcode ' + dword2hex(addr) + ' : ' + dword2hex(inst));
    halt;
  end;

  //if inc_pc then set_pc(addr + 4); // Advance PC.
  if inc_pc then set_pc(get_pc + 4); // Advance PC.
end;

// ----------------------------------------------------------------------------

var binaryimage : longint;
    binarysize : longint;

procedure disassemblebinary;
var addr, inst : dword;
begin
  // Disassemble the complete binary

  writeln;
  addr := 0;
  while (addr < binarysize) do
  begin
    inst := read32(addr + flash_start);
    writeln(dword2hex(addr + flash_start), ' : ', dword2hex(inst), '  ', disassemble(addr + flash_start, inst));

    addr := addr + 4;
  end;
  writeln;
end;

begin
  // Load binary image

  fillchar(memory_flash, sizeof(memory_flash), 255);
  fillchar(memory_ram,   sizeof(memory_ram),   255);
  fillchar(memory_boot,  sizeof(memory_boot),  255);

  binaryimage := fileopen(paramstr(1), fmOpenRead);
  binarysize := fileseek(binaryimage, 0, fsFromEnd);
  writeln('Binary boot size: ', binarysize, ' bytes.');
  fileseek(binaryimage, 0, fsFromBeginning);
  fileread(binaryimage, memory_boot[0], binarysize);
  fileclose(binaryimage);

  binaryimage := fileopen(paramstr(2), fmOpenRead);
  binarysize := fileseek(binaryimage, 0, fsFromEnd);
  writeln('Binary flash size: ', binarysize, ' bytes.');
  fileseek(binaryimage, 0, fsFromBeginning);
  fileread(binaryimage, memory_flash[0], binarysize);
  fileclose(binaryimage);

  // disassemblebinary;

  // Execute !

  writeln('Ready to fly !');
  set_pc(boot_start);
  writeln('Start address: ', dword2hex(get_pc));

  repeat
    execute(get_pc);
  until false;

end.
