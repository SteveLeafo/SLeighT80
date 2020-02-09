using System;
using System.Collections.Generic;

namespace SLeighT80.Processors
{
    public class Processor
    {
        // Is this thing on?
        internal bool On = false;

        // Interupts will only be processed when true, set / cleared by EI and DI
        internal bool InterruptsEnabled = false;

        // The number of instructions that have been executed
        internal UInt64 NumberOfExecutedInstructions;

        // The total number of clock cycles that have been accumulated
        internal UInt64 Cycles = 0;

        // Instruction lookup tables (By OpCode) handy for debugging and writing assemblers only
        internal Dictionary<int, Instruction> instructionSet = new Dictionary<int, Instruction>();

        // Instruction lookup tables (By Mnumonic) handy for debugging and writing assemblers only
        internal Dictionary<string, Instruction> instructionOpCodes = new Dictionary<string, Instruction>();

        // Internal string
        internal List<string> Console = new List<string>();

        public static bool[] parityLookUp = new bool[256];

        protected static Instruction[] opcodes;

        internal bool[] codes = new bool[256];

        // Random access memory
        internal byte[] RAM;

        // Program counter
        internal ushort PC;

        // Set to true once an interrupt is triggered
        internal bool InterruptPending;

        // The operation that will be executed when the next interrupt is triggered
        internal byte InterrupOperation;


        /// <summary>
        /// Will create an array the can be directly addressed via opcode
        /// </summary>
        public void Optimize()
        {
            opcodes = new Instruction[instructionSet.Count];
            foreach (var v in instructionSet)
            {
                opcodes[v.Key] = v.Value;
            }
        }

        /// <summary>
        /// Adds a new instruction to the processor
        /// </summary>
        /// <param name="instruction"></param>
        public void AddInstruction(Instruction instruction)
        {
            instructionSet.Add(instruction.OpCode, instruction);
            if (!instructionOpCodes.ContainsKey(instruction.Mnemonic))
            {
                instructionOpCodes.Add(instruction.Mnemonic, instruction);
            }
        }
    }
}
