using SharpDX.XInput;
using System;
using System.Runtime.CompilerServices;

namespace SLeighT80.Processors.i8080
{
    public class i8080 : Processor
    {
        // Stack pointer
        internal ushort SP;

        // Registers
        const byte A = 0;
        const byte B = 1;
        const byte C = 2;
        const byte D = 3;
        const byte E = 4;
        const byte F = 5;
        const byte H = 6;
        const byte L = 7;

        // Ports
        byte PORT_IN_1 = 0;
        byte PORT_IN_2 = 1;

        byte PORT_OUT_3 = 2;
        byte PORT_OUT_5 = 3;

        byte SHIFT_LSB = 4;
        byte SHIFT_MSB = 5;
        byte SHIFT_OFFSET = 6;

        internal int ScaleFactor = 3;

        public enum Flags : byte
        {
            C = 0x01,
            P = 0x04,
            A = 0x10,
            Z = 0x40,
            S = 0x80,
        }

        internal enum AccessoryFlagRule
        {
            None,
            Inc,
            Dec,
        };

        internal Controller controller = null;

        internal string nextLine = string.Empty;

        internal bool HasConsole;

        internal bool Painting;

        internal int Frames;

        internal bool Halted;

        /// <summary>
        /// Constructor - requires RAM to be usefull
        /// </summary>
        public i8080(byte[] ram) : base(ram)
        {
            for (int b = 0x00; b <= 0xff; ++b)
            {
                ParityLookUp[b] = Utilities.Parity(b, 8);
            }
        }

        /// <summary>
        /// Runs the next comment
        /// </summary>
        public void RunNext()
        {
            if (Halted)
            {
                if (InterruptPending && InterruptsEnabled && InterruptDelay == 0)
                {
                    Halted = false;
                    ExecuteInterrupt();
                }
                return;
            }

            if (InterruptPending && InterruptsEnabled && InterruptDelay == 0)
            {
                ExecuteInterrupt();
            }
            else
            {
                Execute();
            }
        }


        /// <summary>
        /// Executes the next command and processors the program counter register
        /// </summary>
        private void Execute()
        {
            byte code = RAM[PC++];
            Codes[code] = true;
            Instruction instruction = OpCodes[code];

            if (InterruptDelay > 0)
            {
                InterruptDelay--;
            }

            if (PC < RAM.Length - 2)
            {
                byte b1 = 0, b2 = 0;
                if (instruction.Length > 1)
                {
                    b1 = RAM[PC++];
                }
                if (instruction.Length > 2)
                {
                    b2 = RAM[PC++];
                }

                byte flagsBefore = Registers[F];
                instruction.Execute(b1, b2);

                int cycles = instruction.Cycles;
                if (instruction.AltCycles != null && instruction.AltCycles.Length > 0 && IsConditionalNotTaken(code, flagsBefore))
                {
                    cycles = instruction.AltCycles[0];
                }

                Cycles += (UInt64)cycles;
            }
            NumberOfExecutedInstructions++;
        }

        /// <summary>
        /// Executes the interrupt handler
        /// </summary>
        private void ExecuteInterrupt()
        {
            InterruptPending = false;
            InterruptsEnabled = false;
            Instruction instruction = OpCodes[InterruptOperation];

            if (PC < RAM.Length - 2)
            {
                instruction.Execute(RAM[PC + 1], RAM[PC + 2]);
                Codes[instruction.OpCode] = true;
                Cycles += (UInt64)instruction.Cycles;
            }
        }

        private static bool IsConditionalNotTaken(byte opcode, byte flags)
        {
            switch (opcode)
            {
                case 0xC0: // RNZ
                case 0xC4: // CNZ
                    return (flags & (byte)Flags.Z) != 0;

                case 0xC8: // RZ
                case 0xCC: // CZ
                    return (flags & (byte)Flags.Z) == 0;

                case 0xD0: // RNC
                case 0xD4: // CNC
                    return (flags & (byte)Flags.C) != 0;

                case 0xD8: // RC
                case 0xDC: // CC
                    return (flags & (byte)Flags.C) == 0;

                case 0xE0: // RPO
                case 0xE4: // CPO
                    return (flags & (byte)Flags.P) != 0;

                case 0xE8: // RPE
                case 0xEC: // CPE
                    return (flags & (byte)Flags.P) == 0;

                case 0xF0: // RP
                case 0xF4: // CP
                    return (flags & (byte)Flags.S) != 0;

                case 0xF8: // RM
                case 0xFC: // CM
                    return (flags & (byte)Flags.S) == 0;
            }

            return false;
        }

        /// <summary>
        /// Installs the outout routines
        /// </summary>
        internal void IntallOutputRoutines()
        {
            // inject "out 1,a" at 0x0000 (signal to stop the test)
            RAM[0x0000] = 0xd3; // OUT
            RAM[0x0001] = 0x00;

            // inject "in a,0" at 0x0005 (signal to output some characters)
            RAM[0x0005] = 0xdb; // IN
            RAM[0x0006] = 0x00; // NOP
            RAM[0x0007] = 0xc9; // RET
        }

        /// <summary>
        /// Triggers and interupt and sets the command to run - 2 more commands will execute before the interrupt will run
        /// </summary>
        /// <param name="opcode"></param>
        /// <returns></returns>
        public bool Interupt(byte opcode)
        {
            if (InterruptPending || !InterruptsEnabled)
            {
                return false;
            }

            InterruptPending = true;
            InterruptOperation = opcode;
            InterruptDelay = 2;

            return true;
        }

