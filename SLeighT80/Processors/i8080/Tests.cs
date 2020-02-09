using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLeighT80.Processors.i8080
{ 
    class Tests
    {
        internal static int FailCount;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="machine"></param>
        internal static void Run(i8080 machine)
        {
            FailCount = 0;
            int offset = 0;
            machine.Reset((ushort)(offset == 0 ? 0xf000 : 0));
            machine.SetFlag(i8080.Flags.C);
            machine.A = 0x10;
            machine.SetFlag(i8080.Flags.A);
            i8080InstructionSet.DAA(machine, 0, 0);

            machine.Reset((ushort)(offset == 0 ? 0xf000 : 0));
            machine.C = 0x09;
            i8080InstructionSet.DCR_C(machine, 0, 0);

            machine.Reset((ushort)(offset == 0 ? 0xf000 : 0));
            machine.A = machine.A = 0xf0;
            machine.A = machine.And(0x55);

            machine.Reset((ushort)(offset == 0 ? 0xf000 : 0));
            machine.RAM[0x4050] = 0xbb;
            machine.RAM[0x4051] = 0xaa;
            i8080InstructionSet.LHLD(machine, 0x50, 0x40);
            if (machine.H != 0xaa) Fail();
            if (machine.L != 0xbb) Fail();

            machine.Reset((ushort)(offset == 0 ? 0xf000 : 0));
            machine.A = 0x8b;
            i8080InstructionSet.RRC(machine, 0, 0);
            if (machine.A != 0xc5) Fail();
            if ((machine.F & (byte)i8080.Flags.C) == 0) Fail();

            machine.Reset((ushort)(offset == 0 ? 0xf000 : 0));
            machine.A = 0xa0;
            machine.B = 0x10;
            machine.SetFlag(i8080.Flags.C);
            i8080InstructionSet.ADC_B(machine, 0, 0);
            if (machine.A != 0xb1) Fail();
            if ((machine.F & (byte)i8080.Flags.C) != 0) Fail();
            if ((machine.F & (byte)i8080.Flags.S) == 0) Fail();
            if ((machine.F & (byte)i8080.Flags.P) == 0) Fail();
        }

        /// <summary>
        /// 
        /// </summary>
        static void Fail()
        {
            FailCount++;
        }
    }
}
