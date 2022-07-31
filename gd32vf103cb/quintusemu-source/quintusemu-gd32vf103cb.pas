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

var memory_flash : array[$00000000..$00020000] of byte;
    memory_ram   : array[$20000000..$20008000] of byte;

function flash(addr : dword) : boolean;
begin
  flash := addr < $00020000;
end;

function ram(addr : dword) : boolean;
begin
  ram := ($20000000 <= addr) and (addr < $20008000);
end;

function read8 (addr : dword) : dword;
begin

  case addr of

    $40013804: read8 := key; // USART0_DR

  else

    read8 := $FF;
    if flash(addr) then read8 := memory_flash[addr];
    if   ram(addr) then read8 :=   memory_ram[addr];
  end;

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

    $4002200C: read32 := 0; // Flash never busy

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
  case addr of

    $40013804: emit(data and $FF); // USART0_DR

  else

    addr := addr and not $08000000;

    if flash(addr) then memory_flash[addr] := data and $FF;
    if   ram(addr) then   memory_ram[addr] := data and $FF;
  end;
end;

procedure store16(addr, data : dword);
begin

  addr := addr and not $08000000;

  if flash(addr) then begin
                        memory_flash[addr  ] :=  data         and $FF;
                        memory_flash[addr+1] := (data shr  8) and $FF;
                      end;
  if   ram(addr) then begin
                          memory_ram[addr  ] :=  data         and $FF;
                          memory_ram[addr+1] := (data shr  8) and $FF;
                      end;
end;

procedure store32(addr, data : dword);
var coredump : longint;
begin
  // writeln('Store32 ', dword2hex(addr), ' ', dword2hex(data));
  case addr of

    $DABBAD00: begin // Special helper to generate binaries with precompiled sources.
                 filecreate('coredump.bin');
                 coredump := fileopen('coredump.bin', fmOpenWrite);
                 filewrite(coredump, memory_flash[0], data);
                 fileclose(coredump);
                 halt;
               end;

  else

    addr := addr and not $08000000;

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
//  Decoders for compressed instructions

function rvc_funct3(rvc_inst : word) : dword;
begin
  rvc_funct3 := rvc_inst shr 13;
end;

function imm_css(rvc_inst : word) : dword;
begin
  imm_css :=        (((rvc_inst shr  7) and   2 ) shl  6 ) or
                    (((rvc_inst shr  9) and  $F ) shl  2 ) ;
end;

function imm_csl(rvc_inst : word) : dword;
begin
  imm_csl :=        (((rvc_inst shr 12) and   1 ) shl  5 ) or
                    (((rvc_inst shr  2) and   2 ) shl  6 ) or
                    (((rvc_inst shr  4) and   7 ) shl  2 ) ;
end;

function imm_cu(rvc_inst : word) : dword;
begin
  imm_cu  :=         ((rvc_inst shr  2) and $1F          ) or
                    (((rvc_inst shr 12) and   1 ) shl  5 ) ;
end;

function imm_c(rvc_inst : word) : dword;
var imm : dword;
begin
  imm     :=         ((rvc_inst shr  2) and $1F          ) or
                    (((rvc_inst shr 12) and   1 ) shl  5 ) ;

  imm_c := sar((imm shl 26), 26);
end;

function imm_clwsw(rvc_inst : word) : dword;
begin
  imm_clwsw :=      (((rvc_inst shr  5) and   1 ) shl  6 ) or
                    (((rvc_inst shr  6) and   1 ) shl  2 ) or
                    (((rvc_inst shr 10) and   7 ) shl  3 ) ;
end;

function imm_cj(rvc_inst : word) : dword;
var imm : dword;
begin
  imm     :=        (((rvc_inst shr  2) and   1 ) shl  5 ) or
                    (((rvc_inst shr  3) and   7 ) shl  1 ) or
                    (((rvc_inst shr  6) and   1 ) shl  7 ) or
                    (((rvc_inst shr  7) and   1 ) shl  6 ) or
                    (((rvc_inst shr  8) and   1 ) shl 10 ) or
                    (((rvc_inst shr  9) and   3 ) shl  8 ) or
                    (((rvc_inst shr 11) and   1 ) shl  4 ) or
                    (((rvc_inst shr 12) and   1 ) shl 11 ) ;

  imm_cj := sar((imm shl 20), 20);
end;

function imm_cb(rvc_inst : word) : dword;
var imm : dword;
begin
  imm     :=        (((rvc_inst shr  2) and   1 ) shl  5 ) or
                    (((rvc_inst shr  3) and   3 ) shl  1 ) or
                    (((rvc_inst shr  5) and   3 ) shl  6 ) or
                    (((rvc_inst shr 10) and   3 ) shl  3 ) or
                    (((rvc_inst shr 12) and   1 ) shl  8 ) ;

  imm_cb := sar((imm shl 23), 23);
