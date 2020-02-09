using SLeighT80.Processors.i8080;
using System.IO;


namespace SLeighT80.Machines.Invaders
{
    // All these values came directly from the  MAME source code
    static class Loader
    {
        internal static void LoadSpaceInvaders(i8080 machine)
        {
            machine.Reset(0xf000);
            machine.HasConsole = false;

            File.ReadAllBytes(@"C:\Games\8080\invaders\invaders.h").CopyTo(machine.RAM, 0x0000);
            File.ReadAllBytes(@"C:\Games\8080\invaders\invaders.g").CopyTo(machine.RAM, 0x0800);
            File.ReadAllBytes(@"C:\Games\8080\invaders\invaders.f").CopyTo(machine.RAM, 0x1000);
            File.ReadAllBytes(@"C:\Games\8080\invaders\invaders.e").CopyTo(machine.RAM, 0x1800);
        }

        internal static void LoadBalloonWars(i8080 machine)
        {
            machine.Reset(0xf000);
            machine.HasConsole = false;

            File.ReadAllBytes(@"C:\Games\8080\balloon\tn01").CopyTo(machine.RAM, 0x0000);
            File.ReadAllBytes(@"C:\Games\8080\balloon\tn02").CopyTo(machine.RAM, 0x0800);
            File.ReadAllBytes(@"C:\Games\8080\balloon\tn03").CopyTo(machine.RAM, 0x1000);
            File.ReadAllBytes(@"C:\Games\8080\balloon\tn04").CopyTo(machine.RAM, 0x1800);
            File.ReadAllBytes(@"C:\Games\8080\balloon\tn05-1").CopyTo(machine.RAM, 0x4000);
        }

        internal static void LoadCosmo(i8080 machine)
        {
            machine.Reset(0xf000);
            machine.HasConsole = false;

            File.ReadAllBytes(@"C:\Games\8080\cosmo\1.36").CopyTo(machine.RAM, 0x0000);
            File.ReadAllBytes(@"C:\Games\8080\cosmo\2.35").CopyTo(machine.RAM, 0x0800);
            File.ReadAllBytes(@"C:\Games\8080\cosmo\3.34").CopyTo(machine.RAM, 0x1000);
            File.ReadAllBytes(@"C:\Games\8080\cosmo\4.33").CopyTo(machine.RAM, 0x1800);
            File.ReadAllBytes(@"C:\Games\8080\cosmo\5.32").CopyTo(machine.RAM, 0x4000);
            File.ReadAllBytes(@"C:\Games\8080\cosmo\6.31").CopyTo(machine.RAM, 0x4800);
            File.ReadAllBytes(@"C:\Games\8080\cosmo\7.42").CopyTo(machine.RAM, 0x5000);
        }

