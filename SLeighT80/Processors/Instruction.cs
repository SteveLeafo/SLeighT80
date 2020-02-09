
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
        /// <param name="executionMethod"></param>
        public Instruction(string mnemonic, byte opCode, byte length, byte cycles, byte altCycles, Action<i8080.i8080, byte, byte> executionMethod = null)
        {
            Mnemonic = mnemonic;
            OpCode = opCode;
            Length = length;
            Cycles = cycles;
            AltCycles = altCycles;
            m_ExecutionMethod = executionMethod;
        }

        /// <summary>
        /// Execututes the instruction
        /// </summary>
        /// <param name="machine"></param>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        public void Execute(i8080.i8080 machine, byte b1, byte b2)
        {
            m_ExecutionMethod?.Invoke(machine, b1, b2);
        }

        // A text based name for the instruction
        public string Mnemonic = string.Empty;

        // The instructions operation code
        public byte OpCode = 0;

        // The number of bytes the instruction requires to execute
        public byte Length = 0;

        // The numer of cycles this would require on the original hard wars
        public int Cycles = -1;

        // An alternate number of cycles
        public int AltCycles = -1;

        // The method to call when the instruction needs to be executed
        internal Action<i8080.i8080, byte, byte> m_ExecutionMethod;
    }
}
