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

uses crt, sysutils;

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

var memory_flash : array[$00000000..$00100000] of byte;
    memory_ram   : array[$20000000..$20030000] of byte;

function flash(addr : dword) : boolean;
begin
  flash := addr < $00100000;
end;

function ram(addr : dword) : boolean;
begin
  ram := ($20000000 <= addr) and (addr < $20030000);
end;

function read8 (addr : dword) : dword;
begin
  read8 := $FF;
  if flash(addr) then read8 := memory_flash[addr];
  if   ram(addr) then read8 :=   memory_ram[addr];
end;

function read16(addr : dword) : dword;
begin
  read16 := $FFFF;
  if flash(addr) then read16 := memory_flash[addr] or
                                memory_flash[addr + 1] shl 8;
  if   ram(addr) then read16 :=   memory_ram[addr] or
                                  memory_ram[addr + 1] shl 8;
end;

function read32(addr : dword) : dword;
begin
  // writeln('Read32 ', dword2hex(addr));
  case addr of

   $40023000: read32 := $80; // Flash never busy
   $4004201C: read32 := key; // LPUART0_DATA

  else

    read32 := $FFFFFFFF;

    if flash(addr) then read32 := memory_flash[addr] or
                                  memory_flash[addr + 1] shl  8  or
                                  memory_flash[addr + 2] shl 16  or
                                  memory_flash[addr + 3] shl 24;
    if   ram(addr) then read32 :=   memory_ram[addr] or
                                    memory_ram[addr + 1] shl  8  or
                                    memory_ram[addr + 2] shl 16  or
                                    memory_ram[addr + 3] shl 24;
  end;
end;


procedure store8 (addr, data : dword);
begin
  if flash(addr) then memory_flash[addr] := data and $FF;
  if   ram(addr) then   memory_ram[addr] := data and $FF;
end;

procedure store16(addr, data : dword);
begin
  if flash(addr) then begin
                        memory_flash[addr  ] :=  data         and $FF;
                        memory_flash[addr+1] := (data shr  8) and $FF;
                      end;
  if   ram(addr) then begin
                          memory_ram[addr  ] :=  data         and $FF;
                          memory_ram[addr+1] := (data shr  8) and $FF;
                      end;
end;

var flash_address : dword = $FFFFFFFF;
    flash_data1   : dword = $FFFFFFFF;
    flash_data2   : dword = $FFFFFFFF;

procedure store32(addr, data : dword);
var coredump : longint;
begin
  // writeln('Store32 ', dword2hex(addr), ' ', dword2hex(data));
  case addr of

      $4004201C: emit(data and $FF); // LPUART0_DATA

      $40023000: if data = $80 then begin store32(flash_address, flash_data1); store32(flash_address + 4, flash_data2); end;
      $40023004: flash_address := data and $00FFFFFF;
      $40023008: flash_data1   := data;
      $4002300C: flash_data2   := data;

    $DABBAD00: begin // Special helper to generate binaries with precompiled sources.
                 filecreate('coredump.bin');
                 coredump := fileopen('coredump.bin', fmOpenWrite);
                 filewrite(coredump, memory_flash[0], data);
                 fileclose(coredump);
                 halt;
               end;

  else
    if flash(addr) then begin
                          memory_flash[addr  ] :=  data         and $FF;
                          memory_flash[addr+1] := (data shr  8) and $FF;
                          memory_flash[addr+2] := (data shr 16) and $FF;
                          memory_flash[addr+3] := (data shr 24) and $FF;
                        end;
    if   ram(addr) then begin
                            memory_ram[addr  ] :=  data         and $FF;
                            memory_ram[addr+1] := (data shr  8) and $FF;
                            memory_ram[addr+2] := (data shr 16) and $FF;
                            memory_ram[addr+3] := (data shr 24) and $FF;
                        end;
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

// ----------------------------------------------------------------------------
//  Decoders for instruction bit fields

function opcode    (inst : dword) : dword; begin opcode    :=  inst         and $7F; end;
function rd        (inst : dword) : dword; begin rd        := (inst shr  7) and $1F; end;
function rs1       (inst : dword) : dword; begin rs1       := (inst shr 15) and $1F; end;
function rs2       (inst : dword) : dword; begin rs2       := (inst shr 20) and $1F; end;
function funct3    (inst : dword) : dword; begin funct3    := (inst shr 12) and $07; end;
function funct7    (inst : dword) : dword; begin funct7    :=  inst shr 25         ; end;

// ----------------------------------------------------------------------------
//  Decoders for immediate encoding formats

function imm_i (inst : dword) : dword;
begin
  imm_i := sar(inst, 20);
