// SPEC: https://www.tutorialspoint.com/instruction-type-rrc-in-8085-microprocessor and https://sam.speccy.cz/asm/8080-z80_asm_techniques.pdf
// Test here: https://bluishcoder.co.nz/js8080/ and http://sensi.org/~svo/i8080/
// https://pastraiser.com/cpu/i8080/i8080_opcodes.html
// Data sheet : http://www.classiccmp.org/dunfield/r/8080.txt
// Space Invaders: http://computerarcheology.com/Arcade/SpaceInvaders/Code.html


using SLeighT80.Machines.Invaders;
// ReSharper disable IdentifierTypo
// ReSharper disable StringLiteralTypo

// ReSharper disable InconsistentNaming

namespace SLeighT80.Processors.i8080
{
    public class i8080InstructionSet
    {
        i8080 machine;

        public void InstallTo(i8080 _machine)
        {
            machine = _machine;

            // i8080 has 8 registers
            machine.Registers = new byte[8];
            machine.Ports = new byte[7];

            machine.AddInstruction(new Instruction("NOP", 0x00, 1, 4, new byte[0], NOP));
            machine.AddInstruction(new Instruction("LXI B", 0x01, 3, 10, new byte[0], LXI_B));
            machine.AddInstruction(new Instruction("STAX B", 0x02, 1, 7, new byte[0], STAX_B));
            machine.AddInstruction(new Instruction("INX B", 0x03, 1, 5, new byte[0], INX_B));
            machine.AddInstruction(new Instruction("INR B", 0x04, 1, 5, new byte[0], INR_B));
            machine.AddInstruction(new Instruction("DCR B", 0x05, 1, 5, new byte[0], DCR_B));
            machine.AddInstruction(new Instruction("MVI B", 0x06, 2, 7, new byte[0], MVI_B));
            machine.AddInstruction(new Instruction("RLC", 0x07, 1, 4, new byte[0], RLC));
            machine.AddInstruction(new Instruction("*NOP", 0x08, 1, 4, new byte[0], NOP));
            machine.AddInstruction(new Instruction("DAD B", 0x09, 1, 10, new byte[0], DAD_B));
            machine.AddInstruction(new Instruction("LDAX B", 0x0a, 1, 7, new byte[0], LDAX_B));
            machine.AddInstruction(new Instruction("DCX B", 0x0b, 1, 5, new byte[0], DCX_B));
            machine.AddInstruction(new Instruction("INR C", 0x0c, 1, 5, new byte[0], INR_C));
            machine.AddInstruction(new Instruction("DCR C", 0x0d, 1, 5, new byte[0], DCR_C));
            machine.AddInstruction(new Instruction("MVI C", 0x0e, 2, 7, new byte[0], MVI_C));
            machine.AddInstruction(new Instruction("RRC", 0x0f, 1, 4, new byte[0], RRC));
            machine.AddInstruction(new Instruction("*NOP", 0x10, 1, 4, new byte[0], NOP));
            machine.AddInstruction(new Instruction("LXI D", 0x11, 3, 10, new byte[0], LXI_D));
            machine.AddInstruction(new Instruction("STAX D", 0x12, 1, 7, new byte[0], STAX_D));
            machine.AddInstruction(new Instruction("INX D", 0x13, 1, 5, new byte[0], INX_D));
            machine.AddInstruction(new Instruction("INR D", 0x14, 1, 5, new byte[0], INR_D));
            machine.AddInstruction(new Instruction("DCR D", 0x15, 1, 5, new byte[0], DCR_D));
            machine.AddInstruction(new Instruction("MVI D", 0x16, 2, 7, new byte[0], MVI_D));
            machine.AddInstruction(new Instruction("RAL", 0x17, 1, 4, new byte[0], RAL));
            machine.AddInstruction(new Instruction("*NOP", 0x18, 1, 4, new byte[0], NOP));
            machine.AddInstruction(new Instruction("DAD D", 0x19, 1, 10, new byte[0], DAD_D));
            machine.AddInstruction(new Instruction("LDAX D", 0x1a, 1, 7, new byte[0], LDAX_D));
            machine.AddInstruction(new Instruction("DCX D", 0x1b, 1, 5, new byte[0], DCX_D));
            machine.AddInstruction(new Instruction("INR E", 0x1c, 1, 5, new byte[0], INR_E));
            machine.AddInstruction(new Instruction("DCR E", 0x1d, 1, 5, new byte[0], DCR_E));
            machine.AddInstruction(new Instruction("MVI E", 0x1e, 2, 7, new byte[0], MVI_E));
            machine.AddInstruction(new Instruction("RAR", 0x1f, 1, 4, new byte[0], RAR));
            machine.AddInstruction(new Instruction("*NOP", 0x20, 1, 4, new byte[0], NOP));
            machine.AddInstruction(new Instruction("LXI H", 0x21, 3, 10, new byte[0], LXI_H));
            machine.AddInstruction(new Instruction("SHLD", 0x22, 3, 16, new byte[0], SHLD));
            machine.AddInstruction(new Instruction("INX H", 0x23, 1, 5, new byte[0], INX_H));
            machine.AddInstruction(new Instruction("INR H", 0x24, 1, 5, new byte[0], INR_H));
            machine.AddInstruction(new Instruction("DCR H", 0x25, 1, 5, new byte[0], DCR_H));
            machine.AddInstruction(new Instruction("MVI H", 0x26, 2, 7, new byte[0], MVI_H));
            machine.AddInstruction(new Instruction("DAA", 0x27, 1, 4, new byte[0], DAA));
            machine.AddInstruction(new Instruction("*NOP", 0x28, 1, 4, new byte[0], NOP));
            machine.AddInstruction(new Instruction("DAD H", 0x29, 1, 10, new byte[0], DAD_H));
            machine.AddInstruction(new Instruction("LHLD", 0x2a, 3, 16, new byte[0], LHLD));
            machine.AddInstruction(new Instruction("DCX H", 0x2b, 1, 5, new byte[0], DCX_H));
            machine.AddInstruction(new Instruction("INR L", 0x2c, 1, 5, new byte[0], INR_L));
            machine.AddInstruction(new Instruction("DCR L", 0x2d, 1, 5, new byte[0], DCR_L));
            machine.AddInstruction(new Instruction("MVI L", 0x2e, 2, 7, new byte[0], MVI_L));
            machine.AddInstruction(new Instruction("CMA", 0x2f, 1, 4, new byte[0], CMA));
            machine.AddInstruction(new Instruction("*NOP", 0x30, 1, 4, new byte[0], NOP));
            machine.AddInstruction(new Instruction("LXI SP", 0x31, 3, 10, new byte[0], LXI_SP));
            machine.AddInstruction(new Instruction("STA", 0x32, 3, 13, new byte[0], STA));
            machine.AddInstruction(new Instruction("INX SP", 0x33, 1, 5, new byte[0], INX_SP));
            machine.AddInstruction(new Instruction("INR M", 0x34, 1, 10, new byte[0], INR_M));
            machine.AddInstruction(new Instruction("DCR M", 0x35, 1, 10, new byte[0], DCR_M));
            machine.AddInstruction(new Instruction("MVI M", 0x36, 2, 10, new byte[0], MVI_M));
            machine.AddInstruction(new Instruction("STC", 0x37, 1, 4, new byte[0], STC));
            machine.AddInstruction(new Instruction("*NOP", 0x38, 1, 4, new byte[0], NOP));
            machine.AddInstruction(new Instruction("DAD SP", 0x39, 1, 10, new byte[0], DAD_SP));
            machine.AddInstruction(new Instruction("LDA", 0x3a, 3, 13, new byte[0], LDA));
            machine.AddInstruction(new Instruction("DCX SP", 0x3b, 1, 5, new byte[0], DCX_SP));
            machine.AddInstruction(new Instruction("INR A", 0x3c, 1, 5, new byte[0], INR_A));
            machine.AddInstruction(new Instruction("DCR A", 0x3d, 1, 5, new byte[0], DCR_A));
            machine.AddInstruction(new Instruction("MVI A", 0x3e, 2, 7, new byte[0], MVI_A));
            machine.AddInstruction(new Instruction("CMC", 0x3f, 1, 4, new byte[0], CMC));
            machine.AddInstruction(new Instruction("MOV B,B", 0x40, 1, 5, new byte[0], MOV_B_B));
            machine.AddInstruction(new Instruction("MOV B,C", 0x41, 1, 5, new byte[0], MOV_B_C));
            machine.AddInstruction(new Instruction("MOV B,D", 0x42, 1, 5, new byte[0], MOV_B_D));
            machine.AddInstruction(new Instruction("MOV B,E", 0x43, 1, 5, new byte[0], MOV_B_E));
            machine.AddInstruction(new Instruction("MOV B,H", 0x44, 1, 5, new byte[0], MOV_B_H));
            machine.AddInstruction(new Instruction("MOV B,L", 0x45, 1, 5, new byte[0], MOV_B_L));
            machine.AddInstruction(new Instruction("MOV B,M", 0x46, 1, 7, new byte[0], MOV_B_M));
            machine.AddInstruction(new Instruction("MOV B,A", 0x47, 1, 5, new byte[0], MOV_B_A));
            machine.AddInstruction(new Instruction("MOV C,B", 0x48, 1, 5, new byte[0], MOV_C_B));
            machine.AddInstruction(new Instruction("MOV C,C", 0x49, 1, 5, new byte[0], MOV_C_C));
            machine.AddInstruction(new Instruction("MOV C,D", 0x4a, 1, 5, new byte[0], MOV_C_D));
            machine.AddInstruction(new Instruction("MOV C,E", 0x4b, 1, 5, new byte[0], MOV_C_E));
            machine.AddInstruction(new Instruction("MOV C,H", 0x4c, 1, 5, new byte[0], MOV_C_H));
            machine.AddInstruction(new Instruction("MOV C,L", 0x4d, 1, 5, new byte[0], MOV_C_L));
            machine.AddInstruction(new Instruction("MOV C,M", 0x4e, 1, 7, new byte[0], MOV_C_M));
            machine.AddInstruction(new Instruction("MOV C,A", 0x4f, 1, 5, new byte[0], MOV_C_A));
            machine.AddInstruction(new Instruction("MOV D,B", 0x50, 1, 5, new byte[0], MOV_D_B));
            machine.AddInstruction(new Instruction("MOV D,C", 0x51, 1, 5, new byte[0], MOV_D_C));
            machine.AddInstruction(new Instruction("MOV D,D", 0x52, 1, 5, new byte[0], MOV_D_D));
            machine.AddInstruction(new Instruction("MOV D,E", 0x53, 1, 5, new byte[0], MOV_D_E));
            machine.AddInstruction(new Instruction("MOV D,H", 0x54, 1, 5, new byte[0], MOV_D_H));
            machine.AddInstruction(new Instruction("MOV D,L", 0x55, 1, 5, new byte[0], MOV_D_L));
            machine.AddInstruction(new Instruction("MOV D,M", 0x56, 1, 7, new byte[0], MOV_D_M));
            machine.AddInstruction(new Instruction("MOV D,A", 0x57, 1, 5, new byte[0], MOV_D_A));
            machine.AddInstruction(new Instruction("MOV E,B", 0x58, 1, 5, new byte[0], MOV_E_B));
            machine.AddInstruction(new Instruction("MOV E,C", 0x59, 1, 5, new byte[0], MOV_E_C));
            machine.AddInstruction(new Instruction("MOV E,D", 0x5a, 1, 5, new byte[0], MOV_E_D));
            machine.AddInstruction(new Instruction("MOV E,E", 0x5b, 1, 5, new byte[0], MOV_E_E));
            machine.AddInstruction(new Instruction("MOV E,H", 0x5c, 1, 5, new byte[0], MOV_E_H));
            machine.AddInstruction(new Instruction("MOV E,L", 0x5d, 1, 5, new byte[0], MOV_E_L));
            machine.AddInstruction(new Instruction("MOV E,M", 0x5e, 1, 7, new byte[0], MOV_E_M));
            machine.AddInstruction(new Instruction("MOV E,A", 0x5f, 1, 5, new byte[0], MOV_E_A));
            machine.AddInstruction(new Instruction("MOV H,B", 0x60, 1, 5, new byte[0], MOV_H_B));
            machine.AddInstruction(new Instruction("MOV H,C", 0x61, 1, 5, new byte[0], MOV_H_C));
            machine.AddInstruction(new Instruction("MOV H,D", 0x62, 1, 5, new byte[0], MOV_H_D));
            machine.AddInstruction(new Instruction("MOV H,E", 0x63, 1, 5, new byte[0], MOV_H_E));
            machine.AddInstruction(new Instruction("MOV H,H", 0x64, 1, 5, new byte[0], MOV_H_H));
            machine.AddInstruction(new Instruction("MOV H,L", 0x65, 1, 5, new byte[0], MOV_H_L));
            machine.AddInstruction(new Instruction("MOV H,M", 0x66, 1, 7, new byte[0], MOV_H_M));
            machine.AddInstruction(new Instruction("MOV H,A", 0x67, 1, 5, new byte[0], MOV_H_A));
            machine.AddInstruction(new Instruction("MOV L,B", 0x68, 1, 5, new byte[0], MOV_L_B));
            machine.AddInstruction(new Instruction("MOV L,C", 0x69, 1, 5, new byte[0], MOV_L_C));
            machine.AddInstruction(new Instruction("MOV L,D", 0x6a, 1, 5, new byte[0], MOV_L_D));
            machine.AddInstruction(new Instruction("MOV L,E", 0x6b, 1, 5, new byte[0], MOV_L_E));
            machine.AddInstruction(new Instruction("MOV L,H", 0x6c, 1, 5, new byte[0], MOV_L_H));
            machine.AddInstruction(new Instruction("MOV L,L", 0x6d, 1, 5, new byte[0], MOV_L_L));
            machine.AddInstruction(new Instruction("MOV L,M", 0x6e, 1, 7, new byte[0], MOV_L_M));
            machine.AddInstruction(new Instruction("MOV L,A", 0x6f, 1, 5, new byte[0], MOV_L_A));
            machine.AddInstruction(new Instruction("MOV M,B", 0x70, 1, 7, new byte[0], MOV_M_B));
            machine.AddInstruction(new Instruction("MOV M,C", 0x71, 1, 7, new byte[0], MOV_M_C));
            machine.AddInstruction(new Instruction("MOV M,D", 0x72, 1, 7, new byte[0], MOV_M_D));
            machine.AddInstruction(new Instruction("MOV M,E", 0x73, 1, 7, new byte[0], MOV_M_E));
            machine.AddInstruction(new Instruction("MOV M,H", 0x74, 1, 7, new byte[0], MOV_M_H));
            machine.AddInstruction(new Instruction("MOV M,L", 0x75, 1, 7, new byte[0], MOV_M_L));
            machine.AddInstruction(new Instruction("HLT", 0x76, 1, 7, new byte[0], HLT));
            machine.AddInstruction(new Instruction("MOV M,A", 0x77, 1, 7, new byte[0], MOV_M_A));
            machine.AddInstruction(new Instruction("MOV A,B", 0x78, 1, 5, new byte[0], MOV_A_B));
            machine.AddInstruction(new Instruction("MOV A,C", 0x79, 1, 5, new byte[0], MOV_A_C));
            machine.AddInstruction(new Instruction("MOV A,D", 0x7a, 1, 5, new byte[0], MOV_A_D));
            machine.AddInstruction(new Instruction("MOV A,E", 0x7b, 1, 5, new byte[0], MOV_A_E));
            machine.AddInstruction(new Instruction("MOV A,H", 0x7c, 1, 5, new byte[0], MOV_A_H));
            machine.AddInstruction(new Instruction("MOV A,L", 0x7d, 1, 5, new byte[0], MOV_A_L));
            machine.AddInstruction(new Instruction("MOV A,M", 0x7e, 1, 7, new byte[0], MOV_A_M));
            machine.AddInstruction(new Instruction("MOV A,A", 0x7f, 1, 5, new byte[0], MOV_A_A));
            machine.AddInstruction(new Instruction("ADD B", 0x80, 1, 4, new byte[0], ADD_B));
            machine.AddInstruction(new Instruction("ADD C", 0x81, 1, 4, new byte[0], ADD_C));
            machine.AddInstruction(new Instruction("ADD D", 0x82, 1, 4, new byte[0], ADD_D));
            machine.AddInstruction(new Instruction("ADD E", 0x83, 1, 4, new byte[0], ADD_E));
            machine.AddInstruction(new Instruction("ADD H", 0x84, 1, 4, new byte[0], ADD_H));
            machine.AddInstruction(new Instruction("ADD L", 0x85, 1, 4, new byte[0], ADD_L));
            machine.AddInstruction(new Instruction("ADD M", 0x86, 1, 7, new byte[0], ADD_M));
            machine.AddInstruction(new Instruction("ADD A", 0x87, 1, 4, new byte[0], ADD_A));
            machine.AddInstruction(new Instruction("ADC B", 0x88, 1, 4, new byte[0], ADC_B));
            machine.AddInstruction(new Instruction("ADC C", 0x89, 1, 4, new byte[0], ADC_C));
            machine.AddInstruction(new Instruction("ADC D", 0x8a, 1, 4, new byte[0], ADC_D));
            machine.AddInstruction(new Instruction("ADC E", 0x8b, 1, 4, new byte[0], ADC_E));
            machine.AddInstruction(new Instruction("ADC H", 0x8c, 1, 4, new byte[0], ADC_H));
            machine.AddInstruction(new Instruction("ADC L", 0x8d, 1, 4, new byte[0], ADC_L));
            machine.AddInstruction(new Instruction("ADC M", 0x8e, 1, 7, new byte[0], ADC_M));
            machine.AddInstruction(new Instruction("ADC A", 0x8f, 1, 4, new byte[0], ADC_A));
            machine.AddInstruction(new Instruction("SUB B", 0x90, 1, 4, new byte[0], SUB_B));
            machine.AddInstruction(new Instruction("SUB C", 0x91, 1, 4, new byte[0], SUB_C));
            machine.AddInstruction(new Instruction("SUB D", 0x92, 1, 4, new byte[0], SUB_D));
            machine.AddInstruction(new Instruction("SUB E", 0x93, 1, 4, new byte[0], SUB_E));
            machine.AddInstruction(new Instruction("SUB H", 0x94, 1, 4, new byte[0], SUB_H));
            machine.AddInstruction(new Instruction("SUB L", 0x95, 1, 4, new byte[0], SUB_L));
            machine.AddInstruction(new Instruction("SUB M", 0x96, 1, 7, new byte[0], SUB_M));
            machine.AddInstruction(new Instruction("SUB A", 0x97, 1, 4, new byte[0], SUB_A));
            machine.AddInstruction(new Instruction("SBB B", 0x98, 1, 4, new byte[0], SBB_B));
            machine.AddInstruction(new Instruction("SBB C", 0x99, 1, 4, new byte[0], SBB_C));
            machine.AddInstruction(new Instruction("SBB D", 0x9a, 1, 4, new byte[0], SBB_D));
            machine.AddInstruction(new Instruction("SBB E", 0x9b, 1, 4, new byte[0], SBB_E));
            machine.AddInstruction(new Instruction("SBB H", 0x9c, 1, 4, new byte[0], SBB_H));
            machine.AddInstruction(new Instruction("SBB L", 0x9d, 1, 4, new byte[0], SBB_L));
            machine.AddInstruction(new Instruction("SBB M", 0x9e, 1, 7, new byte[0], SBB_M));
            machine.AddInstruction(new Instruction("SBB A", 0x9f, 1, 4, new byte[0], SBB_A));
            machine.AddInstruction(new Instruction("ANA B", 0xa0, 1, 4, new byte[0], ANA_B));
            machine.AddInstruction(new Instruction("ANA C", 0xa1, 1, 4, new byte[0], ANA_C));
            machine.AddInstruction(new Instruction("ANA D", 0xa2, 1, 4, new byte[0], ANA_D));
            machine.AddInstruction(new Instruction("ANA E", 0xa3, 1, 4, new byte[0], ANA_E));
            machine.AddInstruction(new Instruction("ANA H", 0xa4, 1, 4, new byte[0], ANA_H));
            machine.AddInstruction(new Instruction("ANA L", 0xa5, 1, 4, new byte[0], ANA_L));
            machine.AddInstruction(new Instruction("ANA M", 0xa6, 1, 7, new byte[0], ANA_M));
            machine.AddInstruction(new Instruction("ANA A", 0xa7, 1, 4, new byte[0], ANA_A));
            machine.AddInstruction(new Instruction("XRA B", 0xa8, 1, 4, new byte[0], XRA_B));
            machine.AddInstruction(new Instruction("XRA C", 0xa9, 1, 4, new byte[0], XRA_C));
            machine.AddInstruction(new Instruction("XRA D", 0xaa, 1, 4, new byte[0], XRA_D));
            machine.AddInstruction(new Instruction("XRA E", 0xab, 1, 4, new byte[0], XRA_E));
            machine.AddInstruction(new Instruction("XRA H", 0xac, 1, 4, new byte[0], XRA_H));
            machine.AddInstruction(new Instruction("XRA L", 0xad, 1, 4, new byte[0], XRA_L));
            machine.AddInstruction(new Instruction("XRA M", 0xae, 1, 7, new byte[0], XRA_M));
            machine.AddInstruction(new Instruction("XRA A", 0xaf, 1, 4, new byte[0], XRA_A));
            machine.AddInstruction(new Instruction("ORA B", 0xb0, 1, 4, new byte[0], ORA_B));
            machine.AddInstruction(new Instruction("ORA C", 0xb1, 1, 4, new byte[0], ORA_C));
            machine.AddInstruction(new Instruction("ORA D", 0xb2, 1, 4, new byte[0], ORA_D));
            machine.AddInstruction(new Instruction("ORA E", 0xb3, 1, 4, new byte[0], ORA_E));
            machine.AddInstruction(new Instruction("ORA H", 0xb4, 1, 4, new byte[0], ORA_H));
            machine.AddInstruction(new Instruction("ORA L", 0xb5, 1, 4, new byte[0], ORA_L));
            machine.AddInstruction(new Instruction("ORA M", 0xb6, 1, 7, new byte[0], ORA_M));
            machine.AddInstruction(new Instruction("ORA A", 0xb7, 1, 4, new byte[0], ORA_A));
            machine.AddInstruction(new Instruction("CMP B", 0xb8, 1, 4, new byte[0], CMP_B));
            machine.AddInstruction(new Instruction("CMP C", 0xb9, 1, 4, new byte[0], CMP_C));
            machine.AddInstruction(new Instruction("CMP D", 0xba, 1, 4, new byte[0], CMP_D));
            machine.AddInstruction(new Instruction("CMP E", 0xbb, 1, 4, new byte[0], CMP_E));
            machine.AddInstruction(new Instruction("CMP H", 0xbc, 1, 4, new byte[0], CMP_H));
            machine.AddInstruction(new Instruction("CMP L", 0xbd, 1, 4, new byte[0], CMP_L));
            machine.AddInstruction(new Instruction("CMP M", 0xbe, 1, 7, new byte[0], CMP_M));
            machine.AddInstruction(new Instruction("CMP A", 0xbf, 1, 4, new byte[0], CMP_A));
            machine.AddInstruction(new Instruction("RNZ", 0xc0, 1, 11, new byte[5], RNZ));
            machine.AddInstruction(new Instruction("POP B", 0xc1, 1, 10, new byte[0], POP_B));
            machine.AddInstruction(new Instruction("JNZ", 0xc2, 3, 10, new byte[0], JNZ));
            machine.AddInstruction(new Instruction("JMP", 0xc3, 3, 10, new byte[0], JMP));
            machine.AddInstruction(new Instruction("CNZ", 0xc4, 3, 17, new byte[11], CNZ));
            machine.AddInstruction(new Instruction("PUSH B", 0xc5, 1, 11, new byte[0], PUSH_B));
            machine.AddInstruction(new Instruction("ADI", 0xc6, 2, 7, new byte[0], ADI));
            machine.AddInstruction(new Instruction("RST 0", 0xc7, 1, 11, new byte[0], RST_0));
            machine.AddInstruction(new Instruction("RZ", 0xc8, 1, 11, new byte[5], RZ));
            machine.AddInstruction(new Instruction("RET", 0xc9, 1, 10, new byte[0], RET));
            machine.AddInstruction(new Instruction("JZ", 0xca, 3, 10, new byte[0], JZ));
            machine.AddInstruction(new Instruction("*JMP", 0xcb, 3, 10, new byte[0], JMP));
            machine.AddInstruction(new Instruction("CZ", 0xcc, 3, 17, new byte[11], CZ));
            machine.AddInstruction(new Instruction("CALL", 0xcd, 3, 17, new byte[0], CALL));
            machine.AddInstruction(new Instruction("ACI", 0xce, 2, 7, new byte[0], ACI));
            machine.AddInstruction(new Instruction("RST 1", 0xcf, 1, 11, new byte[0], RST_1));
            machine.AddInstruction(new Instruction("RNC", 0xd0, 1, 11, new byte[5], RNC));
            machine.AddInstruction(new Instruction("POP D", 0xd1, 1, 10, new byte[0], POP_D));
            machine.AddInstruction(new Instruction("JNC", 0xd2, 3, 10, new byte[0], JNC));
            machine.AddInstruction(new Instruction("OUT", 0xd3, 2, 10, new byte[0], OUT));
            machine.AddInstruction(new Instruction("CNC", 0xd4, 3, 17, new byte[11], CNC));
            machine.AddInstruction(new Instruction("PUSH D", 0xd5, 1, 11, new byte[0], PUSH_D));
            machine.AddInstruction(new Instruction("SUI", 0xd6, 2, 7, new byte[0], SUI));
            machine.AddInstruction(new Instruction("RST 2", 0xd7, 1, 11, new byte[0], RST_2));
            machine.AddInstruction(new Instruction("RC", 0xd8, 1, 11, new byte[5], RC));
            machine.AddInstruction(new Instruction("*RET", 0xd9, 1, 10, new byte[0], RET));
            machine.AddInstruction(new Instruction("JC", 0xda, 3, 10, new byte[0], JC));
            machine.AddInstruction(new Instruction("IN", 0xdb, 2, 10, new byte[0], IN));
            machine.AddInstruction(new Instruction("CC", 0xdc, 3, 17, new byte[11], CC));
            machine.AddInstruction(new Instruction("*CALL", 0xdd, 3, 17, new byte[0], CALL));
            machine.AddInstruction(new Instruction("SBI", 0xde, 2, 7, new byte[0], SBI));
            machine.AddInstruction(new Instruction("RST 3", 0xdf, 1, 11, new byte[0], RST_3));
            machine.AddInstruction(new Instruction("RPO", 0xe0, 1, 11, new byte[5], RPO));
            machine.AddInstruction(new Instruction("POP H", 0xe1, 1, 10, new byte[0], POP_H));
            machine.AddInstruction(new Instruction("JPO", 0xe2, 3, 10, new byte[0], JPO));
            machine.AddInstruction(new Instruction("XTHL", 0xe3, 1, 18, new byte[0], XTHL));
            machine.AddInstruction(new Instruction("CPO", 0xe4, 3, 17, new byte[11], CPO));
            machine.AddInstruction(new Instruction("PUSH H", 0xe5, 1, 11, new byte[0], PUSH_H));
            machine.AddInstruction(new Instruction("ANI", 0xe6, 2, 7, new byte[0], ANI));
            machine.AddInstruction(new Instruction("RST 4", 0xe7, 1, 11, new byte[0], RST_4));
            machine.AddInstruction(new Instruction("RPE", 0xe8, 1, 11, new byte[5], RPE));
            machine.AddInstruction(new Instruction("PCHL", 0xe9, 1, 5, new byte[0], PCHL));
            machine.AddInstruction(new Instruction("JPE", 0xea, 3, 10, new byte[0], JPE));
            machine.AddInstruction(new Instruction("XCHG", 0xeb, 1, 5, new byte[0], XCHG));
            machine.AddInstruction(new Instruction("CPE", 0xec, 3, 17, new byte[11], CPE));
            machine.AddInstruction(new Instruction("*CALL", 0xed, 3, 17, new byte[0], CALL));
            machine.AddInstruction(new Instruction("XRI", 0xee, 2, 7, new byte[0], XRI));
            machine.AddInstruction(new Instruction("RST 5", 0xef, 1, 11, new byte[0], RST_5));
            machine.AddInstruction(new Instruction("RP", 0xf0, 1, 11, new byte[5], RP));
            machine.AddInstruction(new Instruction("POP PSW", 0xf1, 1, 10, new byte[0], POP_PSW));
            machine.AddInstruction(new Instruction("JP", 0xf2, 3, 10, new byte[0], JP));
            machine.AddInstruction(new Instruction("DI", 0xf3, 1, 4, new byte[0], DI));
            machine.AddInstruction(new Instruction("CP", 0xf4, 3, 17, new byte[11], CP));
            machine.AddInstruction(new Instruction("PUSH PSW", 0xf5, 1, 11, new byte[0], PUSH_PSW));
            machine.AddInstruction(new Instruction("ORI", 0xf6, 2, 7, new byte[0], ORI));
            machine.AddInstruction(new Instruction("RST 6", 0xf7, 1, 11, new byte[0], RST_6));
            machine.AddInstruction(new Instruction("RM", 0xf8, 1, 11, new byte[5], RM));
            machine.AddInstruction(new Instruction("SPHL", 0xf9, 1, 5, new byte[0], SPHL));
            machine.AddInstruction(new Instruction("JM", 0xfa, 3, 10, new byte[0], JM));
            machine.AddInstruction(new Instruction("EI", 0xfb, 1, 4, new byte[0], EI));
            machine.AddInstruction(new Instruction("CM", 0xfc, 3, 17, new byte[11], CM));
            machine.AddInstruction(new Instruction("*CALL", 0xfd, 3, 17, new byte[0], CALL));
            machine.AddInstruction(new Instruction("CPI", 0xfe, 2, 7, new byte[0], CPI));
            machine.AddInstruction(new Instruction("RST 7", 0xff, 1, 11, new byte[0], RST_7));
        }

