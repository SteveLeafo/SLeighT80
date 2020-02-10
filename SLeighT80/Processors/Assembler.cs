using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace SLeighT80.Processors
{
    static class Assembler
    {
        /// <summary>
        /// Turns assembly language into machine code
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="code"></param>
        /// <param name="instructionOpCodes"></param>
        public static void Assemble(string fileName, string code, Dictionary<string, Instruction> instructionOpCodes)
        {
            Stream stream = null;
            try
            {
                stream = new FileStream("file.txt", FileMode.OpenOrCreate);
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    stream = null;

                    string[] lines = code.Split('\n');

                    foreach (var line in lines)
                    {
                        byte b1 = 0;
                        byte b2 = 0;

                        string[] tokens = line.Split(';');

                        if (tokens.Length > 0)
                        {
                            Instruction instruction;
                            if (instructionOpCodes.TryGetValue(tokens[0], out instruction))
                            {
                                // We have a valid instruction mnemonic
                                if (tokens.Length > 1)
                                {
                                    byte.TryParse(tokens[1].Trim().Replace("0x", ""), NumberStyles.HexNumber, null, out b1);
                                }
                                if (tokens.Length > 2)
                                {
                                    byte.TryParse(tokens[2].Trim().Replace("0x", ""), NumberStyles.HexNumber, null, out b2);
                                }
                            }

                            if (instruction != null)
                            {
                                writer.Write(instruction.OpCode);
                                if (instruction.Length > 1)
                                {
                                    writer.Write(b1);
                                }

                                if (instruction.Length > 2)
                                {
                                    writer.Write(b2);
                                }
                            }
                        }
                    }
                }
            }
            finally
            {
                stream?.Dispose();
            }
        }
    }
}