        internal static void LoadGalaxyWars(i8080 machine)
        {
            machine.Reset(0xf000);
            machine.HasConsole = false;

            //File.ReadAllBytes(@"C:\Games\8080\galxwarst\galxwars.0").CopyTo(machine.RAM, 0x0000);
            //File.ReadAllBytes(@"C:\Games\8080\galxwarst\galxwars.1").CopyTo(machine.RAM, 0x0400);
            //File.ReadAllBytes(@"C:\Games\8080\galxwarst\galxwars.2").CopyTo(machine.RAM, 0x0800);
            //File.ReadAllBytes(@"C:\Games\8080\galxwarst\galxwars.3").CopyTo(machine.RAM, 0x0c00);
            //File.ReadAllBytes(@"C:\Games\8080\galxwarst\galxwars.4").CopyTo(machine.RAM, 0x4000);
            //File.ReadAllBytes(@"C:\Games\8080\galxwarst\galxwars.5").CopyTo(machine.RAM, 0x4400);


            File.ReadAllBytes(@"C:\Games\8080\gunchamp\251.a1").CopyTo(machine.RAM, 0x0000);
            File.ReadAllBytes(@"C:\Games\8080\gunchamp\252.a2").CopyTo(machine.RAM, 0x0400);
            File.ReadAllBytes(@"C:\Games\8080\gunchamp\253.a4").CopyTo(machine.RAM, 0x0800);
            File.ReadAllBytes(@"C:\Games\8080\gunchamp\254.a5").CopyTo(machine.RAM, 0x0c00);
            File.ReadAllBytes(@"C:\Games\8080\gunchamp\255.a6").CopyTo(machine.RAM, 0x1000);
            File.ReadAllBytes(@"C:\Games\8080\gunchamp\256.a8").CopyTo(machine.RAM, 0x1400);
            File.ReadAllBytes(@"C:\Games\8080\gunchamp\257.a9").CopyTo(machine.RAM, 0x1800);
            File.ReadAllBytes(@"C:\Games\8080\gunchamp\258.a10").CopyTo(machine.RAM, 0x1c00);

            //File.ReadAllBytes(@"C:\Games\8080\vortex\1.t36").CopyTo(machine.RAM, 0x0000);
            //File.ReadAllBytes(@"C:\Games\8080\vortex\2.t35").CopyTo(machine.RAM, 0x0800);
            //File.ReadAllBytes(@"C:\Games\8080\vortex\3.t34").CopyTo(machine.RAM, 0x1000);
            //File.ReadAllBytes(@"C:\Games\8080\vortex\4.t33").CopyTo(machine.RAM, 0x1800);
            //File.ReadAllBytes(@"C:\Games\8080\vortex\5.t32").CopyTo(machine.RAM, 0x4000);
            //File.ReadAllBytes(@"C:\Games\8080\vortex\6.t31").CopyTo(machine.RAM, 0x4800);



            //File.ReadAllBytes(@"C:\Games\8080\polaris\ps01-1.30").CopyTo(machine.RAM, 0x0000);
            //File.ReadAllBytes(@"C:\Games\8080\polaris\ps09.36").CopyTo(machine.RAM,   0x0800);
            //File.ReadAllBytes(@"C:\Games\8080\polaris\ps03-1.31").CopyTo(machine.RAM, 0x1000);
            //File.ReadAllBytes(@"C:\Games\8080\polaris\ps04.37").CopyTo(machine.RAM,   0x1800);
            //File.ReadAllBytes(@"C:\Games\8080\polaris\ps05.32").CopyTo(machine.RAM,   0x4000);
            //File.ReadAllBytes(@"C:\Games\8080\polaris\ps10.38").CopyTo(machine.RAM,   0x4800);
            //File.ReadAllBytes(@"C:\Games\8080\polaris\ps26").CopyTo(machine.RAM, 0x5000);





            //File.ReadAllBytes(@"C:\Games\8080\astropal\2708.0a").CopyTo(machine.RAM, 0x0000);
            //File.ReadAllBytes(@"C:\Games\8080\astropal\2708.1a").CopyTo(machine.RAM, 0x0400);
            //File.ReadAllBytes(@"C:\Games\8080\astropal\2708.2a").CopyTo(machine.RAM, 0x0800);
            //File.ReadAllBytes(@"C:\Games\8080\astropal\2708.3a").CopyTo(machine.RAM, 0x0c00);
            //File.ReadAllBytes(@"C:\Games\8080\astropal\2708.4a").CopyTo(machine.RAM, 0x1000);
            //File.ReadAllBytes(@"C:\Games\8080\astropal\2708.5a").CopyTo(machine.RAM, 0x1400);
            //File.ReadAllBytes(@"C:\Games\8080\astropal\2708.6a").CopyTo(machine.RAM, 0x1800);
            //File.ReadAllBytes(@"C:\Games\8080\astropal\2708.7a").CopyTo(machine.RAM, 0x1c00);


            //File.ReadAllBytes(@"C:\Games\8080\steelwkr\1.36").CopyTo(machine.RAM, 0x0000);
            //File.ReadAllBytes(@"C:\Games\8080\steelwkr\2.35").CopyTo(machine.RAM, 0x0400);
            //File.ReadAllBytes(@"C:\Games\8080\steelwkr\3.34").CopyTo(machine.RAM, 0x0800);
            //File.ReadAllBytes(@"C:\Games\8080\steelwkr\4.33").CopyTo(machine.RAM, 0x0c00);
            //File.ReadAllBytes(@"C:\Games\8080\steelwkr\5.32").CopyTo(machine.RAM, 0x1000);
            //File.ReadAllBytes(@"C:\Games\8080\steelwkr\6.31").CopyTo(machine.RAM, 0x1400);
            //File.ReadAllBytes(@"C:\Games\8080\steelwkr\7.42").CopyTo(machine.RAM, 0x1800);
            //File.ReadAllBytes(@"C:\Games\8080\steelwkr\8.41").CopyTo(machine.RAM, 0x1c00);
        }