end;

function imm_s(inst : dword) : dword;
begin
  imm_s  := sar(inst and $FE000000, 20) or rd(inst);
end;

function imm_sb(inst : dword) : dword;
var imm : dword;
begin

  imm := ((inst shr (31-12)) and (1 shl 12)) or
         ((inst shr (25- 5)) and $7e0)       or
         ((inst shr ( 8- 1)) and $1e)        or
         ((inst shl (11- 7)) and (1 shl 11));

  imm_sb := sar((imm shl 19), 19);

// imm = ((insn >> (31 - 12)) & (1 << 12)) |
//     ((insn >> (25 - 5)) & 0x7e0) |
//     ((insn >> (8 - 1)) & 0x1e) |
//     ((insn << (11 - 7)) & (1 << 11));
// imm = (imm << 19) >> 19;
end;

function imm_u (inst : dword) : dword;
begin
  imm_u := inst and $FFFFF000;
end;


function imm_uj(inst : dword) : dword;
var imm : dword;
begin

  imm := ((inst shr (31-20)) and (1 shl 20)) or
         ((inst shr (21- 1)) and $7fe)       or
         ((inst shr (20-11)) and (1 shl 11)) or
          (inst and $ff000);
  imm_uj := sar((imm shl 11), 11);

// imm = ((insn >> (31 - 20)) & (1 << 20)) |
//     ((insn >> (21 - 1)) & 0x7fe) |
//     ((insn >> (20 - 11)) & (1 << 11)) |
//     (insn & 0xff000);
// imm = (imm << 11) >> 11;

end;

// ----------------------------------------------------------------------------
//  Small utilities for the disassembler

function printregister(register : dword) : string;
begin
  case register of
    0: printregister := 'zero';
  else
    printregister := 'x' + inttostr(register);
  end;
end;

// ----------------------------------------------------------------------------
//  Disassembler

function disassemble_immediate(addr, inst : dword) : string;
var s : string;
    immediate : dword;
begin

  immediate := imm_i(inst);
  case funct3(inst) of
    0 : s := 'addi   ';
    1 : s := 'slli   ';
    2 : s := 'slti   ';
    3 : s := 'sltiu  ';
    4 : s := 'xori   ';
    5 : begin if (inst shr 26) = 16 then s := 'srai   ' else s := 'srli   '; immediate := immediate and $1F; end;
    6 : s := 'ori    ';
    7 : s := 'andi   ';
  else
    s := '?';
  end;

  disassemble_immediate := s + printregister(rd(inst)) + ', ' + printregister(rs1(inst)) + ', ' + dword2hex(immediate);
end;


function disassemble_jalr(addr, inst : dword) : string;
begin
  disassemble_jalr := 'jalr   ' + printregister(rd(inst)) + ', ' + dword2hex(imm_i(inst)) + ' (' + printregister(rs1(inst)) + ')';
end;


function disassemble_load(addr, inst : dword) : string;
var s : string;
    immediate : dword;
begin

  immediate := imm_i(inst);
  case funct3(inst) of
    0 : s := 'lb     ';
    1 : s := 'lh     ';
    2 : s := 'lw     ';
    4 : s := 'lbu    ';
    5 : s := 'lhu    ';
  else
    s := '?';
  end;

  disassemble_load := s + printregister(rd(inst)) + ', ' + dword2hex(immediate) + ' (' + printregister(rs1(inst)) + ')';
end;


function disassemble_register(addr, inst : dword) : string;
var s : string;
begin

if funct7(inst) = 1 then  // RV32M
begin

  case funct3(inst) of
    0 : s := 'mul    ';
    1 : s := 'mulh   ';
    2 : s := 'mulhsu ';
    3 : s := 'mulhu  ';
    4 : s := 'div    ';
    5 : s := 'divu   ';
    6 : s := 'rem    ';
    7 : s := 'remu   ';
  else
    s := '?';
  end;

end
else
begin

  case funct3(inst) of
    0 : if funct7(inst) = 32 then s := 'sub    ' else s := 'add    ';
    1 : s := 'sll    ';
    2 : s := 'slt    ';
    3 : s := 'sltu   ';
    4 : s := 'xor    ';
    5 : if funct7(inst) = 32 then s := 'sra    ' else s := 'srl    ';
    6 : s := 'or     ';
    7 : s := 'and    ';
  else
    s := '?';
  end;

end;

  disassemble_register := s + printregister(rd(inst)) + ', ' + printregister(rs1(inst)) + ', ' + printregister(rs2(inst));
end;

function disassemble_jal(addr, inst : dword) : string;
begin
  disassemble_jal := 'jal    ' + printregister(rd(inst)) + ', ' + dword2hex(addr + imm_uj(inst));