        /// <summary>
        /// Resets the processor to its default state
        /// </summary>
        /// <param name="sp"></param>
        public void Reset(ushort sp)
        {
            Array.Clear(RAM, 0, RAM.Length);

            Registers[A] = 0;
            Registers[F] = 2;
            Registers[B] = 0;
            Registers[C] = 0;
            Registers[D] = 0;
            Registers[E] = 0;
            Registers[H] = 0;
            Registers[L] = 0;

            Cycles = 0;

            PC = 0;

            SP = sp;

            Ports[PORT_IN_1] = 0;
            Ports[PORT_IN_2] = 0;
            Ports[PORT_OUT_3] = 0;
            Ports[PORT_OUT_5] = 0;

            Ports[SHIFT_LSB] = 0;
            Ports[SHIFT_MSB] = 0;
            Ports[SHIFT_OFFSET] = 0;

            InterruptsEnabled = false;
            InterruptOperation = 0;

            NumberOfExecutedInstructions = 0;

            Halted = false;
            On = true;

            Console.Clear();

            nextLine = string.Empty;

            Machines.Invaders.Sound.StopLoopingSoundFile();
        }



        /// <summary>
        /// Writes a byte of data to memory - adds checks to not overwrite ROM
        /// </summary>
        /// <param name="machine"></param>
        /// <param name="address"></param>
        /// <param name="value"></param>
        internal void WriteMem(ushort address, byte value)
        {
            if (MemoryProtection && (address < 0x2000 || address > 0xFFFF))
            {
                return;
            }

            RAM[address] = value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal ushort Pop()
        {
            byte l = RAM[SP];
            SP++;
            byte h = RAM[SP];
            SP++;
            ushort ret = (ushort)((h << 8) + l);
            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="h"></param>
        /// <param name="l"></param>
        internal void Push(byte h, byte l)
        {
            SP--;
            RAM[SP] = h;
            SP--;
            RAM[SP] = l;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        internal byte And(byte val)
        {
            byte a = Registers[A];
            byte result = (byte)(a & val);
            ClearFlag(Flags.C);

            if ((byte)((a | val) & 0x08) != 0)
            {
                SetFlag(Flags.A);
            }
            else
            {
                ClearFlag(Flags.A);
            }
            FlagsZSP(result);
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        internal void LogicFlags()
        {
            FlagsZSP(Registers[A]);
            ClearFlag(Flags.C);
            ClearFlag(Flags.A);
        }

        /// <summary>
        /// returns if there was a carry between bit "bit_no" and "bit_no - 1" when executing "a + b + cy"
        /// </summary>
        /// <param name="bit_no"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="cy"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal bool Carry(int bit_no, byte a, byte b, byte cy)
        {
            ushort result = (ushort)(a + b + cy);
            ushort carry = (ushort)(result ^ a ^ b);
            return (carry & (1 << bit_no)) != 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="carry"></param>
        /// <returns></returns>
        internal byte Add(byte a, byte b, bool carry)
        {
            byte result = (byte)(a + b + (byte)(carry ? 1 : 0));

            if (Carry(8, a, b, (byte)(carry ? 1 : 0)))
            {
                SetFlag(Flags.C);
            }
            else
            {
                ClearFlag(Flags.C);
            }
            if (Carry(4, a, b, (byte)(carry ? 1 : 0)))
            {
                SetFlag(Flags.A);
            }
            else
            {
                ClearFlag(Flags.A);
            }

            FlagsZSP((byte)(result & 0xff));

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="carry"></param>
        /// <returns></returns>
        internal byte Sub(byte a, byte b, bool carry)
        {
            byte result = Add(a, (byte)~b, !carry);
            if ((Registers[F] & (byte)Flags.C) != 0)
            {
                ClearFlag(Flags.C);
            }
            else
            {
                SetFlag(Flags.C);
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void Compare(ushort val)
        {
            byte a = Registers[A];
            ushort res = (ushort)(a - val);

            if ((res >> 8) != 0)
            {
                SetFlag(Flags.C);
            }
            else
            {
                ClearFlag(Flags.C);
            }

            if ((~(a ^ res ^ val) & 0x10) != 0)
            {
                SetFlag(Flags.A);
            }
            else
            {
                ClearFlag(Flags.A);
            }

            FlagsZSP((byte)(res & 0xff));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="rule"></param>
        internal void FlagsZSP(byte value, AccessoryFlagRule rule = AccessoryFlagRule.None)
        {
            if (value == 0) SetFlag(Flags.Z); else ClearFlag(Flags.Z);
            if (0x80 == (value & 0x80)) SetFlag(Flags.S); else ClearFlag(Flags.S);
            if (ParityLookUp[value]) SetFlag(Flags.P); else ClearFlag(Flags.P);

            if (rule == AccessoryFlagRule.Inc)
            {
                if ((value & 0xF) == 0) SetFlag(Flags.A); else ClearFlag(Flags.A);
            }
            else if (rule == AccessoryFlagRule.Dec)
            {
                if (!((value & 0xF) == 0xF)) SetFlag(Flags.A); else ClearFlag(Flags.A);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="flag"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void SetFlag(Flags flag)
        {
            Registers[F] |= (byte)flag;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="flag"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void ClearFlag(Flags flag)
        {
            Registers[F] &= (byte)~(byte)flag;
        }
    }
}