        internal static void LoadLunarRescue(i8080 machine)
        {
            machine.Reset(0xf000);
            machine.HasConsole = false;

            File.ReadAllBytes(@"C:\Games\8080\lrescue\lrescue.1").CopyTo(machine.RAM, 0x0000);
            File.ReadAllBytes(@"C:\Games\8080\lrescue\lrescue.2").CopyTo(machine.RAM, 0x0800);
            File.ReadAllBytes(@"C:\Games\8080\lrescue\lrescue.3").CopyTo(machine.RAM, 0x1000);
            File.ReadAllBytes(@"C:\Games\8080\lrescue\lrescue.4").CopyTo(machine.RAM, 0x1800);
            File.ReadAllBytes(@"C:\Games\8080\lrescue\lrescue.5").CopyTo(machine.RAM, 0x4000);
            File.ReadAllBytes(@"C:\Games\8080\lrescue\lrescue.6").CopyTo(machine.RAM, 0x4800);
        }

        internal static void LoadLupin3(i8080 machine)
        {
            machine.Reset(0xf000);
            machine.HasConsole = false;

            File.ReadAllBytes(@"C:\Games\8080\lupin3a\lp12.bin").CopyTo(machine.RAM, 0x0000);
            File.ReadAllBytes(@"C:\Games\8080\lupin3a\lp13.bin").CopyTo(machine.RAM, 0x0800);
            File.ReadAllBytes(@"C:\Games\8080\lupin3a\lp14.bin").CopyTo(machine.RAM, 0x1000);
            File.ReadAllBytes(@"C:\Games\8080\lupin3a\lp15.bin").CopyTo(machine.RAM, 0x1800);
            File.ReadAllBytes(@"C:\Games\8080\lupin3a\lp16.bin").CopyTo(machine.RAM, 0x4000);
            File.ReadAllBytes(@"C:\Games\8080\lupin3a\lp17.bin").CopyTo(machine.RAM, 0x4800);
            File.ReadAllBytes(@"C:\Games\8080\lupin3a\lp18.bin").CopyTo(machine.RAM, 0x5000);
        }