end;

function disassemble_lui(addr, inst : dword) : string;
begin
  disassemble_lui := 'lui    ' + printregister(rd(inst)) + ', ' + dword2hex(imm_u(inst));
end;

function disassemble_auipc(addr, inst : dword) : string;
begin
  disassemble_auipc := 'auipc  ' + printregister(rd(inst)) + ', ' + dword2hex(imm_u(inst));
end;

function disassemble_store(addr, inst : dword) : string;
var s : string;
begin

  case funct3(inst) of
    0 : s := 'sb     ';
    1 : s := 'sh     ';
    2 : s := 'sw     ';
  else
    s := '?';
  end;

  disassemble_store := s + printregister(rs2(inst)) + ', ' + dword2hex(imm_s(inst)) + ' (' + printregister(rs1(inst)) + ')';
end;

function disassemble_branch(addr, inst : dword) : string;
var s : string;
begin

  case funct3(inst) of
    0 : s := 'beq    ';
    1 : s := 'bne    ';
    4 : s := 'blt    ';
    5 : s := 'bge    ';
    6 : s := 'bltu   ';
    7 : s := 'bgeu   ';
  else
    s := '?';
  end;

  disassemble_branch := s + printregister(rs1(inst)) + ', ' + printregister(rs2(inst)) + ', ' + dword2hex(addr + imm_sb(inst));
end;

// ----------------------------------------------------------------------------

function disassemble(addr, inst : dword) : string;
begin
  // 32 bit opcodes always have %11 set.
  case opcode(inst) of
    $03: disassemble := disassemble_load      (addr, inst);
    $13: disassemble := disassemble_immediate (addr, inst);
    $17: disassemble := disassemble_auipc     (addr, inst);
    $23: disassemble := disassemble_store     (addr, inst);
    $33: disassemble := disassemble_register  (addr, inst);
    $37: disassemble := disassemble_lui       (addr, inst);
    $63: disassemble := disassemble_branch    (addr, inst);
    $67: disassemble := disassemble_jalr      (addr, inst);
    $6F: disassemble := disassemble_jal       (addr, inst);
  else
    //disassemble := 'Unknown opcode ' + dword2hex(opcode(inst));
      disassemble := '';
  end;

end;

// ----------------------------------------------------------------------------
//  Register definitions for emulator

var registers : array[1..31] of dword;
    pc : dword;

procedure write_register(register, data : dword);  begin if register <> 0 then registers[register] := data; end;
function read_register(register : dword) : dword;  begin if register <> 0 then read_register := registers[register] else read_register := 0; end;

function get_pc : dword; begin get_pc := pc; end;
procedure set_pc(destination : dword); begin pc := destination; end;

// ----------------------------------------------------------------------------
//  Emulator

procedure execute_immediate(inst : dword);
begin
  case funct3(inst) of
    0 : write_register(rd(inst), read_register(rs1(inst))  +  imm_i(inst) ); // addi
    1 : write_register(rd(inst), read_register(rs1(inst)) shl (imm_i(inst) and $1F) ); // slli
    2 : if signedless(read_register(rs1(inst)),  imm_i(inst)) then write_register(rd(inst), 1) else write_register(rd(inst), 0); // slti
    3 : if            read_register(rs1(inst)) < imm_i(inst)  then write_register(rd(inst), 1) else write_register(rd(inst), 0); // sltiu
    4 : write_register(rd(inst), read_register(rs1(inst)) xor imm_i(inst) ); // xori
    5 : if  (inst shr 26) = 16
   then write_register(rd(inst), sar(read_register(rs1(inst)),    (imm_i(inst) and $1F) ) )  // srai
   else write_register(rd(inst),     read_register(rs1(inst)) shr (imm_i(inst) and $1F)   ); // srli
    6 : write_register(rd(inst), read_register(rs1(inst))  or imm_i(inst) ); // ori
    7 : write_register(rd(inst), read_register(rs1(inst)) and imm_i(inst) ); // andi
  end;
  set_pc(get_pc + 4);
end;

procedure execute_jalr(inst : dword);
var destination : dword;
begin
  // if rd(inst) <> 0 then writeln('JALR: ', dword2hex(get_pc), ' : ', dword2hex(inst), ' ', rd(inst), ' ', rs1(inst), ' ', dword2hex(((read_register(rs1(inst)) + imm_i(inst))) and $FFFFFFFE) );

  destination := ((read_register(rs1(inst)) + imm_i(inst))) and $FFFFFFFE;
  write_register(rd(inst), get_pc + 4);
  set_pc(destination);
