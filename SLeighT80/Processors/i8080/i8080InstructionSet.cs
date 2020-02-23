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
    public static class i8080InstructionSet
    {
        public static void Install(i8080 machine)
        {
            machine.AddInstruction(new Instruction("NOP", 0x00, 1, 4, 0, NOP));
            machine.AddInstruction(new Instruction("LXI B", 0x01, 3, 10, 0, LXI_B));
            machine.AddInstruction(new Instruction("STAX B", 0x02, 1, 7, 0, STAX_B));
            machine.AddInstruction(new Instruction("INX B", 0x03, 1, 5, 0, INX_B));
            machine.AddInstruction(new Instruction("INR B", 0x04, 1, 5, 0, INR_B));
            machine.AddInstruction(new Instruction("DCR B", 0x05, 1, 5, 0, DCR_B));
            machine.AddInstruction(new Instruction("MVI B", 0x06, 2, 7, 0, MVI_B));
            machine.AddInstruction(new Instruction("RLC", 0x07, 1, 4, 0, RLC));
            machine.AddInstruction(new Instruction("*NOP", 0x08, 1, 4, 0, NOP));
            machine.AddInstruction(new Instruction("DAD B", 0x09, 1, 10, 0, DAD_B));
            machine.AddInstruction(new Instruction("LDAX B", 0x0a, 1, 7, 0, LDAX_B));
            machine.AddInstruction(new Instruction("DCX B", 0x0b, 1, 5, 0, DCX_B));
            machine.AddInstruction(new Instruction("INR C", 0x0c, 1, 5, 0, INR_C));
            machine.AddInstruction(new Instruction("DCR C", 0x0d, 1, 5, 0, DCR_C));
            machine.AddInstruction(new Instruction("MVI C", 0x0e, 2, 7, 0, MVI_C));
            machine.AddInstruction(new Instruction("RRC", 0x0f, 1, 4, 0, RRC));
            machine.AddInstruction(new Instruction("*NOP", 0x10, 1, 4, 0, NOP));
            machine.AddInstruction(new Instruction("LXI D", 0x11, 3, 10, 0, LXI_D));
            machine.AddInstruction(new Instruction("STAX D", 0x12, 1, 7, 0, STAX_D));
            machine.AddInstruction(new Instruction("INX D", 0x13, 1, 5, 0, INX_D));
            machine.AddInstruction(new Instruction("INR D", 0x14, 1, 5, 0, INR_D));
            machine.AddInstruction(new Instruction("DCR D", 0x15, 1, 5, 0, DCR_D));
            machine.AddInstruction(new Instruction("MVI D", 0x16, 2, 7, 0, MVI_D));
            machine.AddInstruction(new Instruction("RAL", 0x17, 1, 4, 0, RAL));
            machine.AddInstruction(new Instruction("*NOP", 0x18, 1, 4, 0, NOP));
            machine.AddInstruction(new Instruction("DAD D", 0x19, 1, 10, 0, DAD_D));
            machine.AddInstruction(new Instruction("LDAX D", 0x1a, 1, 7, 0, LDAX_D));
            machine.AddInstruction(new Instruction("DCX D", 0x1b, 1, 5, 0, DCX_D));
            machine.AddInstruction(new Instruction("INR E", 0x1c, 1, 5, 0, INR_E));
            machine.AddInstruction(new Instruction("DCR E", 0x1d, 1, 5, 0, DCR_E));
            machine.AddInstruction(new Instruction("MVI E", 0x1e, 2, 7, 0, MVI_E));
            machine.AddInstruction(new Instruction("RAR", 0x1f, 1, 4, 0, RAR));
            machine.AddInstruction(new Instruction("*NOP", 0x20, 1, 4, 0, NOP));
            machine.AddInstruction(new Instruction("LXI H", 0x21, 3, 10, 0, LXI_H));
            machine.AddInstruction(new Instruction("SHLD", 0x22, 3, 16, 0, SHLD));
            machine.AddInstruction(new Instruction("INX H", 0x23, 1, 5, 0, INX_H));
            machine.AddInstruction(new Instruction("INR H", 0x24, 1, 5, 0, INR_H));
            machine.AddInstruction(new Instruction("DCR H", 0x25, 1, 5, 0, DCR_H));
            machine.AddInstruction(new Instruction("MVI H", 0x26, 2, 7, 0, MVI_H));
            machine.AddInstruction(new Instruction("DAA", 0x27, 1, 4, 0, DAA));
            machine.AddInstruction(new Instruction("*NOP", 0x28, 1, 4, 0, NOP));
            machine.AddInstruction(new Instruction("DAD H", 0x29, 1, 10, 0, DAD_H));
            machine.AddInstruction(new Instruction("LHLD", 0x2a, 3, 16, 0, LHLD));
            machine.AddInstruction(new Instruction("DCX H", 0x2b, 1, 5, 0, DCX_H));
            machine.AddInstruction(new Instruction("INR L", 0x2c, 1, 5, 0, INR_L));
            machine.AddInstruction(new Instruction("DCR L", 0x2d, 1, 5, 0, DCR_L));
            machine.AddInstruction(new Instruction("MVI L", 0x2e, 2, 7, 0, MVI_L));
            machine.AddInstruction(new Instruction("CMA", 0x2f, 1, 4, 0, CMA));
            machine.AddInstruction(new Instruction("*NOP", 0x30, 1, 4, 0, NOP));
            machine.AddInstruction(new Instruction("LXI SP", 0x31, 3, 10, 0, LXI_SP));
            machine.AddInstruction(new Instruction("STA", 0x32, 3, 13, 0, STA));
            machine.AddInstruction(new Instruction("INX SP", 0x33, 1, 5, 0, INX_SP));
            machine.AddInstruction(new Instruction("INR M", 0x34, 1, 10, 0, INR_M));
            machine.AddInstruction(new Instruction("DCR M", 0x35, 1, 10, 0, DCR_M));
            machine.AddInstruction(new Instruction("MVI M", 0x36, 2, 10, 0, MVI_M));
            machine.AddInstruction(new Instruction("STC", 0x37, 1, 4, 0, STC));
            machine.AddInstruction(new Instruction("*NOP", 0x38, 1, 4, 0, NOP));
            machine.AddInstruction(new Instruction("DAD SP", 0x39, 1, 10, 0, DAD_SP));
            machine.AddInstruction(new Instruction("LDA", 0x3a, 3, 13, 0, LDA));
            machine.AddInstruction(new Instruction("DCX SP", 0x3b, 1, 5, 0, DCX_SP));
            machine.AddInstruction(new Instruction("INR A", 0x3c, 1, 5, 0, INR_A));
            machine.AddInstruction(new Instruction("DCR A", 0x3d, 1, 5, 0, DCR_A));
            machine.AddInstruction(new Instruction("MVI A", 0x3e, 2, 7, 0, MVI_A));
            machine.AddInstruction(new Instruction("CMC", 0x3f, 1, 4, 0, CMC));
            machine.AddInstruction(new Instruction("MOV B,B", 0x40, 1, 5, 0, MOV_B_B));
            machine.AddInstruction(new Instruction("MOV B,C", 0x41, 1, 5, 0, MOV_B_C));
            machine.AddInstruction(new Instruction("MOV B,D", 0x42, 1, 5, 0, MOV_B_D));
            machine.AddInstruction(new Instruction("MOV B,E", 0x43, 1, 5, 0, MOV_B_E));
            machine.AddInstruction(new Instruction("MOV B,H", 0x44, 1, 5, 0, MOV_B_H));
            machine.AddInstruction(new Instruction("MOV B,L", 0x45, 1, 5, 0, MOV_B_L));
            machine.AddInstruction(new Instruction("MOV B,M", 0x46, 1, 7, 0, MOV_B_M));
            machine.AddInstruction(new Instruction("MOV B,A", 0x47, 1, 5, 0, MOV_B_A));
            machine.AddInstruction(new Instruction("MOV C,B", 0x48, 1, 5, 0, MOV_C_B));
            machine.AddInstruction(new Instruction("MOV C,C", 0x49, 1, 5, 0, MOV_C_C));
            machine.AddInstruction(new Instruction("MOV C,D", 0x4a, 1, 5, 0, MOV_C_D));
            machine.AddInstruction(new Instruction("MOV C,E", 0x4b, 1, 5, 0, MOV_C_E));
            machine.AddInstruction(new Instruction("MOV C,H", 0x4c, 1, 5, 0, MOV_C_H));
            machine.AddInstruction(new Instruction("MOV C,L", 0x4d, 1, 5, 0, MOV_C_L));
            machine.AddInstruction(new Instruction("MOV C,M", 0x4e, 1, 7, 0, MOV_C_M));
            machine.AddInstruction(new Instruction("MOV C,A", 0x4f, 1, 5, 0, MOV_C_A));
            machine.AddInstruction(new Instruction("MOV D,B", 0x50, 1, 5, 0, MOV_D_B));
            machine.AddInstruction(new Instruction("MOV D,C", 0x51, 1, 5, 0, MOV_D_C));
            machine.AddInstruction(new Instruction("MOV D,D", 0x52, 1, 5, 0, MOV_D_D));
            machine.AddInstruction(new Instruction("MOV D,E", 0x53, 1, 5, 0, MOV_D_E));
            machine.AddInstruction(new Instruction("MOV D,H", 0x54, 1, 5, 0, MOV_D_H));
            machine.AddInstruction(new Instruction("MOV D,L", 0x55, 1, 5, 0, MOV_D_L));
            machine.AddInstruction(new Instruction("MOV D,M", 0x56, 1, 7, 0, MOV_D_M));
            machine.AddInstruction(new Instruction("MOV D,A", 0x57, 1, 5, 0, MOV_D_A));
            machine.AddInstruction(new Instruction("MOV E,B", 0x58, 1, 5, 0, MOV_E_B));
            machine.AddInstruction(new Instruction("MOV E,C", 0x59, 1, 5, 0, MOV_E_C));
            machine.AddInstruction(new Instruction("MOV E,D", 0x5a, 1, 5, 0, MOV_E_D));
            machine.AddInstruction(new Instruction("MOV E,E", 0x5b, 1, 5, 0, MOV_E_E));
            machine.AddInstruction(new Instruction("MOV E,H", 0x5c, 1, 5, 0, MOV_E_H));
            machine.AddInstruction(new Instruction("MOV E,L", 0x5d, 1, 5, 0, MOV_E_L));
            machine.AddInstruction(new Instruction("MOV E,M", 0x5e, 1, 7, 0, MOV_E_M));
            machine.AddInstruction(new Instruction("MOV E,A", 0x5f, 1, 5, 0, MOV_E_A));
            machine.AddInstruction(new Instruction("MOV H,B", 0x60, 1, 5, 0, MOV_H_B));
            machine.AddInstruction(new Instruction("MOV H,C", 0x61, 1, 5, 0, MOV_H_C));
            machine.AddInstruction(new Instruction("MOV H,D", 0x62, 1, 5, 0, MOV_H_D));
            machine.AddInstruction(new Instruction("MOV H,E", 0x63, 1, 5, 0, MOV_H_E));
            machine.AddInstruction(new Instruction("MOV H,H", 0x64, 1, 5, 0, MOV_H_H));
            machine.AddInstruction(new Instruction("MOV H,L", 0x65, 1, 5, 0, MOV_H_L));
            machine.AddInstruction(new Instruction("MOV H,M", 0x66, 1, 7, 0, MOV_H_M));
            machine.AddInstruction(new Instruction("MOV H,A", 0x67, 1, 5, 0, MOV_H_A));
            machine.AddInstruction(new Instruction("MOV L,B", 0x68, 1, 5, 0, MOV_L_B));
            machine.AddInstruction(new Instruction("MOV L,C", 0x69, 1, 5, 0, MOV_L_C));
            machine.AddInstruction(new Instruction("MOV L,D", 0x6a, 1, 5, 0, MOV_L_D));
            machine.AddInstruction(new Instruction("MOV L,E", 0x6b, 1, 5, 0, MOV_L_E));
            machine.AddInstruction(new Instruction("MOV L,H", 0x6c, 1, 5, 0, MOV_L_H));
            machine.AddInstruction(new Instruction("MOV L,L", 0x6d, 1, 5, 0, MOV_L_L));
            machine.AddInstruction(new Instruction("MOV L,M", 0x6e, 1, 7, 0, MOV_L_M));
            machine.AddInstruction(new Instruction("MOV L,A", 0x6f, 1, 5, 0, MOV_L_A));
            machine.AddInstruction(new Instruction("MOV M,B", 0x70, 1, 7, 0, MOV_M_B));
            machine.AddInstruction(new Instruction("MOV M,C", 0x71, 1, 7, 0, MOV_M_C));
            machine.AddInstruction(new Instruction("MOV M,D", 0x72, 1, 7, 0, MOV_M_D));
            machine.AddInstruction(new Instruction("MOV M,E", 0x73, 1, 7, 0, MOV_M_E));
            machine.AddInstruction(new Instruction("MOV M,H", 0x74, 1, 7, 0, MOV_M_H));
            machine.AddInstruction(new Instruction("MOV M,L", 0x75, 1, 7, 0, MOV_M_L));
            machine.AddInstruction(new Instruction("HLT", 0x76, 1, 7, 0, HLT));
            machine.AddInstruction(new Instruction("MOV M,A", 0x77, 1, 7, 0, MOV_M_A));
            machine.AddInstruction(new Instruction("MOV A,B", 0x78, 1, 5, 0, MOV_A_B));
            machine.AddInstruction(new Instruction("MOV A,C", 0x79, 1, 5, 0, MOV_A_C));
            machine.AddInstruction(new Instruction("MOV A,D", 0x7a, 1, 5, 0, MOV_A_D));
            machine.AddInstruction(new Instruction("MOV A,E", 0x7b, 1, 5, 0, MOV_A_E));
            machine.AddInstruction(new Instruction("MOV A,H", 0x7c, 1, 5, 0, MOV_A_H));
            machine.AddInstruction(new Instruction("MOV A,L", 0x7d, 1, 5, 0, MOV_A_L));
            machine.AddInstruction(new Instruction("MOV A,M", 0x7e, 1, 7, 0, MOV_A_M));
            machine.AddInstruction(new Instruction("MOV A,A", 0x7f, 1, 5, 0, MOV_A_A));
            machine.AddInstruction(new Instruction("ADD B", 0x80, 1, 4, 0, ADD_B));
            machine.AddInstruction(new Instruction("ADD C", 0x81, 1, 4, 0, ADD_C));
            machine.AddInstruction(new Instruction("ADD D", 0x82, 1, 4, 0, ADD_D));
            machine.AddInstruction(new Instruction("ADD E", 0x83, 1, 4, 0, ADD_E));
            machine.AddInstruction(new Instruction("ADD H", 0x84, 1, 4, 0, ADD_H));
            machine.AddInstruction(new Instruction("ADD L", 0x85, 1, 4, 0, ADD_L));
            machine.AddInstruction(new Instruction("ADD M", 0x86, 1, 7, 0, ADD_M));
            machine.AddInstruction(new Instruction("ADD A", 0x87, 1, 4, 0, ADD_A));
            machine.AddInstruction(new Instruction("ADC B", 0x88, 1, 4, 0, ADC_B));
            machine.AddInstruction(new Instruction("ADC C", 0x89, 1, 4, 0, ADC_C));
            machine.AddInstruction(new Instruction("ADC D", 0x8a, 1, 4, 0, ADC_D));
            machine.AddInstruction(new Instruction("ADC E", 0x8b, 1, 4, 0, ADC_E));
            machine.AddInstruction(new Instruction("ADC H", 0x8c, 1, 4, 0, ADC_H));
            machine.AddInstruction(new Instruction("ADC L", 0x8d, 1, 4, 0, ADC_L));
            machine.AddInstruction(new Instruction("ADC M", 0x8e, 1, 7, 0, ADC_M));
            machine.AddInstruction(new Instruction("ADC A", 0x8f, 1, 4, 0, ADC_A));
            machine.AddInstruction(new Instruction("SUB B", 0x90, 1, 4, 0, SUB_B));
            machine.AddInstruction(new Instruction("SUB C", 0x91, 1, 4, 0, SUB_C));
            machine.AddInstruction(new Instruction("SUB D", 0x92, 1, 4, 0, SUB_D));
            machine.AddInstruction(new Instruction("SUB E", 0x93, 1, 4, 0, SUB_E));
            machine.AddInstruction(new Instruction("SUB H", 0x94, 1, 4, 0, SUB_H));
            machine.AddInstruction(new Instruction("SUB L", 0x95, 1, 4, 0, SUB_L));
            machine.AddInstruction(new Instruction("SUB M", 0x96, 1, 7, 0, SUB_M));
            machine.AddInstruction(new Instruction("SUB A", 0x97, 1, 4, 0, SUB_A));
            machine.AddInstruction(new Instruction("SBB B", 0x98, 1, 4, 0, SBB_B));
            machine.AddInstruction(new Instruction("SBB C", 0x99, 1, 4, 0, SBB_C));
            machine.AddInstruction(new Instruction("SBB D", 0x9a, 1, 4, 0, SBB_D));
            machine.AddInstruction(new Instruction("SBB E", 0x9b, 1, 4, 0, SBB_E));
            machine.AddInstruction(new Instruction("SBB H", 0x9c, 1, 4, 0, SBB_H));
            machine.AddInstruction(new Instruction("SBB L", 0x9d, 1, 4, 0, SBB_L));
            machine.AddInstruction(new Instruction("SBB M", 0x9e, 1, 7, 0, SBB_M));
            machine.AddInstruction(new Instruction("SBB A", 0x9f, 1, 4, 0, SBB_A));
            machine.AddInstruction(new Instruction("ANA B", 0xa0, 1, 4, 0, ANA_B));
            machine.AddInstruction(new Instruction("ANA C", 0xa1, 1, 4, 0, ANA_C));
            machine.AddInstruction(new Instruction("ANA D", 0xa2, 1, 4, 0, ANA_D));
            machine.AddInstruction(new Instruction("ANA E", 0xa3, 1, 4, 0, ANA_E));
            machine.AddInstruction(new Instruction("ANA H", 0xa4, 1, 4, 0, ANA_H));
            machine.AddInstruction(new Instruction("ANA L", 0xa5, 1, 4, 0, ANA_L));
            machine.AddInstruction(new Instruction("ANA M", 0xa6, 1, 7, 0, ANA_M));
            machine.AddInstruction(new Instruction("ANA A", 0xa7, 1, 4, 0, ANA_A));
            machine.AddInstruction(new Instruction("XRA B", 0xa8, 1, 4, 0, XRA_B));
            machine.AddInstruction(new Instruction("XRA C", 0xa9, 1, 4, 0, XRA_C));
            machine.AddInstruction(new Instruction("XRA D", 0xaa, 1, 4, 0, XRA_D));
            machine.AddInstruction(new Instruction("XRA E", 0xab, 1, 4, 0, XRA_E));
            machine.AddInstruction(new Instruction("XRA H", 0xac, 1, 4, 0, XRA_H));
            machine.AddInstruction(new Instruction("XRA L", 0xad, 1, 4, 0, XRA_L));
            machine.AddInstruction(new Instruction("XRA M", 0xae, 1, 7, 0, XRA_M));
            machine.AddInstruction(new Instruction("XRA A", 0xaf, 1, 4, 0, XRA_A));
            machine.AddInstruction(new Instruction("ORA B", 0xb0, 1, 4, 0, ORA_B));
            machine.AddInstruction(new Instruction("ORA C", 0xb1, 1, 4, 0, ORA_C));
            machine.AddInstruction(new Instruction("ORA D", 0xb2, 1, 4, 0, ORA_D));
            machine.AddInstruction(new Instruction("ORA E", 0xb3, 1, 4, 0, ORA_E));
            machine.AddInstruction(new Instruction("ORA H", 0xb4, 1, 4, 0, ORA_H));
            machine.AddInstruction(new Instruction("ORA L", 0xb5, 1, 4, 0, ORA_L));
            machine.AddInstruction(new Instruction("ORA M", 0xb6, 1, 7, 0, ORA_M));
            machine.AddInstruction(new Instruction("ORA A", 0xb7, 1, 4, 0, ORA_A));
            machine.AddInstruction(new Instruction("CMP B", 0xb8, 1, 4, 0, CMP_B));
            machine.AddInstruction(new Instruction("CMP C", 0xb9, 1, 4, 0, CMP_C));
            machine.AddInstruction(new Instruction("CMP D", 0xba, 1, 4, 0, CMP_D));
            machine.AddInstruction(new Instruction("CMP E", 0xbb, 1, 4, 0, CMP_E));
            machine.AddInstruction(new Instruction("CMP H", 0xbc, 1, 4, 0, CMP_H));
            machine.AddInstruction(new Instruction("CMP L", 0xbd, 1, 4, 0, CMP_L));
            machine.AddInstruction(new Instruction("CMP M", 0xbe, 1, 7, 0, CMP_M));
            machine.AddInstruction(new Instruction("CMP A", 0xbf, 1, 4, 0, CMP_A));
            machine.AddInstruction(new Instruction("RNZ", 0xc0, 1, 11, 5, RNZ));
            machine.AddInstruction(new Instruction("POP B", 0xc1, 1, 10, 0, POP_B));
            machine.AddInstruction(new Instruction("JNZ", 0xc2, 3, 10, 0, JNZ));
            machine.AddInstruction(new Instruction("JMP", 0xc3, 3, 10, 0, JMP));
            machine.AddInstruction(new Instruction("CNZ", 0xc4, 3, 17, 11, CNZ));
            machine.AddInstruction(new Instruction("PUSH B", 0xc5, 1, 11, 0, PUSH_B));
            machine.AddInstruction(new Instruction("ADI", 0xc6, 2, 7, 0, ADI));
            machine.AddInstruction(new Instruction("RST 0", 0xc7, 1, 11, 0, RST_0));
            machine.AddInstruction(new Instruction("RZ", 0xc8, 1, 11, 5, RZ));
            machine.AddInstruction(new Instruction("RET", 0xc9, 1, 10, 0, RET));
            machine.AddInstruction(new Instruction("JZ", 0xca, 3, 10, 0, JZ));
            machine.AddInstruction(new Instruction("*JMP", 0xcb, 3, 10, 0, JMP));
            machine.AddInstruction(new Instruction("CZ", 0xcc, 3, 17, 11, CZ));
            machine.AddInstruction(new Instruction("CALL", 0xcd, 3, 17, 0, CALL));
            machine.AddInstruction(new Instruction("ACI", 0xce, 2, 7, 0, ACI));
            machine.AddInstruction(new Instruction("RST 1", 0xcf, 1, 11, 0, RST_1));
            machine.AddInstruction(new Instruction("RNC", 0xd0, 1, 11, 5, RNC));
            machine.AddInstruction(new Instruction("POP D", 0xd1, 1, 10, 0, POP_D));
            machine.AddInstruction(new Instruction("JNC", 0xd2, 3, 10, 0, JNC));
            machine.AddInstruction(new Instruction("OUT", 0xd3, 2, 10, 0, OUT));
            machine.AddInstruction(new Instruction("CNC", 0xd4, 3, 17, 11, CNC));
            machine.AddInstruction(new Instruction("PUSH D", 0xd5, 1, 11, 0, PUSH_D));
            machine.AddInstruction(new Instruction("SUI", 0xd6, 2, 7, 0, SUI));
            machine.AddInstruction(new Instruction("RST 2", 0xd7, 1, 11, 0, RST_2));
            machine.AddInstruction(new Instruction("RC", 0xd8, 1, 11, 5, RC));
            machine.AddInstruction(new Instruction("*RET", 0xd9, 1, 10, 0, RET));
            machine.AddInstruction(new Instruction("JC", 0xda, 3, 10, 0, JC));
            machine.AddInstruction(new Instruction("IN", 0xdb, 2, 10, 0, IN));
            machine.AddInstruction(new Instruction("CC", 0xdc, 3, 17, 11, CC));
            machine.AddInstruction(new Instruction("*CALL", 0xdd, 3, 17, 0, CALL));
            machine.AddInstruction(new Instruction("SBI", 0xde, 2, 7, 0, SBI));
            machine.AddInstruction(new Instruction("RST 3", 0xdf, 1, 11, 0, RST_3));
            machine.AddInstruction(new Instruction("RPO", 0xe0, 1, 11, 5, RPO));
            machine.AddInstruction(new Instruction("POP H", 0xe1, 1, 10, 0, POP_H));
            machine.AddInstruction(new Instruction("JPO", 0xe2, 3, 10, 0, JPO));
            machine.AddInstruction(new Instruction("XTHL", 0xe3, 1, 18, 0, XTHL));
            machine.AddInstruction(new Instruction("CPO", 0xe4, 3, 17, 11, CPO));
            machine.AddInstruction(new Instruction("PUSH H", 0xe5, 1, 11, 0, PUSH_H));
            machine.AddInstruction(new Instruction("ANI", 0xe6, 2, 7, 0, ANI));
            machine.AddInstruction(new Instruction("RST 4", 0xe7, 1, 11, 0, RST_4));
            machine.AddInstruction(new Instruction("RPE", 0xe8, 1, 11, 5, RPE));
            machine.AddInstruction(new Instruction("PCHL", 0xe9, 1, 5, 0, PCHL));
            machine.AddInstruction(new Instruction("JPE", 0xea, 3, 10, 0, JPE));
            machine.AddInstruction(new Instruction("XCHG", 0xeb, 1, 5, 0, XCHG));
            machine.AddInstruction(new Instruction("CPE", 0xec, 3, 17, 11, CPE));
            machine.AddInstruction(new Instruction("*CALL", 0xed, 3, 17, 0, CALL));
            machine.AddInstruction(new Instruction("XRI", 0xee, 2, 7, 0, XRI));
            machine.AddInstruction(new Instruction("RST 5", 0xef, 1, 11, 0, RST_5));
            machine.AddInstruction(new Instruction("RP", 0xf0, 1, 11, 5, RP));
            machine.AddInstruction(new Instruction("POP PSW", 0xf1, 1, 10, 0, POP_PSW));
            machine.AddInstruction(new Instruction("JP", 0xf2, 3, 10, 0, JP));
            machine.AddInstruction(new Instruction("DI", 0xf3, 1, 4, 0, DI));
            machine.AddInstruction(new Instruction("CP", 0xf4, 3, 17, 11, CP));
            machine.AddInstruction(new Instruction("PUSH PSW", 0xf5, 1, 11, 0, PUSH_PSW));
            machine.AddInstruction(new Instruction("ORI", 0xf6, 2, 7, 0, ORI));
            machine.AddInstruction(new Instruction("RST 6", 0xf7, 1, 11, 0, RST_6));
            machine.AddInstruction(new Instruction("RM", 0xf8, 1, 11, 5, RM));
            machine.AddInstruction(new Instruction("SPHL", 0xf9, 1, 5, 0, SPHL));
            machine.AddInstruction(new Instruction("JM", 0xfa, 3, 10, 0, JM));
            machine.AddInstruction(new Instruction("EI", 0xfb, 1, 4, 0, EI));
            machine.AddInstruction(new Instruction("CM", 0xfc, 3, 17, 11, CM));
            machine.AddInstruction(new Instruction("*CALL", 0xfd, 3, 17, 0, CALL));
            machine.AddInstruction(new Instruction("CPI", 0xfe, 2, 7, 0, CPI));
            machine.AddInstruction(new Instruction("RST 7", 0xff, 1, 11, 0, RST_7));
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

        private static void RST(i8080 machine, RST_TARGETS target)
        {
            ushort address = (ushort)target;
            ushort returnAddress = machine.PC;

            machine.Push((byte)(returnAddress >> 8), (byte)(returnAddress & 0xff));

            machine.PC = address;
        }


        // 0x00
        private static void NOP(i8080 machine, byte b2, byte b3)
        {
        }

        // 0x01
        private static void LXI_B(i8080 machine, byte b2, byte b3)
        {
            machine.C = b2;
            machine.B = b3;
        }

        // 0x02
        private static void STAX_B(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.B << 8) + machine.C);
            machine.WriteMem(address, machine.A);
        }

        // 0x03
        private static void INX_B(i8080 machine, byte b2, byte b3)
        {
            ushort value = (ushort)((machine.B << 8) + machine.C);
            value++;
            machine.C = (byte)(value & 0xff);
            machine.B = (byte)(value >> 8);
        }

        // 0x04
        private static void INR_B(i8080 machine, byte b2, byte b3)
        {
            machine.B += 1;
            machine.FlagsZSP(machine.B, i8080.AccessoryFlagRule.Inc);
        }

        // 0x05
        private static void DCR_B(i8080 machine, byte b2, byte b3)
        {
            machine.B -= 1;
            machine.FlagsZSP(machine.B, i8080.AccessoryFlagRule.Dec);
        }

        // 0x06
        private static void MVI_B(i8080 machine, byte b2, byte b3)
        {
            machine.B = b2;
        }

        // 0x07
        private static void RLC(i8080 machine, byte b2, byte b3)
        {
            byte x = (byte)(machine.A >> 7);
            if (x != 0)
            {
                machine.SetFlag(i8080.Flags.C);
            }
            else
            {
                machine.ClearFlag(i8080.Flags.C);
            }

            machine.A = (byte)((machine.A << 1 & 0xFF) | x);
        }

        // 0x08 -> NOP

        // 0x09
        private static void DAD_B(i8080 machine, byte b2, byte b3)
        {
            ushort hl = (ushort)((machine.H << 8) + machine.L);
            ushort bc = (ushort)((machine.B << 8) + machine.C);

            if ((hl + bc) > 0xffff) machine.SetFlag(i8080.Flags.C); else machine.ClearFlag(i8080.Flags.C);

            ushort res = (ushort)(hl + bc);

            machine.H = (byte)((res & 0xff00) >> 8);
            machine.L = (byte)(res & 0xff);
        }

        // 0x0a
        private static void LDAX_B(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.B << 8) + machine.C);
            machine.A = machine.RAM[address];
        }

        // 0x0b
        private static void DCX_B(i8080 machine, byte b2, byte b3)
        {
            ushort value = (ushort)((machine.B << 8) + machine.C);
            value--;
            machine.C = (byte)(value & 0xff);
            machine.B = (byte)(value >> 8);
        }

        // 0x0c
        private static void INR_C(i8080 machine, byte b2, byte b3)
        {
            machine.C += 1;
            machine.FlagsZSP(machine.C, i8080.AccessoryFlagRule.Inc);
        }

        //  
        public static void DCR_C(i8080 machine, byte b2, byte b3)
        {
            machine.C -= 1;
            machine.FlagsZSP(machine.C, i8080.AccessoryFlagRule.Dec);
        }

        // 0x0e
        private static void MVI_C(i8080 machine, byte b2, byte b3)
        {
            machine.C = b2;
        }

        // 0x0f
        public static void RRC(i8080 machine, byte b2, byte b3)
        {
            byte x = machine.A;
            if (1 == (x & 1))
            {
                machine.SetFlag(i8080.Flags.C);
                machine.A = (byte)(machine.A >> 1 | 1 << 7);
            }
            else
            {
                machine.A = (byte)(machine.A >> 1);
                machine.ClearFlag(i8080.Flags.C);
            }
        }

        // 0x10 -> NOP

        // 0x11
        private static void LXI_D(i8080 machine, byte b2, byte b3)
        {
            machine.E = b2;
            machine.D = b3;
        }

        // 0x12
        private static void STAX_D(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.D << 8) + machine.E);
            machine.WriteMem(address, machine.A);
        }

        // 0x13
        private static void INX_D(i8080 machine, byte b2, byte b3)
        {
            ushort value = (ushort)((machine.D << 8) + machine.E);
            value++;
            machine.E = (byte)(value & 0xff);
            machine.D = (byte)(value >> 8);
        }

        //0x14
        private static void INR_D(i8080 machine, byte b2, byte b3)
        {
            machine.D += 1;
            machine.FlagsZSP(machine.D, i8080.AccessoryFlagRule.Inc);
        }

        // //0x15
        private static void DCR_D(i8080 machine, byte b2, byte b3)
        {
            machine.D -= 1;
            machine.FlagsZSP(machine.D, i8080.AccessoryFlagRule.Dec);
        }

        // 0x16
        private static void MVI_D(i8080 machine, byte b2, byte b3)
        {
            machine.D = b2;
        }

        // 0x17
        internal static void RAL(i8080 machine, byte b2, byte b3)
        {
            byte x = machine.A;
            machine.A = (byte)((machine.F & (byte)i8080.Flags.C) | (x << 1));

            if (0x80 == (x & 0x80)) machine.SetFlag(i8080.Flags.C); else machine.ClearFlag(i8080.Flags.C);
        }

        // 0x18 -> NOP

        // 0x19
        private static void DAD_D(i8080 machine, byte b2, byte b3)
        {
            ushort hl = (ushort)((machine.H << 8) + machine.L);
            ushort de = (ushort)((machine.D << 8) + machine.E);

            if ((hl + de) > 0xffff) machine.SetFlag(i8080.Flags.C); else machine.ClearFlag(i8080.Flags.C);

            ushort res = (ushort)(hl + de);

            machine.H = (byte)((res & 0xff00) >> 8);
            machine.L = (byte)(res & 0xff);
        }

        // 0x1a
        private static void LDAX_D(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.D << 8) + machine.E);
            machine.A = machine.RAM[address];
        }

        // 0x1b
        private static void DCX_D(i8080 machine, byte b2, byte b3)
        {
            ushort value = (ushort)((machine.D << 8) + machine.E);
            value--;
            machine.E = (byte)(value & 0xff);
            machine.D = (byte)(value >> 8);
        }

        // 0x1c
        private static void INR_E(i8080 machine, byte b2, byte b3)
        {
            machine.E += 1;
            machine.FlagsZSP(machine.E, i8080.AccessoryFlagRule.Inc);
        }

        // 0x1d
        private static void DCR_E(i8080 machine, byte b2, byte b3)
        {
            machine.E -= 1;
            machine.FlagsZSP(machine.E, i8080.AccessoryFlagRule.Dec);
        }

        // 0x1e
        private static void MVI_E(i8080 machine, byte b2, byte b3)
        {
            machine.E = b2;
        }

        // 0x1f
        internal static void RAR(i8080 machine, byte b2, byte b3)
        {
            bool cy = (machine.F & (byte)i8080.Flags.C) != 0;
            if ((machine.A & 1) != 0)
            {
                machine.SetFlag(i8080.Flags.C);
            }
            else
            {
                machine.ClearFlag(i8080.Flags.C);
            }

            if (cy)
            {
                machine.A = (byte)((machine.A >> 1) | (1 << 7));
            }
            else
            {
                machine.A = (byte)(machine.A >> 1);
            }
        }

        // 0x20 -> NOP

        // 0x21
        private static void LXI_H(i8080 machine, byte b2, byte b3)
        {
            machine.L = b2;
            machine.H = b3;
        }

        // 0x22
        private static void SHLD(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((b3 << 8) + b2);
            machine.WriteMem(address, machine.L);
            address = (ushort)(address + 1);
            machine.WriteMem(address, machine.H);
        }

        // 0x23
        private static void INX_H(i8080 machine, byte b2, byte b3)
        {
            ushort value = (ushort)((machine.H << 8) + machine.L);
            value++;
            machine.L = (byte)(value & 0x00ff);
            machine.H = (byte)(value >> 8);
        }

        // 0x24
        private static void INR_H(i8080 machine, byte b2, byte b3)
        {
            machine.H += 1;
            machine.FlagsZSP(machine.H, i8080.AccessoryFlagRule.Inc);
        }

        // 0x25
        private static void DCR_H(i8080 machine, byte b2, byte b3)
        {
            machine.H -= 1;
            machine.FlagsZSP(machine.H, i8080.AccessoryFlagRule.Dec);
        }

        // 0x26
        private static void MVI_H(i8080 machine, byte b2, byte b3)
        {
            machine.H = b2;
        }

        // 0x27
        internal static void DAA(i8080 machine, byte b2, byte b3)
        {
            bool cy = ((byte)i8080.Flags.C & machine.F) != 0;
            bool hf = ((byte)i8080.Flags.A & machine.F) != 0;

            byte correction = 0;

            byte lsb = (byte)(machine.A & 0x0F);
            byte msb = (byte)(machine.A >> 4);

            if (hf || (machine.A & 0xf) > 9)
            {
                correction += 0x06;
            }
            if (cy || msb > 9 || (msb >= 9 && lsb > 9))
            {
                correction += 0x60;
                cy = true;
            }

            machine.A = machine.Add(machine.A, correction, false);

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
        private static void DAD_H(i8080 machine, byte b2, byte b3)
        {
            ushort hl = (ushort)((machine.H << 8) + machine.L);

            if ((hl + hl) > 0xffff) machine.SetFlag(i8080.Flags.C); else machine.ClearFlag(i8080.Flags.C);

            ushort res = (ushort)(hl + hl);

            machine.H = (byte)((res & 0xff00) >> 8);
            machine.L = (byte)(res & 0xff);
        }

        // 0x2a
        internal static void LHLD(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((b3 << 8) + b2);
            machine.L = machine.RAM[address];
            machine.H = machine.RAM[address + 1];
        }

        // 0x2b
        private static void DCX_H(i8080 machine, byte b2, byte b3)
        {
            ushort value = (ushort)((machine.H << 8) + machine.L);
            value--;
            machine.L = (byte)(value & 0xff);
            machine.H = (byte)(value >> 8);
        }

        // 0x2c
        private static void INR_L(i8080 machine, byte b2, byte b3)
        {
            machine.L += 1;
            machine.FlagsZSP(machine.L, i8080.AccessoryFlagRule.Inc);
        }

        // 0x2d
        private static void DCR_L(i8080 machine, byte b2, byte b3)
        {
            machine.L -= 1;
            machine.FlagsZSP(machine.L, i8080.AccessoryFlagRule.Dec);
        }

        // 0x2e
        private static void MVI_L(i8080 machine, byte b2, byte b3)
        {
            machine.L = b2;
        }

        // 0x2f
        private static void CMA(i8080 machine, byte b2, byte b3)
        {
            machine.A = (byte)~machine.A;
        }

        // 0x30 -> NOP

        // 0x31
        private static void LXI_SP(i8080 machine, byte b2, byte b3)
        {
            machine.SP = (ushort)((b3 << 8) + b2);
        }

        // 0x32
        private static void STA(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((b3 << 8) + b2);
            machine.WriteMem(address, machine.A);
        }

        // 0x33
        private static void INX_SP(i8080 machine, byte b2, byte b3)
        {
            machine.SP++;
        }

        // 0x34
        private static void INR_M(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.WriteMem(address, (byte)(machine.RAM[address] + 1));
            machine.FlagsZSP(machine.RAM[address], i8080.AccessoryFlagRule.Inc);
        }

        // 0x35
        private static void DCR_M(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.WriteMem(address, (byte)(machine.RAM[address] - 1));
            machine.FlagsZSP(machine.RAM[address], i8080.AccessoryFlagRule.Dec);
        }

        // 0x36
        private static void MVI_M(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.WriteMem(address, b2);
        }

        // 0x37
        private static void STC(i8080 machine, byte b2, byte b3)
        {
            machine.SetFlag(i8080.Flags.C);
        }

        // 0x38 -> NOP

        // 0x39
        private static void DAD_SP(i8080 machine, byte b2, byte b3)
        {
            ushort hl = (ushort)((machine.H << 8) + machine.L);

            if ((hl + machine.SP) > 0xffff) machine.SetFlag(i8080.Flags.C); else machine.ClearFlag(i8080.Flags.C);

            ushort res = (ushort)(hl + machine.SP);

            machine.H = (byte)((res & 0xff00) >> 8);
            machine.L = (byte)(res & 0xff);

        }

        // 0x3a
        private static void LDA(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((b3 << 8) + b2);
            machine.A = machine.RAM[address];
        }

        // 0x3b
        private static void DCX_SP(i8080 machine, byte b2, byte b3)
        {
            machine.SP--;
        }

        // 0x3c
        private static void INR_A(i8080 machine, byte b2, byte b3)
        {
            machine.A += 1;
            machine.FlagsZSP(machine.A, i8080.AccessoryFlagRule.Inc);
        }

        // 0x3d
        private static void DCR_A(i8080 machine, byte b2, byte b3)
        {
            machine.A -= 1;
            machine.FlagsZSP(machine.A, i8080.AccessoryFlagRule.Dec);
        }

        // 0x3e
        private static void MVI_A(i8080 machine, byte b2, byte b3)
        {
            machine.A = b2;
        }

        // 0x3f
        private static void CMC(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.C) != 0)
            {
                machine.ClearFlag(i8080.Flags.C);
            }
            else
            {
                machine.SetFlag(i8080.Flags.C);
            }
        }

        // 0x40
        private static void MOV_B_B(i8080 machine, byte b2, byte b3)
        {
            //machine.B = machine.B;
        }

        // 0x41
        private static void MOV_B_C(i8080 machine, byte b2, byte b3)
        {
            machine.B = machine.C;
        }

        // 0x42
        private static void MOV_B_D(i8080 machine, byte b2, byte b3)
        {
            machine.B = machine.D;
        }

        // 0x43
        private static void MOV_B_E(i8080 machine, byte b2, byte b3)
        {
            machine.B = machine.E;
        }

        // 0x44
        private static void MOV_B_H(i8080 machine, byte b2, byte b3)
        {
            machine.B = machine.H;
        }

        // 0x45
        private static void MOV_B_L(i8080 machine, byte b2, byte b3)
        {
            machine.B = machine.L;
        }

        // 0x46
        private static void MOV_B_M(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.B = machine.RAM[address];
        }

        // 0x47
        private static void MOV_B_A(i8080 machine, byte b2, byte b3)
        {
            machine.B = machine.A;
        }

        // 0x48
        private static void MOV_C_B(i8080 machine, byte b2, byte b3)
        {
            machine.C = machine.B;
        }

        // 0x49
        private static void MOV_C_C(i8080 machine, byte b2, byte b3)
        {
            //machine.C = machine.C;
        }

        // 0x4a
        private static void MOV_C_D(i8080 machine, byte b2, byte b3)
        {
            machine.C = machine.D;
        }

        // 0x4b
        private static void MOV_C_E(i8080 machine, byte b2, byte b3)
        {
            machine.C = machine.E;
        }

        // 0x4c
        private static void MOV_C_H(i8080 machine, byte b2, byte b3)
        {
            machine.C = machine.H;
        }

        // 0x4d
        private static void MOV_C_L(i8080 machine, byte b2, byte b3)
        {
            machine.C = machine.L;
        }

        // 0x4e
        private static void MOV_C_M(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.C = machine.RAM[address];
        }

        // 0x4f
        private static void MOV_C_A(i8080 machine, byte b2, byte b3)
        {
            machine.C = machine.A;
        }

        // 0x50
        private static void MOV_D_B(i8080 machine, byte b2, byte b3)
        {
            machine.D = machine.B;
        }

        // 0x51
        private static void MOV_D_C(i8080 machine, byte b2, byte b3)
        {
            machine.D = machine.C;
        }

        // 0x52
        private static void MOV_D_D(i8080 machine, byte b2, byte b3)
        {
            //machine.D = machine.D;
        }

        // 0x53
        private static void MOV_D_E(i8080 machine, byte b2, byte b3)
        {
            machine.D = machine.E;
        }

        // 0x54
        private static void MOV_D_H(i8080 machine, byte b2, byte b3)
        {
            machine.D = machine.H;
        }

        // 0x55
        private static void MOV_D_L(i8080 machine, byte b2, byte b3)
        {
            machine.D = machine.L;
        }

        // 0x56
        private static void MOV_D_M(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.D = machine.RAM[address];
        }

        //.0x57
        private static void MOV_D_A(i8080 machine, byte b2, byte b3)
        {
            machine.D = machine.A;
        }

        // 0x58
        private static void MOV_E_B(i8080 machine, byte b2, byte b3)
        {
            machine.E = machine.B;
        }

        // 0x59
        private static void MOV_E_C(i8080 machine, byte b2, byte b3)
        {
            machine.E = machine.C;
        }

        // 0x5a
        private static void MOV_E_D(i8080 machine, byte b2, byte b3)
        {
            machine.E = machine.D;
        }

        // 0x5b
        private static void MOV_E_E(i8080 machine, byte b2, byte b3)
        {
            //machine.E = machine.E;
        }

        // 0x5c
        private static void MOV_E_H(i8080 machine, byte b2, byte b3)
        {
            machine.E = machine.H;
        }

        // 0x5d
        private static void MOV_E_L(i8080 machine, byte b2, byte b3)
        {
            machine.E = machine.L;
        }

        // 0x5e
        private static void MOV_E_M(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.E = machine.RAM[address];
        }

        // 0x5f
        private static void MOV_E_A(i8080 machine, byte b2, byte b3)
        {
            machine.E = machine.A;
        }

        // 0x60
        private static void MOV_H_B(i8080 machine, byte b2, byte b3)
        {
            machine.H = machine.B;
        }

        // 0x61
        private static void MOV_H_C(i8080 machine, byte b2, byte b3)
        {
            machine.H = machine.C;
        }

        // 0x62
        private static void MOV_H_D(i8080 machine, byte b2, byte b3)
        {
            machine.H = machine.D;
        }

        // 0x63
        private static void MOV_H_E(i8080 machine, byte b2, byte b3)
        {
            machine.H = machine.E;
        }

        // 0x64
        private static void MOV_H_H(i8080 machine, byte b2, byte b3)
        {
            //machine.H = machine.H;
        }

        // 0x65
        private static void MOV_H_L(i8080 machine, byte b2, byte b3)
        {
            machine.H = machine.L;
        }

        // 0x66
        private static void MOV_H_M(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.H = machine.RAM[address];
        }

        // 0x67
        private static void MOV_H_A(i8080 machine, byte b2, byte b3)
        {
            machine.H = machine.A;
        }

        // 0x68
        private static void MOV_L_B(i8080 machine, byte b2, byte b3)
        {
            machine.L = machine.B;
        }

        // 0x69
        private static void MOV_L_C(i8080 machine, byte b2, byte b3)
        {
            machine.L = machine.C;
        }

        // 0x6a
        private static void MOV_L_D(i8080 machine, byte b2, byte b3)
        {
            machine.L = machine.D;
        }

        // 0x6b
        private static void MOV_L_E(i8080 machine, byte b2, byte b3)
        {
            machine.L = machine.E;
        }

        // 0x6c
        private static void MOV_L_H(i8080 machine, byte b2, byte b3)
        {
            machine.L = machine.H;
        }

        // 0x6d
        private static void MOV_L_L(i8080 machine, byte b2, byte b3)
        {
            //machine.L = machine.L;
        }

        // 0x6e
        private static void MOV_L_M(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.L = machine.RAM[address];
        }

        // 0x6f
        private static void MOV_L_A(i8080 machine, byte b2, byte b3)
        {
            machine.L = machine.A;
        }

        // 0x70
        private static void MOV_M_B(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.WriteMem(address, machine.B);
        }

        // 0x71
        private static void MOV_M_C(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.WriteMem(address, machine.C);
        }

        // 0x72
        private static void MOV_M_D(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.WriteMem(address, machine.D);
        }

        // 0x73
        private static void MOV_M_E(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.WriteMem(address, machine.E);
        }

        // 0x74
        private static void MOV_M_H(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.WriteMem(address, machine.H);
        }

        // 0x75
        private static void MOV_M_L(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.WriteMem(address, machine.L);
        }

        // 0x76
        private static void HLT(i8080 machine, byte b2, byte b3)
        {
            //machine.On = false;
        }

        // 0x77
        private static void MOV_M_A(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.WriteMem(address, machine.A);
        }

        // 0x78
        private static void MOV_A_B(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.B;
        }

        // 0x79
        private static void MOV_A_C(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.C;
        }

        // 0x7a
        private static void MOV_A_D(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.D;
        }

        // 0x7b
        private static void MOV_A_E(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.E;
        }

        // 0x7c
        private static void MOV_A_H(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.H;
        }

        // 0x7d
        private static void MOV_A_L(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.L;
        }

        // 0x7e
        private static void MOV_A_M(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.A = machine.RAM[address];
        }

        // 0x7f
        private static void MOV_A_A(i8080 machine, byte b2, byte b3)
        {
            //machine.A = machine.A;
        }

        // 0x80
        private static void ADD_B(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Add(machine.A, machine.B, false);
        }

        // 0x81
        private static void ADD_C(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Add(machine.A, machine.C, false);
        }

        // 0x82
        private static void ADD_D(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Add(machine.A, machine.D, false);
        }

        // 0x83
        private static void ADD_E(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Add(machine.A, machine.E, false);
        }

        // 0x84
        private static void ADD_H(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Add(machine.A, machine.H, false);
        }

        // 0x85
        private static void ADD_L(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Add(machine.A, machine.L, false);
        }

        // 0x86
        private static void ADD_M(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.A = machine.Add(machine.A, machine.RAM[address], false);
        }

        // 0x87
        private static void ADD_A(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Add(machine.A, machine.A, false);
        }

        // 0x88
        public static void ADC_B(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Add(machine.A, machine.B, (byte)(machine.F & (byte)i8080.Flags.C) != 0);
        }

        // 0x89
        public static void ADC_C(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Add(machine.A, machine.C, (byte)(machine.F & (byte)i8080.Flags.C) != 0);
        }

        // 0x8a
        public static void ADC_D(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Add(machine.A, machine.D, (byte)(machine.F & (byte)i8080.Flags.C) != 0);
        }

        // 0x8b
        public static void ADC_E(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Add(machine.A, machine.E, (byte)(machine.F & (byte)i8080.Flags.C) != 0);
        }

        // 0x8c
        public static void ADC_H(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Add(machine.A, machine.H, (byte)(machine.F & (byte)i8080.Flags.C) != 0);
        }

        // 0x8d
        public static void ADC_L(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Add(machine.A, machine.L, (byte)(machine.F & (byte)i8080.Flags.C) != 0);
        }

        // 0x8e
        public static void ADC_M(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.A = machine.Add(machine.A, machine.RAM[address], (byte)(machine.F & (byte)i8080.Flags.C) != 0);
        }

        // 0x8f
        public static void ADC_A(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Add(machine.A, machine.A, (byte)(machine.F & (byte)i8080.Flags.C) != 0);
        }

        // 0x90
        private static void SUB_B(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Sub(machine.A, machine.B, false);
        }

        // 0x91
        private static void SUB_C(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Sub(machine.A, machine.C, false);
        }

        //0x92
        private static void SUB_D(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Sub(machine.A, machine.D, false);
        }

        // 0x93
        private static void SUB_E(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Sub(machine.A, machine.E, false);
        }

        // 0x94
        private static void SUB_H(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Sub(machine.A, machine.H, false);
        }

        // 0x95
        private static void SUB_L(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Sub(machine.A, machine.L, false);
        }

        // 0x96
        private static void SUB_M(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.A = machine.Sub(machine.A, machine.RAM[address], false);
        }

        // 0x97
        private static void SUB_A(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Sub(machine.A, machine.A, false);
        }

        // 0x98
        private static void SBB_B(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Sub(machine.A, machine.B, (byte)(machine.F & (byte)i8080.Flags.C) != 0);
        }

        // 0x99
        private static void SBB_C(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Sub(machine.A, machine.C, (byte)(machine.F & (byte)i8080.Flags.C) != 0);
        }

        // 0x9a
        private static void SBB_D(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Sub(machine.A, machine.D, (byte)(machine.F & (byte)i8080.Flags.C) != 0);
        }

        // 0x9b
        private static void SBB_E(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Sub(machine.A, machine.E, (byte)(machine.F & (byte)i8080.Flags.C) != 0);
        }

        // 0x9c
        private static void SBB_H(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Sub(machine.A, machine.H, (byte)(machine.F & (byte)i8080.Flags.C) != 0);
        }

        // 0x9d
        private static void SBB_L(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Sub(machine.A, machine.L, (byte)(machine.F & (byte)i8080.Flags.C) != 0);
        }

        // 0x9e
        private static void SBB_M(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.A = machine.Sub(machine.A, machine.RAM[address], (byte)(machine.F & (byte)i8080.Flags.C) != 0);
        }

        // 0x9f
        private static void SBB_A(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Sub(machine.A, machine.A, (byte)(machine.F & (byte)i8080.Flags.C) != 0);
        }

        // 0xa0
        private static void ANA_B(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.And(machine.B);
        }

        // 0xa1
        private static void ANA_C(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.And(machine.C);
        }

        // 0xa2
        private static void ANA_D(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.And(machine.D);
        }

        // 0xa3
        private static void ANA_E(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.And(machine.E);
        }

        // 0xa4
        private static void ANA_H(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.And(machine.H);
        }

        // 0xa5
        private static void ANA_L(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.And(machine.L);
        }

        // 0xa6
        private static void ANA_M(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.A = machine.And(machine.RAM[address]);
        }

        // 0xa7
        private static void ANA_A(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.And(machine.A);
        }

        // 0xa8
        private static void XRA_B(i8080 machine, byte b2, byte b3)
        {
            machine.A = (byte)(machine.A ^ machine.B);
            machine.LogicFlags();
        }

        // 0xa9
        private static void XRA_C(i8080 machine, byte b2, byte b3)
        {
            machine.A = (byte)(machine.A ^ machine.C);
            machine.LogicFlags();
        }

        // 0xaa
        private static void XRA_D(i8080 machine, byte b2, byte b3)
        {
            machine.A = (byte)(machine.A ^ machine.D);
            machine.LogicFlags();
        }

        // 0xab
        private static void XRA_E(i8080 machine, byte b2, byte b3)
        {
            machine.A = (byte)(machine.A ^ machine.E);
            machine.LogicFlags();
        }

        // 0xac
        private static void XRA_H(i8080 machine, byte b2, byte b3)
        {
            machine.A = (byte)(machine.A ^ machine.H);
            machine.LogicFlags();
        }

        // 0xad
        private static void XRA_L(i8080 machine, byte b2, byte b3)
        {
            machine.A = (byte)(machine.A ^ machine.L);
            machine.LogicFlags();
        }

        // 0xae
        private static void XRA_M(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.A = (byte)(machine.A ^ machine.RAM[address]);
            machine.LogicFlags();
        }

        // 0xaf
        private static void XRA_A(i8080 machine, byte b2, byte b3)
        {
            machine.A = (byte)(machine.A ^ machine.A);
            machine.LogicFlags();
        }


        // 0xb0
        private static void ORA_B(i8080 machine, byte b2, byte b3)
        {
            machine.A = (byte)(machine.A | machine.B);
            machine.LogicFlags();
        }

        // 0xb1
        private static void ORA_C(i8080 machine, byte b2, byte b3)
        {
            machine.A = (byte)(machine.A | machine.C);
            machine.LogicFlags();
        }

        // 0xb2
        private static void ORA_D(i8080 machine, byte b2, byte b3)
        {
            machine.A = (byte)(machine.A | machine.D);
            machine.LogicFlags();
        }

        // 0xb3
        private static void ORA_E(i8080 machine, byte b2, byte b3)
        {
            machine.A = (byte)(machine.A | machine.E);
            machine.LogicFlags();
        }

        // 0xb4
        private static void ORA_H(i8080 machine, byte b2, byte b3)
        {
            machine.A = (byte)(machine.A | machine.H);
            machine.LogicFlags();
        }

        // 0xb5
        private static void ORA_L(i8080 machine, byte b2, byte b3)
        {
            machine.A = (byte)(machine.A | machine.L);
            machine.LogicFlags();
        }

        // 0xb6
        private static void ORA_M(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.A = (byte)(machine.A | machine.RAM[address]);
            machine.LogicFlags();
        }

        // 0xb7
        private static void ORA_A(i8080 machine, byte b2, byte b3)
        {
            machine.A = (byte)(machine.A | machine.A);
            machine.LogicFlags();
        }

        // 0xb8
        private static void CMP_B(i8080 machine, byte b2, byte b3)
        {
            machine.Compare(machine.B);
        }

        // 0xb9
        private static void CMP_C(i8080 machine, byte b2, byte b3)
        {
            machine.Compare(machine.C);
        }

        // 0xba
        private static void CMP_D(i8080 machine, byte b2, byte b3)
        {
            machine.Compare(machine.D);
        }

        // 0xbb
        private static void CMP_E(i8080 machine, byte b2, byte b3)
        {
            machine.Compare(machine.E);
        }

        // 0xbc
        private static void CMP_H(i8080 machine, byte b2, byte b3)
        {
            machine.Compare(machine.H);
        }

        // 0xbd
        private static void CMP_L(i8080 machine, byte b2, byte b3)
        {
            machine.Compare(machine.L);
        }

        // 0xbe
        private static void CMP_M(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((machine.H << 8) + machine.L);
            machine.Compare(machine.RAM[address]);
        }

        // 0xbf
        private static void CMP_A(i8080 machine, byte b2, byte b3)
        {
            machine.Compare(machine.A);
        }

        // 0xc0
        private static void RNZ(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.Z) == 0)
            {
                machine.PC = machine.Pop();
                }
            }

        // 0xc1
        private static void POP_B(i8080 machine, byte b2, byte b3)
        {
            ushort value = machine.Pop();
            machine.C = (byte)(value & 0x00ff);
            machine.B = (byte)(value >> 8);
        }

        // 0xc2
        private static void JNZ(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.Z) == 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                machine.PC = address;
                }
            }

        // 0xc3
        private static void JMP(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((b3 << 8) + b2);
            machine.PC = address;
        }

        // 0xc4
        private static void CNZ(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.Z) == 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                ushort ret = machine.PC;
                machine.Push((byte)(ret >> 8), (byte)(ret & 0xff));
                machine.PC = address;
                }
            }

        // 0xc5
        private static void PUSH_B(i8080 machine, byte b2, byte b3)
        {
            machine.Push(machine.B, machine.C);
        }

        // 0xc6
        private static void ADI(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Add(machine.A, b2, false);
        }

        // 0xc7
        private static void RST_0(i8080 machine, byte b2, byte b3)
        {
            RST(machine, RST_TARGETS.RST_0);
        }

        // 0xc8
        private static void RZ(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.Z) != 0)
            {
                machine.PC = machine.Pop();
                }
            }

        // 0xc9
        private static void RET(i8080 machine, byte b2, byte b3)
        {
            machine.PC = machine.Pop();
            }

        // 0xca
        private static void JZ(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.Z) != 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                machine.PC = address;
                }
            }

        // 0xcb -> JML

        // 0xcc
        private static void CZ(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.Z) != 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                ushort ret = machine.PC;
                machine.Push((byte)(ret >> 8), (byte)(ret & 0xff));
                machine.PC = address;
                }
            }

        // 0xcd
        private static void CALL(i8080 machine, byte b2, byte b3)
        {
            ushort address = (ushort)((b3 << 8) + b2);
            ushort ret = machine.PC;
            machine.Push((byte)(ret >> 8), (byte)(ret & 0xff));
            machine.PC = address;
                }

        // 0xce
        private static void ACI(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Add(machine.A, b2, (machine.F & (ushort)i8080.Flags.C) != 0);
        }

        // 0xcf
        private static void RST_1(i8080 machine, byte b2, byte b3)
        {
            RST(machine, RST_TARGETS.RST_1);
        }

        // 0xd0
        private static void RNC(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.C) == 0)
            {
                machine.PC = machine.Pop();
                }
            }

        // 0xd1
        private static void POP_D(i8080 machine, byte b2, byte b3)
        {
            ushort value = machine.Pop();
            machine.E = (byte)(value & 0x00ff);
            machine.D = (byte)(value >> 8);
        }

        // 0xd2
        private static void JNC(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.C) == 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                machine.PC = address;
                }
            }

        // 0xd3
        private static void OUT(i8080 machine, byte b2, byte b3)
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
                        machine.SHIFT_OFFSET = (byte)(machine.A & 0x7);
                        break;
                    case 3:
                        machine.PORT_OUT_3 = machine.A;
                        Sound.PlaySounds(machine);
                        break;
                    case 4:
                        machine.SHIFT_LSB = machine.SHIFT_MSB;
                        machine.SHIFT_MSB = machine.A;
                        break;
                    case 5:
                        machine.PORT_OUT_5 = machine.A;
                        Sound.PlaySounds(machine);
                        break;
                    default:
                        break;
                }
            }
        }

        // 0xd4
        private static void CNC(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.C) == 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                ushort ret = machine.PC;
                machine.Push((byte)(ret >> 8), (byte)(ret & 0xff));
                machine.PC = address;
                }
            }

        // 0xd5
        private static void PUSH_D(i8080 machine, byte b2, byte b3)
        {
            machine.Push(machine.D, machine.E);
        }

        // 0xd6
        private static void SUI(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Sub(machine.A, b2, false);
        }

        // 0xd7
        private static void RST_2(i8080 machine, byte b2, byte b3)
        {
            RST(machine, RST_TARGETS.RST_2);
        }

        // 0xd8
        private static void RC(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.C) != 0)
            {
                machine.PC = machine.Pop();
                }
            }

        // 0xd9 -> RET

        // 0xda
        private static void JC(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.C) != 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                machine.PC = address;
                }
            }

        // 0xdb
        private static void IN(i8080 machine, byte b2, byte b3)
        {
            if (machine.HasConsole)
            {
                byte operation = machine.C;

                // print a character stored in E
                if (operation == 2)
                {
                    machine.nextLine += (char)machine.E;
                    if ((char)machine.E == '\n')
                    {
                        machine.Console.Add(machine.nextLine.Replace("\n\r", "\r\n"));
                        machine.nextLine = string.Empty;
                    }
                }
                // print from memory at (DE) until '$' char
                else if (operation == 9)
                {
                    ushort address = (ushort)((machine.D << 8) + machine.E);
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

                machine.A = 0xFF;
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
                        a = machine.PORT_IN_1;
                        break;
                    case 2:
                        a = (byte)((machine.PORT_IN_2 & 0x8f) | (machine.PORT_IN_1 & 0x70));
                        break;
                    case 3:
                        ushort v = (ushort)((machine.SHIFT_MSB << 8) | machine.SHIFT_LSB);
                        a = (byte)((v >> (8 - machine.SHIFT_OFFSET)) & 0xff);
                        break;
                }
                machine.A = a;
            }
        }

        // 0xdc
        private static void CC(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.C) != 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                ushort ret = machine.PC;
                machine.Push((byte)(ret >> 8), (byte)(ret & 0xff));
                machine.PC = address;
                }
            }

        // 0xdd -> CALL

        // 0xde
        private static void SBI(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.Sub(machine.A, b2, (machine.F & (ushort)i8080.Flags.C) != 0);
        }

        // 0xdf
        private static void RST_3(i8080 machine, byte b2, byte b3)
        {
            RST(machine, RST_TARGETS.RST_3);
        }

        // 0xe0
        private static void RPO(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.P) == 0)
            {
                machine.PC = machine.Pop();
                }
            }

        // 0xe1
        private static void POP_H(i8080 machine, byte b2, byte b3)
        {
            ushort value = machine.Pop();
            machine.L = (byte)(value & 0x00ff);
            machine.H = (byte)(value >> 8);
        }

        // 0xe2
        private static void JPO(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.P) == 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                machine.PC = address;
                }
            }

        // 0xe3
        private static void XTHL(i8080 machine, byte b2, byte b3)
        {
            byte h = machine.H;
            byte l = machine.L;
            machine.L = machine.RAM[machine.SP];
            machine.H = machine.RAM[machine.SP + 1];
            machine.WriteMem(machine.SP, l);
            machine.WriteMem((ushort)(machine.SP + 1), h);
        }

        // 0xe4
        private static void CPO(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.P) == 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                ushort ret = machine.PC;
                machine.Push((byte)(ret >> 8), (byte)(ret & 0xff));
                machine.PC = address;
            }
        }

        // 0xe5
        private static void PUSH_H(i8080 machine, byte b2, byte b3)
        {
            machine.Push(machine.H, machine.L);
        }

        // 0xe6
        internal static void ANI(i8080 machine, byte b2, byte b3)
        {
            machine.A = machine.And(b2);
        }

        // 0xe7
        private static void RST_4(i8080 machine, byte b2, byte b3)
        {
            RST(machine, RST_TARGETS.RST_4);
        }

        // 0xe8
        private static void RPE(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.P) != 0)
            {
                machine.PC = machine.Pop();
                }
            }

        // 0xe9
        private static void PCHL(i8080 machine, byte b2, byte b3)
        {
            machine.PC = (ushort)((machine.H << 8) + machine.L);
            }

        // 0xea
        private static void JPE(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.P) != 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                machine.PC = address; 
                }
            }

        // 0xeb
        internal static void XCHG(i8080 machine, byte b2, byte b3)
        {
            byte h = machine.D;
            byte l = machine.E;
            machine.D = machine.H;
            machine.E = machine.L;
            machine.H = h;
            machine.L = l;
        }

        // 0xec
        private static void CPE(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.P) != 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                ushort ret = machine.PC;
                machine.Push((byte)(ret >> 8), (byte)(ret & 0xff));
                machine.PC = address;
                }
            }

        // 0xed -> CALL

        // 0xee
        private static void XRI(i8080 machine, byte b2, byte b3)
        {
            machine.A = (byte)(machine.A ^ b2);
            machine.LogicFlags();
        }

        // 0xef
        private static void RST_5(i8080 machine, byte b2, byte b3)
        {
            RST(machine, RST_TARGETS.RST_5);
        }

        // 0xf0
        private static void RP(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.S) == 0)
            {
                machine.PC = machine.Pop();
                }
            }

        // 0xf1
        private static void POP_PSW(i8080 machine, byte b2, byte b3)
        {
            ushort value = machine.Pop();
            machine.F = (byte)(value & 0x00ff);

            machine.F = (byte)(machine.F | 2); // Bit 2 always 1
            machine.F &= 0xD7;                 // Bits 4 and 6 always 0
            machine.A = (byte)(value >> 8);
        }

        // 0xf2
        private static void JP(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.S) == 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                machine.PC = address;
            }
        }

        // 0xf3
        private static void DI(i8080 machine, byte b2, byte b3)
        {
            machine.InterruptsEnabled = false;
        }

        // 0xf4
        private static void CP(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.S) == 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                ushort ret = machine.PC;
                machine.Push((byte)(ret >> 8), (byte)(ret & 0xff));
                machine.PC = address;
                }
            }

        // 0xf5
        private static void PUSH_PSW(i8080 machine, byte b2, byte b3)
        {
            machine.Push(machine.A, machine.F);
        }

        // 0xf6
        private static void ORI(i8080 machine, byte b2, byte b3)
        {
            machine.A = (byte)(machine.A | b2);
            machine.FlagsZSP(machine.A);
            machine.ClearFlag(i8080.Flags.C);
            machine.ClearFlag(i8080.Flags.A);
        }

        // 0xf7
        private static void RST_6(i8080 machine, byte b2, byte b3)
        {
            RST(machine, RST_TARGETS.RST_6);
        }

        // 0xf8
        private static void RM(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.S) != 0)
            {
                machine.PC = machine.Pop();
                }
            }

        // 0xf9
        private static void SPHL(i8080 machine, byte b2, byte b3)
        {
            machine.SP = (ushort)((machine.H << 8) + machine.L);
        }

        // 0xfa
        private static void JM(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.S) != 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                machine.PC = address;
                }
            }

        // 0xfb
        private static void EI(i8080 machine, byte b2, byte b3)
        {
            machine.InterruptsEnabled = true;
            //machine.interrupt_delay = 1;
        }

        // 0xfc
        private static void CM(i8080 machine, byte b2, byte b3)
        {
            if ((machine.F & (byte)i8080.Flags.S) != 0)
            {
                ushort address = (ushort)((b3 << 8) + b2);
                ushort ret = machine.PC;
                machine.Push((byte)(ret >> 8), (byte)(ret & 0xff));
                machine.PC = address;
                }
            }

        // 0xfd -> CALL

        // 0xfe
        private static void CPI(i8080 machine, byte b2, byte b3)
        {
            machine.Compare(b2);
        }

        // 0xff
        private static void RST_7(i8080 machine, byte b2, byte b3)
        {
            RST(machine, RST_TARGETS.RST_7);
        }

    }
}