        private enum RST_TARGETS : ushort
        {
            RST_0 = 0x000,
            RST_1 = 0x008,
            RST_2 = 0x010,
            RST_3 = 0x018,
            RST_4 = 0x020,
            RST_5 = 0x028,
            RST_6 = 0x030,
            RST_7 = 0x038,
        }

        private void RST(RST_TARGETS target)
        {
            ushort address = (ushort)target;
            ushort returnAddress = machine.PC;

            machine.Push((byte)(returnAddress >> 8), (byte)(returnAddress & 0xff));

            machine.PC = address;
        }

        // Registers
        const int A = 0;
        const int B = 1;
        const int C = 2;
        const int D = 3;
        const int E = 4;
        const int F = 5;
        const int H = 6;
        const int L = 7;

        // Ports
        byte PORT_IN_1 = 0;
        byte PORT_IN_2 = 1;

        byte PORT_OUT_3 = 2;
        byte PORT_OUT_5 = 3;

        byte SHIFT_LSB = 4;
        byte SHIFT_MSB = 5;
        byte SHIFT_OFFSET = 6;

        // 0x00
        private void NOP(byte b2, byte b3)
        {
        }

        // 0x01
        private void LXI_B(byte b2, byte b3)
        {
            machine.Registers[C] = b2;
            machine.Registers[B] = b3;
        }

