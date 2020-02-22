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
        internal byte A;
        internal byte F;
        internal byte B;
        internal byte C;
        internal byte D;
        internal byte E;
        internal byte H;
        internal byte L;

        // Ports
        internal byte PORT_IN_1;
        internal byte PORT_IN_2;

        internal byte PORT_OUT_3;
        internal byte PORT_OUT_5;

        internal byte SHIFT_LSB;
        internal byte SHIFT_MSB;
        internal byte SHIFT_OFFSET;
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

        /// <summary>
        /// 
        /// </summary>
        public i8080()
        {
            RAM = new byte[65536];
            for (int b = 0x00; b <= 0xff; ++b)
            {
                ParityLookUp[b] = Utilities.Parity(b, 8);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void RunNext()
        {
            if (InterruptPending && InterruptsEnabled && InterruptDelay == 0)
            {
                InterruptPending = false;
                InterruptsEnabled = false;
                Instruction instruction = OpCodes[InterruptOperation];

                if (PC < RAM.Length - 2)
                {
                    instruction.Execute(this, RAM[PC + 1], RAM[PC + 2]);
                    Codes[instruction.OpCode] = true;
                    Cycles += (UInt64)instruction.Cycles;
                }
            }
            else
            {
                Execute();
            }
        }

        /// <summary>
        /// 
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
        /// 
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
        /// 
        /// </summary>
        /// <param name="sp"></param>
        public void Reset(ushort sp)
        {
            Array.Clear(RAM, 0, RAM.Length);

            A = 0;
            F = 2;
            B = 0;
            C = 0;
            D = 0;
            E = 0;
            H = 0;
            L = 0;

            Cycles = 0;

            PC = 0;

            SP = sp;

            PORT_IN_1 = 0;
            PORT_IN_2 = 0;
            PORT_OUT_3 = 0;
            PORT_OUT_5 = 0;

            SHIFT_LSB = 0;
            SHIFT_MSB = 0;
            SHIFT_OFFSET = 0;

            InterruptsEnabled = false;
            InterruptOperation = 0;

            NumberOfExecutedInstructions = 0;

            On = true;

            Console.Clear();

            nextLine = string.Empty;

            Machines.Invaders.Sound.StopLoopingSoundFile();
        }


        /// <summary>
        /// 
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

                instruction.Execute(this, b1, b2);

                Cycles  += (UInt64)instruction.Cycles;
            }
            NumberOfExecutedInstructions++;
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
            byte result = (byte)(A & val);
            ClearFlag(Flags.C);

            if ((byte)((A | val) & 0x08) != 0)
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
            FlagsZSP(A);
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
            if ((F & (byte)Flags.C) != 0)
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
            ushort res = (ushort)(A - val);

            if ((res >> 8) != 0)
            {
                SetFlag(Flags.C);
            }
            else
            {
                ClearFlag(Flags.C);
            }

            if ((~(A ^ res ^ val) & 0x10) != 0)
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
            F |= (byte)flag;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="flag"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void ClearFlag(Flags flag)
        {
            F &= (byte)~(byte)flag;
        }
    }
}