end;

procedure execute_load(inst : dword);
begin
  case funct3(inst) of
    0 : write_register(rd(inst), sign8 (read8 (read_register(rs1(inst)) + imm_i(inst)))); // lb
    1 : write_register(rd(inst), sign16(read16(read_register(rs1(inst)) + imm_i(inst)))); // lh
    2 : write_register(rd(inst),        read32(read_register(rs1(inst)) + imm_i(inst)) ); // lw
    4 : write_register(rd(inst),        read8 (read_register(rs1(inst)) + imm_i(inst)) ); // lbu
    5 : write_register(rd(inst),        read16(read_register(rs1(inst)) + imm_i(inst)) ); // lhu
  end;
  set_pc(get_pc + 4);
end;


function sign64(data : uint32) : int64;
begin
  if (data and $80000000) = $80000000 then sign64 := data or $FFFFFFFF00000000
                                      else sign64 := data;
end;

procedure execute_register(inst : dword);
var ud1, ud2, ud : uint64;
    d1, d2, d : int64;

    signed1, signed2, signed : int32;
    unsigned1, unsigned2, unsigned : uint32;

begin

if funct7(inst) = 1 then  // RV32M
begin

  case funct3(inst) of
    0 : write_register(rd(inst), read_register(rs1(inst)) * read_register(rs2(inst)) ); // mul
    1 : begin // mulh    high part
          d1 := sign64(read_register(rs1(inst)));
          d2 := sign64(read_register(rs2(inst)));
          d := d1 * d2;
          write_register(rd(inst), d shr 32 );
        end;
    2 : begin // mulhsu
          ud1 := read_register(rs1(inst));
          d2 := sign64(read_register(rs2(inst)));
          d := ud1 * d2;
          write_register(rd(inst), d shr 32 );
        end;
    3 : begin // mulhu
          ud1 := read_register(rs1(inst));
          ud2 := read_register(rs2(inst));
          ud := ud1 * ud2;
          write_register(rd(inst), ud shr 32 );
        end;
    4 : begin // div
          signed1 := read_register(rs1(inst));
          signed2 := read_register(rs2(inst));
          signed := signed1 div signed2;
          write_register(rd(inst), signed);
        end;
    5 : begin // divu
          unsigned1 := read_register(rs1(inst));
          unsigned2 := read_register(rs2(inst));
          unsigned := unsigned1 div unsigned2;
          write_register(rd(inst), unsigned);
        end;
    6 : begin // rem
          signed1 := read_register(rs1(inst));
          signed2 := read_register(rs2(inst));
          signed := signed1 mod signed2;
          write_register(rd(inst), signed);
        end;
    7 : begin // remu
          unsigned1 := read_register(rs1(inst));
          unsigned2 := read_register(rs2(inst));
          unsigned := unsigned1 mod unsigned2;
          write_register(rd(inst), unsigned);
        end;
  end;

end
else
begin

  case funct3(inst) of
    0 : if funct7(inst) = 32
   then write_register(rd(inst), read_register(rs1(inst))  -   read_register(rs2(inst)) )  // sub
   else write_register(rd(inst), read_register(rs1(inst))  +   read_register(rs2(inst)) ); // add
    1 : write_register(rd(inst), read_register(rs1(inst)) shl  read_register(rs2(inst)) );  // sll
    2:  if signedless(read_register(rs1(inst)),  read_register(rs2(inst)) ) then write_register(rd(inst), 1) else write_register(rd(inst), 0); // slt
    3 : if            read_register(rs1(inst)) < read_register(rs2(inst))   then write_register(rd(inst), 1) else write_register(rd(inst), 0); // sltu
    4 : write_register(rd(inst), read_register(rs1(inst)) xor read_register(rs2(inst)) );  // xor
    5 : if funct7(inst) = 32
   then write_register(rd(inst), sar( read_register(rs1(inst)),     read_register(rs2(inst)) ) )  // sra
   else write_register(rd(inst),      read_register(rs1(inst)) shr  read_register(rs2(inst))   ); // srl
    6 : write_register(rd(inst), read_register(rs1(inst)) or  read_register(rs2(inst)) );  // or
    7 : write_register(rd(inst), read_register(rs1(inst)) and read_register(rs2(inst)) );  // and
  end;

end;

  set_pc(get_pc + 4);
end; // execute_register

procedure execute_jal(inst : dword);
begin
  write_register(rd(inst), get_pc + 4);
  set_pc(get_pc + imm_uj(inst));
end;

procedure execute_lui(inst : dword);
begin
  write_register(rd(inst), imm_u(inst));
  set_pc(get_pc + 4);
