using System.Collections.Generic;
using System.Text;

namespace SLeighT80.Processors
{
    static class Disassembler
    {
        /// <summary>
        /// Turns machine code in assembly language
        /// </summary>
        /// <param name="codebuffer"></param>
        /// <param name="instructionSet"></param>
        /// <param name="Mnumonic"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public static string Disassemble(byte[] codebuffer, Dictionary<int, Instruction> instructionSet, bool Mnumonic = true, int offset = 0)
        {
            StringBuilder sb = new StringBuilder();

            int IP = 0;

            while (IP < codebuffer.Length)
            {
                byte code = codebuffer[IP];
                sb.AppendFormat("{0:X4} ", IP + offset);
                Instruction instruction;
                if (instructionSet.TryGetValue(code, out instruction))
                {
                    if (Mnumonic)
                    {
                        sb.AppendFormat(instruction.Mnemonic);
                    }
                    else
                    {
                        sb.AppendFormat("\t{0:X2}", instruction.OpCode);
                    }
                    if (instruction.Length > 1)
                    {
                        if (IP + 1 < codebuffer.Length)
                        {
                            sb.AppendFormat("\t{0:X2}", codebuffer[IP + 1]);
                        }
                    }
                    if (instruction.Length > 2)
                    {
                        if (IP + 2 < codebuffer.Length)
                        {
                            sb.AppendFormat("\t{0:X2}", codebuffer[IP + 2]);
                        }
                    }
                    IP += instruction.Length;
                }
                else
                {
                    sb.AppendFormat("Unknown instruction: {0:X2}", code);
                    break;
                }
                sb.Append("\r\n");
            }
            return sb.ToString();
        }
    }
}