        internal static void LoadSpaceChaser(i8080 machine)
        {
            machine.Reset(0xf000);
            machine.HasConsole = false;

            File.ReadAllBytes(@"C:\Games\8080\schasrcv\1").CopyTo(machine.RAM, 0x0000);
            File.ReadAllBytes(@"C:\Games\8080\schasrcv\2").CopyTo(machine.RAM, 0x0400);
            File.ReadAllBytes(@"C:\Games\8080\schasrcv\3").CopyTo(machine.RAM, 0x0800);
            File.ReadAllBytes(@"C:\Games\8080\schasrcv\4").CopyTo(machine.RAM, 0x0c00);
            File.ReadAllBytes(@"C:\Games\8080\schasrcv\5").CopyTo(machine.RAM, 0x1000);
            File.ReadAllBytes(@"C:\Games\8080\schasrcv\6").CopyTo(machine.RAM, 0x1400);
            File.ReadAllBytes(@"C:\Games\8080\schasrcv\7").CopyTo(machine.RAM, 0x1800);
            File.ReadAllBytes(@"C:\Games\8080\schasrcv\8").CopyTo(machine.RAM, 0x1c00);
            File.ReadAllBytes(@"C:\Games\8080\schasrcv\9").CopyTo(machine.RAM, 0x4000);
            File.ReadAllBytes(@"C:\Games\8080\schasrcv\10").CopyTo(machine.RAM, 0x4400);

            //File.ReadAllBytes(@"C:\Games\8080\schaser\rt13.bin").CopyTo(machine.RAM, 0x0000);
            //File.ReadAllBytes(@"C:\Games\8080\schaser\rt14.bin").CopyTo(machine.RAM, 0x0400);
            //File.ReadAllBytes(@"C:\Games\8080\schaser\rt15.bin").CopyTo(machine.RAM, 0x0800);
            //File.ReadAllBytes(@"C:\Games\8080\schaser\rt16.bin").CopyTo(machine.RAM, 0x0c00);
            //File.ReadAllBytes(@"C:\Games\8080\schaser\rt17.bin").CopyTo(machine.RAM, 0x1000);
            //File.ReadAllBytes(@"C:\Games\8080\schaser\rt18.bin").CopyTo(machine.RAM, 0x1400);
            //File.ReadAllBytes(@"C:\Games\8080\schaser\rt19.bin").CopyTo(machine.RAM, 0x1800);
            //File.ReadAllBytes(@"C:\Games\8080\schaser\rt20.bin").CopyTo(machine.RAM, 0x1c00);
            //File.ReadAllBytes(@"C:\Games\8080\schaser\rt21.bin").CopyTo(machine.RAM, 0x4000);
            //File.ReadAllBytes(@"C:\Games\8080\schaser\rt22.bin").CopyTo(machine.RAM, 0x4400);
        }

        internal static void LoadOsmaWars(i8080 machine)
        {
            machine.Reset(0xf000);
            machine.HasConsole = false;

            File.ReadAllBytes(@"C:\Games\8080\ozmawars\mw01").CopyTo(machine.RAM, 0x0000);
            File.ReadAllBytes(@"C:\Games\8080\ozmawars\mw02").CopyTo(machine.RAM, 0x0800);
            File.ReadAllBytes(@"C:\Games\8080\ozmawars\mw03").CopyTo(machine.RAM, 0x1000);
            File.ReadAllBytes(@"C:\Games\8080\ozmawars\mw04").CopyTo(machine.RAM, 0x1800);
            File.ReadAllBytes(@"C:\Games\8080\ozmawars\mw05").CopyTo(machine.RAM, 0x4000);
            File.ReadAllBytes(@"C:\Games\8080\ozmawars\mw06").CopyTo(machine.RAM, 0x4800);
        }
        internal static void LoadIndianBattle(i8080 machine)
        {
            machine.Reset(0xf000);
            machine.HasConsole = false;
            File.ReadAllBytes(@"C:\Games\8080\indianbt\1.36").CopyTo(machine.RAM, 0x0000);
            File.ReadAllBytes(@"C:\Games\8080\indianbt\2.35").CopyTo(machine.RAM, 0x0800);
            File.ReadAllBytes(@"C:\Games\8080\indianbt\3.34").CopyTo(machine.RAM, 0x1000);
            File.ReadAllBytes(@"C:\Games\8080\indianbt\4.33").CopyTo(machine.RAM, 0x1800);
            File.ReadAllBytes(@"C:\Games\8080\indianbt\5.32").CopyTo(machine.RAM, 0x4000);
            File.ReadAllBytes(@"C:\Games\8080\indianbt\6.31").CopyTo(machine.RAM, 0x4800);
            File.ReadAllBytes(@"C:\Games\8080\indianbt\7.42").CopyTo(machine.RAM, 0x5000);
            File.ReadAllBytes(@"C:\Games\8080\indianbt\8.41").CopyTo(machine.RAM, 0x5800);
        }
    }
}
