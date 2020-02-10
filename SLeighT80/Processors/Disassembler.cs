using System.Collections.Generic;
using System.Text;

namespace SLeighT80.Processors
{
    static class Disassembler
    {
        /// <summary>
        /// Turns machine code in assembly language
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="instructionSet"></param>
        /// <param name="mnemonic"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public static string Disassemble(byte[] buffer, Dictionary<int, Instruction> instructionSet, bool mnemonic = true, int offset = 0)
        {
            StringBuilder sb = new StringBuilder();

            int programCounter = 0;

            while (programCounter < buffer.Length)
            {
                byte code = buffer[programCounter];
                sb.AppendFormat("{0:X4} ", programCounter + offset);
                Instruction instruction;
                if (instructionSet.TryGetValue(code, out instruction))
                {
                    if (mnemonic)
                    {
                        sb.AppendFormat(instruction.Mnemonic);
                    }
                    else
                    {
                        sb.AppendFormat("\t{0:X2}", instruction.OpCode);
                    }
                    if (instruction.Length > 1)
                    {
                        if (programCounter + 1 < buffer.Length)
                        {
                            sb.AppendFormat("\t{0:X2}", buffer[programCounter + 1]);
                        }
                    }
                    if (instruction.Length > 2)
                    {
                        if (programCounter + 2 < buffer.Length)
                        {
                            sb.AppendFormat("\t{0:X2}", buffer[programCounter + 2]);
                        }
                    }
                    programCounter += instruction.Length;
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