        // 0x02
        private void STAX_B(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[B] << 8) + machine.Registers[C]);
            machine.WriteMem(address, machine.Registers[A]);
        }

        // 0x03
        private void INX_B(byte b2, byte b3)
        {
            ushort value = (ushort)((machine.Registers[B] << 8) + machine.Registers[C]);
            value++;
            machine.Registers[C] = (byte)(value & 0xff);
            machine.Registers[B] = (byte)(value >> 8);
        }

        // 0x04
        private void INR_B(byte b2, byte b3)
        {
            machine.Registers[B] += 1;
            machine.FlagsZSP(machine.Registers[B], i8080.AccessoryFlagRule.Inc);
        }

        // 0x05
        private void DCR_B(byte b2, byte b3)
        {
            machine.Registers[B] -= 1;
            machine.FlagsZSP(machine.Registers[B], i8080.AccessoryFlagRule.Dec);
        }

        // 0x06
        private void MVI_B(byte b2, byte b3)
        {
            machine.Registers[B] = b2;
        }

        // 0x07
        private void RLC(byte b2, byte b3)
        {
            byte x = (byte)(machine.Registers[A] >> 7);
            if (x != 0)
            {
                machine.SetFlag(i8080.Flags.C);
            }
            else
            {
                machine.ClearFlag(i8080.Flags.C);
            }

            machine.Registers[A] = (byte)((machine.Registers[A] << 1 & 0xFF) | x);
        }

        // 0x08 -> NOP

        // 0x09
        private void DAD_B(byte b2, byte b3)
        {
            ushort hl = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            ushort bc = (ushort)((machine.Registers[B] << 8) + machine.Registers[C]);

            if ((hl + bc) > 0xffff) machine.SetFlag(i8080.Flags.C); else machine.ClearFlag(i8080.Flags.C);

            ushort res = (ushort)(hl + bc);

            machine.Registers[H] = (byte)((res & 0xff00) >> 8);
            machine.Registers[L] = (byte)(res & 0xff);
        }

        // 0x0a
        private void LDAX_B(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[B] << 8) + machine.Registers[C]);
            machine.Registers[A] = machine.RAM[address];
        }

        // 0x0b
        private void DCX_B(byte b2, byte b3)
        {
            ushort value = (ushort)((machine.Registers[B] << 8) + machine.Registers[C]);
            value--;
            machine.Registers[C] = (byte)(value & 0xff);
            machine.Registers[B] = (byte)(value >> 8);
        }

        // 0x0c
        private void INR_C(byte b2, byte b3)
        {
            machine.Registers[C] += 1;
            machine.FlagsZSP(machine.Registers[C], i8080.AccessoryFlagRule.Inc);
        }

        //  
        public void DCR_C(byte b2, byte b3)
        {
            machine.Registers[C] -= 1;
            machine.FlagsZSP(machine.Registers[C], i8080.AccessoryFlagRule.Dec);
        }

        // 0x0e
        private void MVI_C(byte b2, byte b3)
        {
            machine.Registers[C] = b2;
        }

        // 0x0f
        public void RRC(byte b2, byte b3)
        {
            byte x = machine.Registers[A];
            if (1 == (x & 1))
            {
                machine.SetFlag(i8080.Flags.C);
                machine.Registers[A] = (byte)(machine.Registers[A] >> 1 | 1 << 7);
            }
            else
            {
                machine.Registers[A] = (byte)(machine.Registers[A] >> 1);
                machine.ClearFlag(i8080.Flags.C);
            }
        }

        // 0x10 -> NOP

        // 0x11
        private void LXI_D(byte b2, byte b3)
        {
            machine.Registers[E] = b2;
            machine.Registers[D] = b3;
        }

        // 0x12
        private void STAX_D(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[D] << 8) + machine.Registers[E]);
            machine.WriteMem(address, machine.Registers[A]);
        }

        // 0x13
        private void INX_D(byte b2, byte b3)
        {
            ushort value = (ushort)((machine.Registers[D] << 8) + machine.Registers[E]);
            value++;
            machine.Registers[E] = (byte)(value & 0xff);
            machine.Registers[D] = (byte)(value >> 8);
        }

        //0x14
        private void INR_D(byte b2, byte b3)
        {
            machine.Registers[D] += 1;
            machine.FlagsZSP(machine.Registers[D], i8080.AccessoryFlagRule.Inc);
        }

        // //0x15
        private void DCR_D(byte b2, byte b3)
        {
            machine.Registers[D] -= 1;
            machine.FlagsZSP(machine.Registers[D], i8080.AccessoryFlagRule.Dec);
        }

        // 0x16
        private void MVI_D(byte b2, byte b3)
        {
            machine.Registers[D] = b2;
        }

        // 0x17
        internal void RAL(byte b2, byte b3)
        {
            byte x = machine.Registers[A];
            machine.Registers[A] = (byte)((machine.Registers[F] & (byte)i8080.Flags.C) | (x << 1));

            if (0x80 == (x & 0x80)) machine.SetFlag(i8080.Flags.C); else machine.ClearFlag(i8080.Flags.C);
        }

        // 0x18 -> NOP

        // 0x19
        private void DAD_D(byte b2, byte b3)
        {
            ushort hl = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            ushort de = (ushort)((machine.Registers[D] << 8) + machine.Registers[E]);

            if ((hl + de) > 0xffff) machine.SetFlag(i8080.Flags.C); else machine.ClearFlag(i8080.Flags.C);

            ushort res = (ushort)(hl + de);

            machine.Registers[H] = (byte)((res & 0xff00) >> 8);
            machine.Registers[L] = (byte)(res & 0xff);
        }

        // 0x1a
        private void LDAX_D(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[D] << 8) + machine.Registers[E]);
            machine.Registers[A] = machine.RAM[address];
        }

        // 0x1b
        private void DCX_D(byte b2, byte b3)
        {
            ushort value = (ushort)((machine.Registers[D] << 8) + machine.Registers[E]);
            value--;
            machine.Registers[E] = (byte)(value & 0xff);
            machine.Registers[D] = (byte)(value >> 8);
        }

        // 0x1c
        private void INR_E(byte b2, byte b3)
        {
            machine.Registers[E] += 1;
            machine.FlagsZSP(machine.Registers[E], i8080.AccessoryFlagRule.Inc);
        }

        // 0x1d
        private void DCR_E(byte b2, byte b3)
        {
            machine.Registers[E] -= 1;
            machine.FlagsZSP(machine.Registers[E], i8080.AccessoryFlagRule.Dec);
        }

        // 0x1e
        private void MVI_E(byte b2, byte b3)
        {
            machine.Registers[E] = b2;
        }

        // 0x1f
        internal void RAR(byte b2, byte b3)
        {
            bool cy = (machine.Registers[F] & (byte)i8080.Flags.C) != 0;
            if ((machine.Registers[A] & 1) != 0)
            {
                machine.SetFlag(i8080.Flags.C);
            }
            else
            {
                machine.ClearFlag(i8080.Flags.C);
            }

            if (cy)
            {
                machine.Registers[A] = (byte)((machine.Registers[A] >> 1) | (1 << 7));
            }
            else
            {
                machine.Registers[A] = (byte)(machine.Registers[A] >> 1);
            }
        }

        // 0x20 -> NOP

        // 0x21
        private void LXI_H(byte b2, byte b3)
        {
            machine.Registers[L] = b2;
            machine.Registers[H] = b3;
        }

        // 0x22
        private void SHLD(byte b2, byte b3)
        {
            ushort address = (ushort)((b3 << 8) + b2);
            machine.WriteMem(address, machine.Registers[L]);
            address = (ushort)(address + 1);
            machine.WriteMem(address, machine.Registers[H]);
        }

        // 0x23
        private void INX_H(byte b2, byte b3)
        {
            ushort value = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            value++;
            machine.Registers[L] = (byte)(value & 0x00ff);
            machine.Registers[H] = (byte)(value >> 8);
        }

        // 0x24
        private void INR_H(byte b2, byte b3)
        {
            machine.Registers[H] += 1;
            machine.FlagsZSP(machine.Registers[H], i8080.AccessoryFlagRule.Inc);
        }

        // 0x25
        private void DCR_H(byte b2, byte b3)
        {
            machine.Registers[H] -= 1;
            machine.FlagsZSP(machine.Registers[H], i8080.AccessoryFlagRule.Dec);
        }

        // 0x26
        private void MVI_H(byte b2, byte b3)
        {
            machine.Registers[H] = b2;
        }

        // 0x27
        internal void DAA(byte b2, byte b3)
        {
            bool cy = ((byte)i8080.Flags.C & machine.Registers[F]) != 0;
            bool hf = ((byte)i8080.Flags.A & machine.Registers[F]) != 0;

            byte correction = 0;

            byte lsb = (byte)(machine.Registers[A] & 0x0F);
            byte msb = (byte)(machine.Registers[A] >> 4);

            if (hf || (machine.Registers[A] & 0xf) > 9)
            {
                correction += 0x06;
            }
            if (cy || msb > 9 || (msb >= 9 && lsb > 9))
            {
                correction += 0x60;
                cy = true;
            }

            machine.Registers[A] = machine.Add(machine.Registers[A], correction, false);

            if (cy)
            {
                machine.SetFlag(i8080.Flags.C);
            }
            else
            {
                machine.ClearFlag(i8080.Flags.C);
            }
        }

        // 0x28 -> NOP

        // 0x29
        private void DAD_H(byte b2, byte b3)
        {
            ushort hl = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);

            if ((hl + hl) > 0xffff) machine.SetFlag(i8080.Flags.C); else machine.ClearFlag(i8080.Flags.C);

            ushort res = (ushort)(hl + hl);

            machine.Registers[H] = (byte)((res & 0xff00) >> 8);
            machine.Registers[L] = (byte)(res & 0xff);
        }

        // 0x2a
        internal void LHLD(byte b2, byte b3)
        {
            ushort address = (ushort)((b3 << 8) + b2);
            machine.Registers[L] = machine.RAM[address];
            machine.Registers[H] = machine.RAM[address + 1];
        }

        // 0x2b
        private void DCX_H(byte b2, byte b3)
        {
            ushort value = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            value--;
            machine.Registers[L] = (byte)(value & 0xff);
            machine.Registers[H] = (byte)(value >> 8);
        }

        // 0x2c
        private void INR_L(byte b2, byte b3)
        {
            machine.Registers[L] += 1;
            machine.FlagsZSP(machine.Registers[L], i8080.AccessoryFlagRule.Inc);
        }

        // 0x2d
        private void DCR_L(byte b2, byte b3)
        {
            machine.Registers[L] -= 1;
            machine.FlagsZSP(machine.Registers[L], i8080.AccessoryFlagRule.Dec);
        }

        // 0x2e
        private void MVI_L(byte b2, byte b3)
        {
            machine.Registers[L] = b2;
        }

        // 0x2f
        private void CMA(byte b2, byte b3)
        {
            machine.Registers[A] = (byte)~machine.Registers[A];
        }

        // 0x30 -> NOP

        // 0x31
        private void LXI_SP(byte b2, byte b3)
        {
            machine.SP = (ushort)((b3 << 8) + b2);
        }

        // 0x32
        private void STA(byte b2, byte b3)
        {
            ushort address = (ushort)((b3 << 8) + b2);
            machine.WriteMem(address, machine.Registers[A]);
        }

        // 0x33
        private void INX_SP(byte b2, byte b3)
        {
            machine.SP++;
        }

        // 0x34
        private void INR_M(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.WriteMem(address, (byte)(machine.RAM[address] + 1));
            machine.FlagsZSP(machine.RAM[address], i8080.AccessoryFlagRule.Inc);
        }

        // 0x35
        private void DCR_M(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.WriteMem(address, (byte)(machine.RAM[address] - 1));
            machine.FlagsZSP(machine.RAM[address], i8080.AccessoryFlagRule.Dec);
        }

        // 0x36
        private void MVI_M(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.WriteMem(address, b2);
        }

        // 0x37
        private void STC(byte b2, byte b3)
        {
            machine.SetFlag(i8080.Flags.C);
        }

        // 0x38 -> NOP

        // 0x39
        private void DAD_SP(byte b2, byte b3)
        {
            ushort hl = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);

            if ((hl + machine.SP) > 0xffff) machine.SetFlag(i8080.Flags.C); else machine.ClearFlag(i8080.Flags.C);

            ushort res = (ushort)(hl + machine.SP);

            machine.Registers[H] = (byte)((res & 0xff00) >> 8);
            machine.Registers[L] = (byte)(res & 0xff);

        }

        // 0x3a
        private void LDA(byte b2, byte b3)
        {
            ushort address = (ushort)((b3 << 8) + b2);
            machine.Registers[A] = machine.RAM[address];
        }

        // 0x3b
        private void DCX_SP(byte b2, byte b3)
        {
            machine.SP--;
        }

        // 0x3c
        private void INR_A(byte b2, byte b3)
        {
            machine.Registers[A] += 1;
            machine.FlagsZSP(machine.Registers[A], i8080.AccessoryFlagRule.Inc);
        }

        // 0x3d
        private void DCR_A(byte b2, byte b3)
        {
            machine.Registers[A] -= 1;
            machine.FlagsZSP(machine.Registers[A], i8080.AccessoryFlagRule.Dec);
        }

        // 0x3e
        private void MVI_A(byte b2, byte b3)
        {
            machine.Registers[A] = b2;
        }

        // 0x3f
        private void CMC(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.C) != 0)
            {
                machine.ClearFlag(i8080.Flags.C);
            }
            else
            {
                machine.SetFlag(i8080.Flags.C);
            }
        }

        // 0x40
        private void MOV_B_B(byte b2, byte b3)
        {
            //machine.Registers[B] = machine.Registers[B];
        }

        // 0x41
        private void MOV_B_C(byte b2, byte b3)
        {
            machine.Registers[B] = machine.Registers[C];
        }

        // 0x42
        private void MOV_B_D(byte b2, byte b3)
        {
            machine.Registers[B] = machine.Registers[D];
        }

        // 0x43
        private void MOV_B_E(byte b2, byte b3)
        {
            machine.Registers[B] = machine.Registers[E];
        }

        // 0x44
        private void MOV_B_H(byte b2, byte b3)
        {
            machine.Registers[B] = machine.Registers[H];
        }

        // 0x45
        private void MOV_B_L(byte b2, byte b3)
        {
            machine.Registers[B] = machine.Registers[L];
        }

        // 0x46
        private void MOV_B_M(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.Registers[B] = machine.RAM[address];
        }

        // 0x47
        private void MOV_B_A(byte b2, byte b3)
        {
            machine.Registers[B] = machine.Registers[A];
        }

        // 0x48
        private void MOV_C_B(byte b2, byte b3)
        {
            machine.Registers[C] = machine.Registers[B];
        }

        // 0x49
        private void MOV_C_C(byte b2, byte b3)
        {
            //machine.Registers[C] = machine.Registers[C];
        }

        // 0x4a
        private void MOV_C_D(byte b2, byte b3)
        {
            machine.Registers[C] = machine.Registers[D];
        }

        // 0x4b
        private void MOV_C_E(byte b2, byte b3)
        {
            machine.Registers[C] = machine.Registers[E];
        }

        // 0x4c
        private void MOV_C_H(byte b2, byte b3)
        {
            machine.Registers[C] = machine.Registers[H];
        }

        // 0x4d
        private void MOV_C_L(byte b2, byte b3)
        {
            machine.Registers[C] = machine.Registers[L];
        }

        // 0x4e
        private void MOV_C_M(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.Registers[C] = machine.RAM[address];
        }

        // 0x4f
        private void MOV_C_A(byte b2, byte b3)
        {
            machine.Registers[C] = machine.Registers[A];
        }

        // 0x50
        private void MOV_D_B(byte b2, byte b3)
        {
            machine.Registers[D] = machine.Registers[B];
        }

        // 0x51
        private void MOV_D_C(byte b2, byte b3)
        {
            machine.Registers[D] = machine.Registers[C];
        }

        // 0x52
        private void MOV_D_D(byte b2, byte b3)
        {
            //machine.Registers[D] = machine.Registers[D];
        }

        // 0x53
        private void MOV_D_E(byte b2, byte b3)
        {
            machine.Registers[D] = machine.Registers[E];
        }

        // 0x54
        private void MOV_D_H(byte b2, byte b3)
        {
            machine.Registers[D] = machine.Registers[H];
        }

        // 0x55
        private void MOV_D_L(byte b2, byte b3)
        {
            machine.Registers[D] = machine.Registers[L];
        }

        // 0x56
        private void MOV_D_M(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.Registers[D] = machine.RAM[address];
        }

        //.0x57
        private void MOV_D_A(byte b2, byte b3)
        {
            machine.Registers[D] = machine.Registers[A];
        }

        // 0x58
        private void MOV_E_B(byte b2, byte b3)
        {
            machine.Registers[E] = machine.Registers[B];
        }

        // 0x59
        private void MOV_E_C(byte b2, byte b3)
        {
            machine.Registers[E] = machine.Registers[C];
        }

        // 0x5a
        private void MOV_E_D(byte b2, byte b3)
        {
            machine.Registers[E] = machine.Registers[D];
        }

        // 0x5b
        private void MOV_E_E(byte b2, byte b3)
        {
            //machine.Registers[E] = machine.Registers[E];
        }

        // 0x5c
        private void MOV_E_H(byte b2, byte b3)
        {
            machine.Registers[E] = machine.Registers[H];
        }

        // 0x5d
        private void MOV_E_L(byte b2, byte b3)
        {
            machine.Registers[E] = machine.Registers[L];
        }

        // 0x5e
        private void MOV_E_M(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.Registers[E] = machine.RAM[address];
        }

        // 0x5f
        private void MOV_E_A(byte b2, byte b3)
        {
            machine.Registers[E] = machine.Registers[A];
        }

        // 0x60
        private void MOV_H_B(byte b2, byte b3)
        {
            machine.Registers[H] = machine.Registers[B];
        }

        // 0x61
        private void MOV_H_C(byte b2, byte b3)
        {
            machine.Registers[H] = machine.Registers[C];
        }

        // 0x62
        private void MOV_H_D(byte b2, byte b3)
        {
            machine.Registers[H] = machine.Registers[D];
        }

        // 0x63
        private void MOV_H_E(byte b2, byte b3)
        {
            machine.Registers[H] = machine.Registers[E];
        }

        // 0x64
        private void MOV_H_H(byte b2, byte b3)
        {
            //machine.Registers[H] = machine.Registers[H];
        }

        // 0x65
        private void MOV_H_L(byte b2, byte b3)
        {
            machine.Registers[H] = machine.Registers[L];
        }

        // 0x66
        private void MOV_H_M(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.Registers[H] = machine.RAM[address];
        }

        // 0x67
        private void MOV_H_A(byte b2, byte b3)
        {
            machine.Registers[H] = machine.Registers[A];
        }

        // 0x68
        private void MOV_L_B(byte b2, byte b3)
        {
            machine.Registers[L] = machine.Registers[B];
        }

        // 0x69
        private void MOV_L_C(byte b2, byte b3)
        {
            machine.Registers[L] = machine.Registers[C];
        }

        // 0x6a
        private void MOV_L_D(byte b2, byte b3)
        {
            machine.Registers[L] = machine.Registers[D];
        }

        // 0x6b
        private void MOV_L_E(byte b2, byte b3)
        {
            machine.Registers[L] = machine.Registers[E];
        }

        // 0x6c
        private void MOV_L_H(byte b2, byte b3)
        {
            machine.Registers[L] = machine.Registers[H];
        }

        // 0x6d
        private void MOV_L_L(byte b2, byte b3)
        {
            //machine.Registers[L] = machine.Registers[L];
        }

        // 0x6e
        private void MOV_L_M(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.Registers[L] = machine.RAM[address];
        }

        // 0x6f
        private void MOV_L_A(byte b2, byte b3)
        {
            machine.Registers[L] = machine.Registers[A];
        }

        // 0x70
        private void MOV_M_B(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.WriteMem(address, machine.Registers[B]);
        }

        // 0x71
        private void MOV_M_C(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.WriteMem(address, machine.Registers[C]);
        }

        // 0x72
        private void MOV_M_D(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.WriteMem(address, machine.Registers[D]);
        }

        // 0x73
        private void MOV_M_E(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.WriteMem(address, machine.Registers[E]);
        }

        // 0x74
        private void MOV_M_H(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.WriteMem(address, machine.Registers[H]);
        }

        // 0x75
        private void MOV_M_L(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.WriteMem(address, machine.Registers[L]);
        }

        // 0x76
        private void HLT(byte b2, byte b3)
        {
            //machine.On = false;
        }

        // 0x77
        private void MOV_M_A(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.WriteMem(address, machine.Registers[A]);
        }

        // 0x78
        private void MOV_A_B(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Registers[B];
        }

        // 0x79
        private void MOV_A_C(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Registers[C];
        }

        // 0x7a
        private void MOV_A_D(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Registers[D];
        }

        // 0x7b
        private void MOV_A_E(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Registers[E];
        }

        // 0x7c
        private void MOV_A_H(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Registers[H];
        }

        // 0x7d
        private void MOV_A_L(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Registers[L];
        }

        // 0x7e
        private void MOV_A_M(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.Registers[A] = machine.RAM[address];
        }

        // 0x7f
        private void MOV_A_A(byte b2, byte b3)
        {
            //machine.Registers[A] = machine.Registers[A];
        }

        // 0x80
        private void ADD_B(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Add(machine.Registers[A], machine.Registers[B], false);
        }

        // 0x81
        private void ADD_C(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Add(machine.Registers[A], machine.Registers[C], false);
        }

        // 0x82
        private void ADD_D(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Add(machine.Registers[A], machine.Registers[D], false);
        }

        // 0x83
        private void ADD_E(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Add(machine.Registers[A], machine.Registers[E], false);
        }

        // 0x84
        private void ADD_H(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Add(machine.Registers[A], machine.Registers[H], false);
        }

        // 0x85
        private void ADD_L(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Add(machine.Registers[A], machine.Registers[L], false);
        }

        // 0x86
        private void ADD_M(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.Registers[A] = machine.Add(machine.Registers[A], machine.RAM[address], false);
        }

        // 0x87
        private void ADD_A(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Add(machine.Registers[A], machine.Registers[A], false);
        }

        // 0x88
        public void ADC_B(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Add(machine.Registers[A], machine.Registers[B], (byte)(machine.Registers[F] & (byte)i8080.Flags.C) != 0);
        }

        // 0x89
        public void ADC_C(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Add(machine.Registers[A], machine.Registers[C], (byte)(machine.Registers[F] & (byte)i8080.Flags.C) != 0);
        }

        // 0x8a
        public void ADC_D(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Add(machine.Registers[A], machine.Registers[D], (byte)(machine.Registers[F] & (byte)i8080.Flags.C) != 0);
        }

        // 0x8b
        public void ADC_E(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Add(machine.Registers[A], machine.Registers[E], (byte)(machine.Registers[F] & (byte)i8080.Flags.C) != 0);
        }

        // 0x8c
        public void ADC_H(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Add(machine.Registers[A], machine.Registers[H], (byte)(machine.Registers[F] & (byte)i8080.Flags.C) != 0);
        }

        // 0x8d
        public void ADC_L(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Add(machine.Registers[A], machine.Registers[L], (byte)(machine.Registers[F] & (byte)i8080.Flags.C) != 0);
        }

        // 0x8e
        public void ADC_M(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.Registers[A] = machine.Add(machine.Registers[A], machine.RAM[address], (byte)(machine.Registers[F] & (byte)i8080.Flags.C) != 0);
        }

        // 0x8f
        public void ADC_A(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Add(machine.Registers[A], machine.Registers[A], (byte)(machine.Registers[F] & (byte)i8080.Flags.C) != 0);
        }

        // 0x90
        private void SUB_B(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Sub(machine.Registers[A], machine.Registers[B], false);
        }

        // 0x91
        private void SUB_C(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Sub(machine.Registers[A], machine.Registers[C], false);
        }

        //0x92
        private void SUB_D(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Sub(machine.Registers[A], machine.Registers[D], false);
        }

        // 0x93
        private void SUB_E(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Sub(machine.Registers[A], machine.Registers[E], false);
        }

        // 0x94
        private void SUB_H(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Sub(machine.Registers[A], machine.Registers[H], false);
        }

        // 0x95
        private void SUB_L(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Sub(machine.Registers[A], machine.Registers[L], false);
        }

        // 0x96
        private void SUB_M(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.Registers[A] = machine.Sub(machine.Registers[A], machine.RAM[address], false);
        }

        // 0x97
        private void SUB_A(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Sub(machine.Registers[A], machine.Registers[A], false);
        }

        // 0x98
        private void SBB_B(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Sub(machine.Registers[A], machine.Registers[B], (byte)(machine.Registers[F] & (byte)i8080.Flags.C) != 0);
        }

        // 0x99
        private void SBB_C(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Sub(machine.Registers[A], machine.Registers[C], (byte)(machine.Registers[F] & (byte)i8080.Flags.C) != 0);
        }

        // 0x9a
        private void SBB_D(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Sub(machine.Registers[A], machine.Registers[D], (byte)(machine.Registers[F] & (byte)i8080.Flags.C) != 0);
        }

        // 0x9b
        private void SBB_E(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Sub(machine.Registers[A], machine.Registers[E], (byte)(machine.Registers[F] & (byte)i8080.Flags.C) != 0);
        }

        // 0x9c
        private void SBB_H(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Sub(machine.Registers[A], machine.Registers[H], (byte)(machine.Registers[F] & (byte)i8080.Flags.C) != 0);
        }

        // 0x9d
        private void SBB_L(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Sub(machine.Registers[A], machine.Registers[L], (byte)(machine.Registers[F] & (byte)i8080.Flags.C) != 0);
        }

        // 0x9e
        private void SBB_M(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.Registers[A] = machine.Sub(machine.Registers[A], machine.RAM[address], (byte)(machine.Registers[F] & (byte)i8080.Flags.C) != 0);
        }

        // 0x9f
        private void SBB_A(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Sub(machine.Registers[A], machine.Registers[A], (byte)(machine.Registers[F] & (byte)i8080.Flags.C) != 0);
        }

        // 0xa0
        private void ANA_B(byte b2, byte b3)
        {
            machine.Registers[A] = machine.And(machine.Registers[B]);
        }

        // 0xa1
        private void ANA_C(byte b2, byte b3)
        {
            machine.Registers[A] = machine.And(machine.Registers[C]);
        }

        // 0xa2
        private void ANA_D(byte b2, byte b3)
        {
            machine.Registers[A] = machine.And(machine.Registers[D]);
        }

        // 0xa3
        private void ANA_E(byte b2, byte b3)
        {
            machine.Registers[A] = machine.And(machine.Registers[E]);
        }

        // 0xa4
        private void ANA_H(byte b2, byte b3)
        {
            machine.Registers[A] = machine.And(machine.Registers[H]);
        }

        // 0xa5
        private void ANA_L(byte b2, byte b3)
        {
            machine.Registers[A] = machine.And(machine.Registers[L]);
        }

        // 0xa6
        private void ANA_M(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.Registers[A] = machine.And(machine.RAM[address]);
        }

        // 0xa7
        private void ANA_A(byte b2, byte b3)
        {
            machine.Registers[A] = machine.And(machine.Registers[A]);
        }

        // 0xa8
        private void XRA_B(byte b2, byte b3)
        {
            machine.Registers[A] = (byte)(machine.Registers[A] ^ machine.Registers[B]);
            machine.LogicFlags();
        }

        // 0xa9
        private void XRA_C(byte b2, byte b3)
        {
            machine.Registers[A] = (byte)(machine.Registers[A] ^ machine.Registers[C]);
            machine.LogicFlags();
        }

        // 0xaa
        private void XRA_D(byte b2, byte b3)
        {
            machine.Registers[A] = (byte)(machine.Registers[A] ^ machine.Registers[D]);
            machine.LogicFlags();
        }

        // 0xab
        private void XRA_E(byte b2, byte b3)
        {
            machine.Registers[A] = (byte)(machine.Registers[A] ^ machine.Registers[E]);
            machine.LogicFlags();
        }

        // 0xac
        private void XRA_H(byte b2, byte b3)
        {
            machine.Registers[A] = (byte)(machine.Registers[A] ^ machine.Registers[H]);
            machine.LogicFlags();
        }

        // 0xad
        private void XRA_L(byte b2, byte b3)
        {
            machine.Registers[A] = (byte)(machine.Registers[A] ^ machine.Registers[L]);
            machine.LogicFlags();
        }

        // 0xae
        private void XRA_M(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.Registers[A] = (byte)(machine.Registers[A] ^ machine.RAM[address]);
            machine.LogicFlags();
        }

        // 0xaf
        private void XRA_A(byte b2, byte b3)
        {
            machine.Registers[A] = (byte)(machine.Registers[A] ^ machine.Registers[A]);
            machine.LogicFlags();
        }


        // 0xb0
        private void ORA_B(byte b2, byte b3)
        {
            machine.Registers[A] = (byte)(machine.Registers[A] | machine.Registers[B]);
            machine.LogicFlags();
        }

        // 0xb1
        private void ORA_C(byte b2, byte b3)
        {
            machine.Registers[A] = (byte)(machine.Registers[A] | machine.Registers[C]);
            machine.LogicFlags();
        }

        // 0xb2
        private void ORA_D(byte b2, byte b3)
        {
            machine.Registers[A] = (byte)(machine.Registers[A] | machine.Registers[D]);
            machine.LogicFlags();
        }

        // 0xb3
        private void ORA_E(byte b2, byte b3)
        {
            machine.Registers[A] = (byte)(machine.Registers[A] | machine.Registers[E]);
            machine.LogicFlags();
        }

        // 0xb4
        private void ORA_H(byte b2, byte b3)
        {
            machine.Registers[A] = (byte)(machine.Registers[A] | machine.Registers[H]);
            machine.LogicFlags();
        }

        // 0xb5
        private void ORA_L(byte b2, byte b3)
        {
            machine.Registers[A] = (byte)(machine.Registers[A] | machine.Registers[L]);
            machine.LogicFlags();
        }

        // 0xb6
        private void ORA_M(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.Registers[A] = (byte)(machine.Registers[A] | machine.RAM[address]);
            machine.LogicFlags();
        }

        // 0xb7
        private void ORA_A(byte b2, byte b3)
        {
            machine.Registers[A] = (byte)(machine.Registers[A] | machine.Registers[A]);
            machine.LogicFlags();
        }

        // 0xb8
        private void CMP_B(byte b2, byte b3)
        {
            machine.Compare(machine.Registers[B]);
        }

        // 0xb9
        private void CMP_C(byte b2, byte b3)
        {
            machine.Compare(machine.Registers[C]);
        }

        // 0xba
        private void CMP_D(byte b2, byte b3)
        {
            machine.Compare(machine.Registers[D]);
        }

        // 0xbb
        private void CMP_E(byte b2, byte b3)
        {
            machine.Compare(machine.Registers[E]);
        }

        // 0xbc
        private void CMP_H(byte b2, byte b3)
        {
            machine.Compare(machine.Registers[H]);
        }

        // 0xbd
        private void CMP_L(byte b2, byte b3)
        {
            machine.Compare(machine.Registers[L]);
        }

        // 0xbe
        private void CMP_M(byte b2, byte b3)
        {
            ushort address = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            machine.Compare(machine.RAM[address]);
        }

        // 0xbf
        private void CMP_A(byte b2, byte b3)
        {
            machine.Compare(machine.Registers[A]);
        }

        // 0xc0
        private void RNZ(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.Z) == 0)
            {
                machine.PC = machine.Pop();
                }
            }

        // 0xc1
        private void POP_B(byte b2, byte b3)
        {
            ushort value = machine.Pop();
            machine.Registers[C] = (byte)(value & 0x00ff);
            machine.Registers[B] = (byte)(value >> 8);
        }

        // 0xc2
        private void JNZ(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.Z) == 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                machine.PC = address;
                }
            }

        // 0xc3
        private void JMP(byte b2, byte b3)
        {
            ushort address = (ushort)((b3 << 8) + b2);
            machine.PC = address;
        }

        // 0xc4
        private void CNZ(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.Z) == 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                ushort ret = machine.PC;
                machine.Push((byte)(ret >> 8), (byte)(ret & 0xff));
                machine.PC = address;
                }
            }

        // 0xc5
        private void PUSH_B(byte b2, byte b3)
        {
            machine.Push(machine.Registers[B], machine.Registers[C]);
        }

        // 0xc6
        private void ADI(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Add(machine.Registers[A], b2, false);
        }

        // 0xc7
        private void RST_0(byte b2, byte b3)
        {
            RST(RST_TARGETS.RST_0);
        }

        // 0xc8
        private void RZ(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.Z) != 0)
            {
                machine.PC = machine.Pop();
                }
            }

        // 0xc9
        private void RET(byte b2, byte b3)
        {
            machine.PC = machine.Pop();
            }

        // 0xca
        private void JZ(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.Z) != 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                machine.PC = address;
                }
            }

        // 0xcb -> JML

        // 0xcc
        private void CZ(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.Z) != 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                ushort ret = machine.PC;
                machine.Push((byte)(ret >> 8), (byte)(ret & 0xff));
                machine.PC = address;
                }
            }

        // 0xcd
        private void CALL(byte b2, byte b3)
        {
            ushort address = (ushort)((b3 << 8) + b2);
            ushort ret = machine.PC;
            machine.Push((byte)(ret >> 8), (byte)(ret & 0xff));
            machine.PC = address;
                }

        // 0xce
        private void ACI(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Add(machine.Registers[A], b2, (machine.Registers[F] & (ushort)i8080.Flags.C) != 0);
        }

        // 0xcf
        private void RST_1(byte b2, byte b3)
        {
            RST(RST_TARGETS.RST_1);
        }

        // 0xd0
        private void RNC(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.C) == 0)
            {
                machine.PC = machine.Pop();
                }
            }

        // 0xd1
        private void POP_D(byte b2, byte b3)
        {
            ushort value = machine.Pop();
            machine.Registers[E] = (byte)(value & 0x00ff);
            machine.Registers[D] = (byte)(value >> 8);
        }

        // 0xd2
        private void JNC(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.C) == 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                machine.PC = address;
            }
        }

        // 0xd3
        private void OUT(byte b2, byte b3)
        {
            if (machine.HasConsole)
            {
                machine.On = false;
            }
            else
            {
                switch (b2)
                {
                    case 2:
                        machine.Ports[SHIFT_OFFSET] = (byte)(machine.Registers[A] & 0x7);
                        break;
                    case 3:
                        machine.Ports[PORT_OUT_3] = machine.Registers[A];
                        Sound.PlaySounds(machine);
                        break;
                    case 4:
                        machine.Ports[SHIFT_LSB] = machine.Ports[SHIFT_MSB];
                        machine.Ports[SHIFT_MSB] = machine.Registers[A];
                        break;
                    case 5:
                        machine.Ports[PORT_OUT_5] = machine.Registers[A];
                        Sound.PlaySounds(machine);
                        break;
                    default:
                        break;
                }
            }
        }

        // 0xd4
        private void CNC(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.C) == 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                ushort ret = machine.PC;
                machine.Push((byte)(ret >> 8), (byte)(ret & 0xff));
                machine.PC = address;
                }
            }

        // 0xd5
        private void PUSH_D(byte b2, byte b3)
        {
            machine.Push(machine.Registers[D], machine.Registers[E]);
        }

        // 0xd6
        private void SUI(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Sub(machine.Registers[A], b2, false);
        }

        // 0xd7
        private void RST_2(byte b2, byte b3)
        {
            RST(RST_TARGETS.RST_2);
        }

        // 0xd8
        private void RC(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.C) != 0)
            {
                machine.PC = machine.Pop();
                }
            }

        // 0xd9 -> RET

        // 0xda
        private void JC(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.C) != 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                machine.PC = address;
                }
            }

        // 0xdb
        private void IN(byte b2, byte b3)
        {
            if (machine.HasConsole)
            {
                byte operation = machine.Registers[C];

                // print a character stored in E
                if (operation == 2)
                {
                    machine.nextLine += (char)machine.Registers[E];
                    if ((char)machine.Registers[E] == '\n')
                    {
                        machine.Console.Add(machine.nextLine.Replace("\n\r", "\r\n"));
                        machine.nextLine = string.Empty;
                    }
                }
                // print from memory at (DE) until '$' char
                else if (operation == 9)
                {
                    ushort address = (ushort)((machine.Registers[D] << 8) + machine.Registers[E]);
                    while (machine.RAM[address] != '$' && machine.RAM[address] != 0)
                    {
                        machine.nextLine += (char)machine.RAM[address];
                        address++;
                    }
                    if (machine.nextLine != string.Empty)
                    {
                        machine.Console.Add(machine.nextLine.Replace("\n\r", "\r\n"));
                    }
                    machine.nextLine = string.Empty;
                }

                machine.Registers[A] = 0xFF;
            }
            else
            {
                byte a = 0;
                switch (b2)
                {
                    case 0:
                        a = 1;
                        break;
                    case 1:
                        a = machine.Ports[PORT_IN_1];
                        break;
                    case 2:
                        a = (byte)((machine.Ports[PORT_IN_2] & 0x8f) | (machine.Ports[PORT_IN_1] & 0x70));
                        break;
                    case 3:
                        ushort v = (ushort)((machine.Ports[SHIFT_MSB] << 8) | machine.Ports[SHIFT_LSB]);
                        a = (byte)((v >> (8 - machine.Ports[SHIFT_OFFSET])) & 0xff);
                        break;
                }
                machine.Registers[A] = a;
            }
        }

        // 0xdc
        private void CC(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.C) != 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                ushort ret = machine.PC;
                machine.Push((byte)(ret >> 8), (byte)(ret & 0xff));
                machine.PC = address;
                }
            }

        // 0xdd -> CALL

        // 0xde
        private void SBI(byte b2, byte b3)
        {
            machine.Registers[A] = machine.Sub(machine.Registers[A], b2, (machine.Registers[F] & (ushort)i8080.Flags.C) != 0);
        }

        // 0xdf
        private void RST_3(byte b2, byte b3)
        {
            RST(RST_TARGETS.RST_3);
        }

        // 0xe0
        private void RPO(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.P) == 0)
            {
                machine.PC = machine.Pop();
                }
            }

        // 0xe1
        private void POP_H(byte b2, byte b3)
        {
            ushort value = machine.Pop();
            machine.Registers[L] = (byte)(value & 0x00ff);
            machine.Registers[H] = (byte)(value >> 8);
        }

        // 0xe2
        private void JPO(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.P) == 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                machine.PC = address;
                }
            }

        // 0xe3
        private void XTHL(byte b2, byte b3)
        {
            byte h = machine.Registers[H];
            byte l = machine.Registers[L];
            machine.Registers[L] = machine.RAM[machine.SP];
            machine.Registers[H] = machine.RAM[machine.SP + 1];
            machine.WriteMem(machine.SP, l);
            machine.WriteMem((ushort)(machine.SP + 1), h);
        }

        // 0xe4
        private void CPO(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.P) == 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                ushort ret = machine.PC;
                machine.Push((byte)(ret >> 8), (byte)(ret & 0xff));
                machine.PC = address;
            }
        }

        // 0xe5
        private void PUSH_H(byte b2, byte b3)
        {
            machine.Push(machine.Registers[H], machine.Registers[L]);
        }

        // 0xe6
        internal void ANI(byte b2, byte b3)
        {
            machine.Registers[A] = machine.And(b2);
        }

        // 0xe7
        private void RST_4(byte b2, byte b3)
        {
            RST(RST_TARGETS.RST_4);
        }

        // 0xe8
        private void RPE(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.P) != 0)
            {
                machine.PC = machine.Pop();
                }
            }

        // 0xe9
        private void PCHL(byte b2, byte b3)
        {
            machine.PC = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
            }

        // 0xea
        private void JPE(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.P) != 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                machine.PC = address; 
                }
            }

        // 0xeb
        internal void XCHG(byte b2, byte b3)
        {
            byte h = machine.Registers[D];
            byte l = machine.Registers[E];
            machine.Registers[D] = machine.Registers[H];
            machine.Registers[E] = machine.Registers[L];
            machine.Registers[H] = h;
            machine.Registers[L] = l;
        }

        // 0xec
        private void CPE(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.P) != 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                ushort ret = machine.PC;
                machine.Push((byte)(ret >> 8), (byte)(ret & 0xff));
                machine.PC = address;
                }
            }

        // 0xed -> CALL

        // 0xee
        private void XRI(byte b2, byte b3)
        {
            machine.Registers[A] = (byte)(machine.Registers[A] ^ b2);
            machine.LogicFlags();
        }

        // 0xef
        private void RST_5(byte b2, byte b3)
        {
            RST(RST_TARGETS.RST_5);
        }

        // 0xf0
        private void RP(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.S) == 0)
            {
                machine.PC = machine.Pop();
                }
            }

        // 0xf1
        private void POP_PSW(byte b2, byte b3)
        {
            ushort value = machine.Pop();
            machine.Registers[F] = (byte)(value & 0x00ff);

            machine.Registers[F] = (byte)(machine.Registers[F] | 2); // Bit 2 always 1
            machine.Registers[F] &= 0xD7;                 // Bits 4 and 6 always 0
            machine.Registers[A] = (byte)(value >> 8);
        }

        // 0xf2
        private void JP(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.S) == 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                machine.PC = address;
            }
        }

        // 0xf3
        private void DI(byte b2, byte b3)
        {
            machine.InterruptsEnabled = false;
        }

        // 0xf4
        private void CP(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.S) == 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                ushort ret = machine.PC;
                machine.Push((byte)(ret >> 8), (byte)(ret & 0xff));
                machine.PC = address;
                }
            }

        // 0xf5
        private void PUSH_PSW(byte b2, byte b3)
        {
            machine.Push(machine.Registers[A], machine.Registers[F]);
        }

        // 0xf6
        private void ORI(byte b2, byte b3)
        {
            machine.Registers[A] = (byte)(machine.Registers[A] | b2);
            machine.FlagsZSP(machine.Registers[A]);
            machine.ClearFlag(i8080.Flags.C);
            machine.ClearFlag(i8080.Flags.A);
        }

        // 0xf7
        private void RST_6(byte b2, byte b3)
        {
            RST(RST_TARGETS.RST_6);
        }

        // 0xf8
        private void RM(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.S) != 0)
            {
                machine.PC = machine.Pop();
                }
            }

        // 0xf9
        private void SPHL(byte b2, byte b3)
        {
            machine.SP = (ushort)((machine.Registers[H] << 8) + machine.Registers[L]);
        }

        // 0xfa
        private void JM(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.S) != 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                machine.PC = address;
                }
            }

        // 0xfb
        private void EI(byte b2, byte b3)
        {
            machine.InterruptsEnabled = true;
            //machine.interrupt_delay = 1;
        }

        // 0xfc
        private void CM(byte b2, byte b3)
        {
            if ((machine.Registers[F] & (byte)i8080.Flags.S) != 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                ushort ret = machine.PC;
                machine.Push((byte)(ret >> 8), (byte)(ret & 0xff));
                machine.PC = address;
            }
        }

        // 0xfd -> CALL

        // 0xfe
        private void CPI(byte b2, byte b3)
        {
            machine.Compare(b2);
        }

        // 0xff
        private void RST_7(byte b2, byte b3)
        {
            RST(RST_TARGETS.RST_7);
        }

    }
}