end;

function imm_addi4spn(rvc_inst : word) : dword;
begin
  imm_addi4spn :=   (((rvc_inst shr  5) and   1 ) shl  3 ) or
                    (((rvc_inst shr  6) and   1 ) shl  2 ) or
                    (((rvc_inst shr  7) and  $F ) shl  6 ) or
                    (((rvc_inst shr 11) and   3 ) shl  4 ) ;
end;

function imm_addi16sp(rvc_inst : word) : dword;
begin
  imm_addi16sp :=   (((rvc_inst shr  2) and   1 ) shl  5 ) or
                    (((rvc_inst shr  3) and   3 ) shl  7 ) or
                    (((rvc_inst shr  5) and   1 ) shl  6 ) or
                    (((rvc_inst shr  6) and   1 ) shl  4 ) or
                    (((rvc_inst shr 12) and   1 ) shl  9 ) ;
end;

// ----------------------------------------------------------------------------
//  Small utilities for the disassembler

function printregister(register : dword) : string;
begin
  case register and $1F of
    0: printregister := 'zero';
  else
    printregister := 'x' + inttostr(register and $1F);
  end;
end;

function cregister(register : dword) : string;
begin
  cregister := printregister((register and 7) + 8);
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
var rvc_inst : word;
begin
  rvc_inst := inst and $FFFF;

  case rvc_inst and 3 of

    0: begin // Quadrant 0
         case rvc_funct3(rvc_inst) of
           0 : if rvc_inst = 0
               then disassemble := 'c.illegal'
               else disassemble := 'c.addi4spn ' + cregister(rvc_inst shr 2) + ', ' + dword2hex(imm_addi4spn(rvc_inst)) ;
           2 : disassemble := 'c.lw   '          + cregister(rvc_inst shr 2) + ', ' + dword2hex(imm_clwsw(rvc_inst)) + ' (' + cregister(rvc_inst shr 7) + ')' ;
           6 : disassemble := 'c.sw   '          + cregister(rvc_inst shr 2) + ', ' + dword2hex(imm_clwsw(rvc_inst)) + ' (' + cregister(rvc_inst shr 7) + ')' ;
         else
           disassemble := 'Unknown compressed quadrant 0 opcode';
         end;
       end;

    1: begin // Quadrant 1
         case rvc_funct3(rvc_inst) of

           0 : disassemble := 'c.addi ' + printregister(rvc_inst shr 7) + ', ' + dword2hex(imm_c(rvc_inst)) ;
           2 : disassemble := 'c.li   ' + printregister(rvc_inst shr 7) + ', ' + dword2hex(imm_c(rvc_inst)) ;

           6 : disassemble := 'c.beqz ' +     cregister(rvc_inst shr 7) + ', ' + dword2hex(addr + imm_cb(rvc_inst)) ;
           7 : disassemble := 'c.bnez ' +     cregister(rvc_inst shr 7) + ', ' + dword2hex(addr + imm_cb(rvc_inst)) ;

           1 : disassemble := 'c.jal  ' + dword2hex(addr + imm_cj(rvc_inst)) ;
           5 : disassemble := 'c.j    ' + dword2hex(addr + imm_cj(rvc_inst)) ;

           3 : if (rvc_inst shr 7) and $1F = 2
               then disassemble := 'c.addi16sp ' + dword2hex(imm_addi16sp(rvc_inst))
               else disassemble := 'c.lui  ' + printregister(rvc_inst shr 7) + ', ' + dword2hex(imm_c(rvc_inst) shl 12) ;

           4 : begin
                 if rvc_inst and $0C00 = $0000 then disassemble := 'c.srli ' + cregister(rvc_inst shr 7) + ', ' + dword2hex(imm_cu(rvc_inst)) ;
                 if rvc_inst and $0C00 = $0400 then disassemble := 'c.srai ' + cregister(rvc_inst shr 7) + ', ' + dword2hex(imm_cu(rvc_inst)) ;
                 if rvc_inst and $0C00 = $0800 then disassemble := 'c.andi ' + cregister(rvc_inst shr 7) + ', ' + dword2hex(imm_c (rvc_inst)) ;
                 if rvc_inst and $1C00 = $0C00 then
                 begin
                   case (rvc_inst shr 5) and 3 of
                     0 : disassemble := 'c.sub  ' + cregister(rvc_inst shr 7) + ', ' + cregister(rvc_inst shr 2) ;
                     1 : disassemble := 'c.xor  ' + cregister(rvc_inst shr 7) + ', ' + cregister(rvc_inst shr 2) ;
                     2 : disassemble := 'c.or   ' + cregister(rvc_inst shr 7) + ', ' + cregister(rvc_inst shr 2) ;
                     3 : disassemble := 'c.and  ' + cregister(rvc_inst shr 7) + ', ' + cregister(rvc_inst shr 2) ;
                   end;
                 end;
               end;

         else
           disassemble := 'Unknown compressed quadrant 1 opcode';
         end;
       end;

    2: begin // Quadrant 2
         case rvc_funct3(rvc_inst) of

           0 : disassemble := 'c.slli ' + printregister(rvc_inst shr 7) + ', ' + dword2hex(imm_cu(rvc_inst)) ;
           2 : disassemble := 'c.lwsp ' + printregister(rvc_inst shr 7) + ', ' + dword2hex(imm_csl(rvc_inst)) + ' (x2)' ;
           6 : disassemble := 'c.swsp ' + printregister(rvc_inst shr 2) + ', ' + dword2hex(imm_css(rvc_inst)) + ' (x2)' ;

           4 : begin
                 if (rvc_inst and $1000) <> 0
                 then
                 begin
                   if (rvc_inst shr 2) and $3FF = 0 then disassemble := 'c.ebreak'
                   else
                   begin
                     if (rvc_inst shr 2) and $1F = 0
                     then disassemble := 'c.jalr ' + printregister(rvc_inst shr 7)
                     else disassemble := 'c.add  ' + printregister(rvc_inst shr 7) + ', ' + printregister(rvc_inst shr 2) ;
                   end;
                 end
                 else
                 begin
                     if (rvc_inst shr 2) and $1F = 0
                     then disassemble := 'c.jr   ' + printregister(rvc_inst shr 7)
                     else disassemble := 'c.mv   ' + printregister(rvc_inst shr 7) + ', ' + printregister(rvc_inst shr 2) ;
                 end;
               end;

         else
           disassemble := 'Unknown compressed quadrant 2 opcode';
         end;
       end;

  else // Quadrant 3
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
end;

