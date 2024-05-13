// SPEC: https://www.tutorialspoint.com/instruction-type-rrc-in-8085-microprocessor and https://sam.speccy.cz/asm/8080-z80_asm_techniques.pdf
// Test here: https://bluishcoder.co.nz/js8080/ and http://sensi.org/~svo/i8080/
// https://pastraiser.com/cpu/i8080/i8080_opcodes.html
// Data sheet : http://www.classiccmp.org/dunfield/r/8080.txt
// Space Invaders: http://computerarcheology.com/Arcade/SpaceInvaders/Code.html


using Microsoft.VisualBasic.Logging;
using SLeighT80.Machines.Invaders;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
// ReSharper disable IdentifierTypo
// ReSharper disable StringLiteralTypo

// ReSharper disable InconsistentNaming

namespace SLeighT80.Processors.i8080
{
    public class AVRInstructionSet
    {
        Processor machine;
        public void Install(AVR machine)
        {
            this.machine = machine;
            machine.Registers = new byte[32];
            machine.AddInstruction(new Instruction("NOP", 0x00, 1, 4, new byte[0], NOP));

            // Arithmetic and Logic Instructions
            machine.AddInstruction(new Instruction("ADD", 0x01, 3, 1, new byte[0], ADD));
            machine.AddInstruction(new Instruction("ADC", 0x02, 3, 1, new byte[0], ADC));
            // Branch Instructions
            // Data Transfer Instructions
            machine.AddInstruction(new Instruction("LDI", 0x03, 3, 1, new byte[0], LDI));
            // Bit and Bit-test Instructions
            // MCU Control Instructions

        }
        private void NOP(byte b2, byte b3)
        {
        }

        private void ADD(byte b2, byte b3)
        {
        }

        private void ADC(byte b2, byte b3)
        {
        }

        private void LDI(byte b2, byte b3)
        {
            machine.Registers[b2] = b3;
        }
    }
}