end;

procedure execute_auipc(inst : dword);
begin
  write_register(rd(inst), get_pc + imm_u(inst));
  set_pc(get_pc + 4);
end;

procedure execute_store(inst : dword);
begin
  case funct3(inst) of
    0 : store8 (read_register(rs1(inst)) + imm_s(inst), read_register(rs2(inst)) ); // sb
    1 : store16(read_register(rs1(inst)) + imm_s(inst), read_register(rs2(inst)) ); // sh
    2 : store32(read_register(rs1(inst)) + imm_s(inst), read_register(rs2(inst)) ); // sw
  end;
  set_pc(get_pc + 4);
end;

procedure execute_branch(inst : dword);
begin
  case funct3(inst) of
    0 : if                 read_register(rs1(inst)) = read_register(rs2(inst))   then set_pc(get_pc + imm_sb(inst)) else set_pc(get_pc + 4); // beq
    1 : if not           ( read_register(rs1(inst)) = read_register(rs2(inst)) ) then set_pc(get_pc + imm_sb(inst)) else set_pc(get_pc + 4); // bne
    4 : if     signedless( read_register(rs1(inst)),  read_register(rs2(inst)) ) then set_pc(get_pc + imm_sb(inst)) else set_pc(get_pc + 4); // blt
    5 : if not signedless( read_register(rs1(inst)),  read_register(rs2(inst)) ) then set_pc(get_pc + imm_sb(inst)) else set_pc(get_pc + 4); // bge
    6 : if                 read_register(rs1(inst)) < read_register(rs2(inst))   then set_pc(get_pc + imm_sb(inst)) else set_pc(get_pc + 4); // bltu
    7 : if not           ( read_register(rs1(inst)) < read_register(rs2(inst)) ) then set_pc(get_pc + imm_sb(inst)) else set_pc(get_pc + 4); // bgeu
  end;
end;

procedure execute;
var inst : dword;
begin
  inst := read32(get_pc);

  if inst = 42 then begin writeln(disassemble(read_register(3), read32(read_register(3)))); set_pc(get_pc + 4); end;

  // 32 bit opcodes always have %11 set.
  case opcode(inst) of
    $03: execute_load      (inst);
    $13: execute_immediate (inst);
    $17: execute_auipc     (inst);
    $23: execute_store     (inst);
    $33: execute_register  (inst);
    $37: execute_lui       (inst);
    $63: execute_branch    (inst);
    $67: execute_jalr      (inst);
    $6F: execute_jal       (inst);
  else
    set_pc(get_pc + 4); // Skip unknown opcodes
  end;
end;

// ----------------------------------------------------------------------------

procedure writeregister;
var i : integer;
begin
//  for i := 0 to 15 do write(i:8, ' '); writeln;
  for i := 0 to 15 do write(dword2hex(registers[i]), ' ');//  writeln;
//  for i := 16 to 31 do write(i:8, ' '); writeln;
//  for i := 16 to 31 do write(dword2hex(registers[i]), ' '); writeln;
end;

var binaryimage : longint;
    binarysize : longint;
    addr, inst : dword;

procedure disassemblebinary;
begin
  // Disassemble the complete binary

  writeln;
  addr := 0;
  while (addr < binarysize) do
  begin
    inst := read32(addr);
    writeln(dword2hex(addr), ' : ', dword2hex(inst), '  ', disassemble(addr, inst));

    addr := addr + 4;
  end;
  writeln;
end;


begin
  // Load binary image

  fillchar(memory_flash, sizeof(memory_flash), 255);
  fillchar(memory_ram,   sizeof(memory_ram),   255);

  binaryimage := fileopen(paramstr(1), fmOpenRead);
  binarysize := fileseek(binaryimage, 0, fsFromEnd);
  writeln('Binary size: ', binarysize, ' bytes.');
  fileseek(binaryimage, 0, fsFromBeginning);
  fileread(binaryimage, memory_flash[0], binarysize);
  fileclose(binaryimage);

  // disassemblebinary;

  // Execute !

  writeln('Ready to fly !');
  set_pc($000FFF80);
  writeln('Start address: ', dword2hex(get_pc));

  //for i := 1 to 1000 do // Maximum amount of instructions...
  //begin
  repeat
    // writeregister; writeln(dword2hex(get_pc), ' : ', dword2hex(read32(get_pc)), '  ', disassemble(get_pc, read32(get_pc))); writeln;
    // write(dword2hex(get_pc), ' ', dword2hex(read32(get_pc)), ' : '); writeregister; writeln(disassemble(get_pc, read32(get_pc)));
    execute;
  until false;
  //end;

end.