// ----------------------------------------------------------------------------
//  Register definitions for emulator

var registers : array[1..31] of dword;
    pc : dword;

procedure write_register(register, data : dword);  begin if register and $1F <> 0 then registers[register and $1F] := data; end;
function read_register(register : dword) : dword;  begin if register and $1F <> 0 then read_register := registers[register and $1F] else read_register := 0; end;

procedure write_creg(register, data : dword);  begin             write_register((register and 7) + 8, data); end;
function read_creg(register : dword) : dword;  begin read_creg := read_register((register and 7) + 8); end;

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
    rvc_inst : word;

begin
  rvc_inst := read16(get_pc);

  case rvc_inst and 3 of

    0: begin // Quadrant 0
         case rvc_funct3(rvc_inst) of
           0 : if rvc_inst = 0
               then begin writeln(' Quintusemu: c.illegal at ', dword2hex(get_pc), ' : ', word2hex(rvc_inst)); halt; end // c.illegal
               else write_creg(rvc_inst shr 2, read_register(2) + imm_addi4spn(rvc_inst));           // c.addi4spn
           2 : write_creg(rvc_inst shr 2, read32(read_creg(rvc_inst shr 7) + imm_clwsw(rvc_inst)) ); // c.lw
           6 : store32(read_creg(rvc_inst shr 7) + imm_clwsw(rvc_inst), read_creg(rvc_inst shr 2) ); // c.sw
         else
           writeln('Unknown compressed quadrant 0 opcode ', dword2hex(get_pc), ' : ', word2hex(rvc_inst)); halt;
         end;

         set_pc(get_pc + 2); // Für alle Opcodes in Quadrant 0
       end;

    1: begin // Quadrant 1
         case rvc_funct3(rvc_inst) of

           0 : begin write_register(rvc_inst shr 7, read_register(rvc_inst shr 7) + imm_c(rvc_inst) ); set_pc(get_pc + 2); end; // c.addi
           2 : begin write_register(rvc_inst shr 7,                                 imm_c(rvc_inst) ); set_pc(get_pc + 2); end; // c.li

           6 : if read_creg(rvc_inst shr 7)  = 0 then set_pc(get_pc + imm_cb(rvc_inst) ) else set_pc(get_pc + 2); // c.beqz
           7 : if read_creg(rvc_inst shr 7) <> 0 then set_pc(get_pc + imm_cb(rvc_inst) ) else set_pc(get_pc + 2); // c.bnez

           1 : begin write_register(1, get_pc + 2); set_pc(get_pc + imm_cj(rvc_inst)); end; // c.jal
           5 :                                      set_pc(get_pc + imm_cj(rvc_inst));      // c.j

           3 : begin
                 if (rvc_inst shr 7) and $1F = 2
                 then write_register(2, read_register(2) + imm_addi16sp(rvc_inst))  // c.addi16sp
                 else write_register(rvc_inst shr 7, imm_c(rvc_inst) shl 12);        // c.lui
                 set_pc(get_pc + 2);
               end;

           4 : begin
                 if rvc_inst and $0C00 = $0000 then write_creg(rvc_inst shr 7,      read_creg(rvc_inst shr 7) shr imm_cu (rvc_inst)  ) ; // c.srli
                 if rvc_inst and $0C00 = $0400 then write_creg(rvc_inst shr 7, sar( read_creg(rvc_inst shr 7)  ,  imm_cu (rvc_inst)) ) ; // c.srai
                 if rvc_inst and $0C00 = $0800 then write_creg(rvc_inst shr 7,      read_creg(rvc_inst shr 7) and imm_c  (rvc_inst)  ) ; // c.andi
                 if rvc_inst and $1C00 = $0C00 then
                 begin
                   case (rvc_inst shr 5) and 3 of
                     0 : write_creg(rvc_inst shr 7, read_creg(rvc_inst shr 7)  -  read_creg(rvc_inst shr 2) ); // c.sub
                     1 : write_creg(rvc_inst shr 7, read_creg(rvc_inst shr 7) xor read_creg(rvc_inst shr 2) ); // c.xor
                     2 : write_creg(rvc_inst shr 7, read_creg(rvc_inst shr 7)  or read_creg(rvc_inst shr 2) ); // c.or
                     3 : write_creg(rvc_inst shr 7, read_creg(rvc_inst shr 7) and read_creg(rvc_inst shr 2) ); // c.and
                   end;
                 end;
                 set_pc(get_pc + 2);
               end;

         else
           writeln('Unknown compressed quadrant 1 opcode ', dword2hex(get_pc), ' : ', word2hex(rvc_inst)); halt;
         end;
       end;

    2: begin // Quadrant 2
         case rvc_funct3(rvc_inst) of

           0 : begin write_register(rvc_inst shr 7, read_register(rvc_inst shr 7) shl imm_cu (rvc_inst)  ) ; set_pc(get_pc + 2); end; // c.slli
           2 : begin write_register(rvc_inst shr 7, read32(read_register(2) + imm_csl(rvc_inst)) );          set_pc(get_pc + 2); end; // c.lwsp
           6 : begin store32(read_register(2) + imm_css(rvc_inst), read_register(rvc_inst shr 2));           set_pc(get_pc + 2); end; // c.swsp

           4 : begin
                 if (rvc_inst and $1000) <> 0
                 then
                 begin
                   if (rvc_inst shr 2) and $3FF = 0 then begin writeln('c.ebreak'); set_pc(get_pc + 2); end // c.ebreak
                   else
                   begin
                     if (rvc_inst shr 2) and $1F = 0
                     then begin write_register(1, get_pc + 2); set_pc(read_register(rvc_inst shr 7)); end // c.jalr
                     else begin write_register(rvc_inst shr 7, read_register(rvc_inst shr 7) + read_register(rvc_inst shr 2)); set_pc(get_pc + 2); end; // c.add
                   end;
                 end
                 else
                 begin
                     if (rvc_inst shr 2) and $1F = 0
                     then set_pc(read_register(rvc_inst shr 7)) // c.jr
                     else begin write_register(rvc_inst shr 7, read_register(rvc_inst shr 2)); set_pc(get_pc + 2); end; // c.mv
                 end;
               end;
         else
           writeln('Unknown compressed quadrant 2 opcode ', dword2hex(get_pc), ' : ', word2hex(rvc_inst)); halt;
         end;
       end;

  else
    inst := read32(get_pc);
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
end;

// ----------------------------------------------------------------------------

function printopcode(addr : dword) : string;
begin
  if (read16(addr) and 3) < 3 then printopcode :=  word2hex(read16(addr)) + '    '
                              else printopcode := dword2hex(read32(addr)) ;
end;

procedure writeregister;
var i : integer;
begin
//  for i := 0 to 15 do write(i:8, ' '); writeln;
  for i := 0 to 15 do write(dword2hex(registers[i]), ' '); writeln;
//  for i := 16 to 31 do write(i:8, ' '); writeln;
  for i := 16 to 31 do write(dword2hex(registers[i]), ' '); writeln;
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
    writeln(dword2hex(addr), ' : ', printopcode(addr), '  ', disassemble(addr, inst));

    addr := addr + 4;
  end;
  writeln;
end;

// var i : dword;

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
  set_pc($00000000);
  writeln('Start address: ', dword2hex(get_pc));

 // for i := 1 to 10000000 do // Maximum amount of instructions...
 // begin
  repeat

    // writeregister;
    // writeln(dword2hex(get_pc), ' : ', printopcode(get_pc), '  ',  disassemble(get_pc, read32(get_pc)) );
    // writeln;
    execute;
  until false;
  //end;

end.
