using System;
using System.Collections.Generic;

namespace SLeighT80.Processors
{
    public class Processor
    {
        // Is this thing on?
        internal bool On = false;

        // Is this thing on?
        internal bool MemoryProtection = false;

        // Interrupts will only be processed when true, set / cleared by EI and DI
        internal bool InterruptsEnabled = false;

        // 2 instructions will complete after an interupt triggered.
        internal int InterruptDelay = 0;

        // The number of instructions that have been executed
        internal UInt64 NumberOfExecutedInstructions;

        // The total number of clock cycles that have been accumulated
        internal UInt64 Cycles = 0;

        // Instruction lookup tables (By OpCode) handy for debugging and writing assemblers only
        internal Dictionary<int, Instruction> InstructionSet = new Dictionary<int, Instruction>();

        // Instruction lookup tables (By Mnemonic) handy for debugging and writing assemblers only
        internal Dictionary<string, Instruction> InstructionOpCodes = new Dictionary<string, Instruction>();

        // Optimized op codes
        internal bool[] Codes = new bool[256];

        // Internal string
        internal List<string> Console = new List<string>();

        internal static bool[] ParityLookUp = new bool[256];

        protected static Instruction[] OpCodes;

        // Random access memory
        internal byte[] RAM;

        // Program counter
        internal ushort PC;

        // Set to true once an interrupt is triggered
        internal bool InterruptPending;

        // The operation that will be executed when the next interrupt is triggered
        internal byte InterruptOperation;


        /// <summary>
        /// Will create an array the can be directly addressed via op-code
        /// </summary>
        public void Optimize()
        {
            OpCodes = new Instruction[InstructionSet.Count];
            foreach (var v in InstructionSet)
            {
                OpCodes[v.Key] = v.Value;
            }
        }

        /// <summary>
        /// Adds a new instruction to the processor
        /// </summary>
        /// <param name="instruction"></param>
        public void AddInstruction(Instruction instruction)
        {
            InstructionSet.Add(instruction.OpCode, instruction);
            if (!InstructionOpCodes.ContainsKey(instruction.Mnemonic))
            {
                InstructionOpCodes.Add(instruction.Mnemonic, instruction);
            }
        }
    }
}
