
using System;

namespace SLeighT80.Processors
{
    public class Instruction
    {
        /// <summary>
        /// An instruction that can be executed by a processor
        /// </summary>
        /// <param name="mnemonic"></param>
        /// <param name="opCode"></param>
        /// <param name="length"></param>
        /// <param name="cycles"></param>
        /// <param name="altCycles"></param>
        /// <param name="executionMethod">TODO - Use the base class</param>
        public Instruction(string mnemonic, byte opCode, byte length, byte cycles, byte altCycles, Action<i8080.i8080, byte, byte> executionMethod = null)
        {
            Mnemonic = mnemonic;
            OpCode = opCode;
            Length = length;
            Cycles = cycles;
            AltCycles = altCycles;
            ExecutionMethod = executionMethod;
        }

        /// <summary>
        /// Executes the instruction
        /// </summary>
        /// <param name="machine"></param>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        public void Execute(i8080.i8080 machine, byte b1, byte b2)
        {
            ExecutionMethod?.Invoke(machine, b1, b2);
        }

        // A text based name for the instruction
        public string Mnemonic;

        // The instructions operation code
        public byte OpCode;

        // The number of bytes the instruction requires to execute
        public byte Length;

        // The number of cycles this would require on the original hard wars
        public int Cycles;

        // An alternate number of cycles
        public int AltCycles;

        // The method to call when the instruction needs to be executed
        internal Action<i8080.i8080, byte, byte> ExecutionMethod;
    }
}
