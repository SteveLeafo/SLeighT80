using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace SLeighT80.Machines.Invaders
{
    class ColourMap
    {
        // This is the active color map - null if there is no color map file
        static public byte[] ActiveColorMap;

        // Look up table of file names
        public static Dictionary<string, List<KeyValuePair<string, int>>> ColorMaps = new Dictionary<string, List<KeyValuePair<string, int>>>();

        /// <summary>
        /// Loads the color map from file to memory.
        /// </summary>
        /// <param name="fileName"></param>
        public static void SetColorMap(string fileName)
        {
            List<KeyValuePair<string, int>> data;
            ActiveColorMap = null;

            if (ColorMaps.TryGetValue(Path.GetFileName(fileName), out data))
            {
                //color_map = File.ReadAllBytes("C:\\games\\sleight80\\lrescue\\7643-1.cpu");
                using (var file = File.OpenRead(fileName))
                using (var zip = new ZipArchive(file, ZipArchiveMode.Read))
                {
                    foreach (var f in data)
                    {
                        ZipArchiveEntry entry = zip.Entries.FirstOrDefault(a => a.Name == f.Key);
                        if (entry != null)
                        {
                            using (var stream = entry.Open())
                            {
                                using (var memoryStream = new MemoryStream())
                                {
                                    stream.CopyTo(memoryStream);
                                    ActiveColorMap = new byte[memoryStream.Length];
                                    memoryStream.ToArray().CopyTo(ActiveColorMap, f.Value);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Returns the color
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public static Color GetColor(int pos)
        {
            if (ActiveColorMap.Length == 256)
            {
                pos /= 4;
            }

            switch (ActiveColorMap[pos])
            {
                case 0x00: return Color.HotPink;
                case 0x01: return Color.FromArgb(255, 0, 0);
                case 0x02: return Color.FromArgb(0, 255, 0);
                case 0x03: return Color.Violet;
                case 0x04: return Color.FromArgb(255, 0, 0);
                case 0x05: return Color.Yellow;
                case 0x06: return Color.Cyan;
                case 0x07: return Color.White;
                case 0x08: return Color.Pink;
                case 0x09: return Color.FromArgb(255, 0, 0);
                case 0x0a: return Color.HotPink;
                case 0x0b: return Color.Magenta;
                case 0x0c: return Color.FromArgb(0, 255, 0);
                case 0x0d: return Color.Yellow;
                case 0x0e: return Color.Cyan;
                case 0x0f: return Color.White;
            }
            return Color.White;
        }

        /// <summary>
        /// Generated from mame file
        /// </summary>
        internal static void UpdateSupportedColorMaps()
        {
            ColorMaps.Add("sicv.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("cv01.1", 0x0000),
                new KeyValuePair<string, int>("cv02.2", 0x0400)
            }));

            ColorMaps.Add("sicv1.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("cv01.1", 0x0000),
                new KeyValuePair<string, int>("cv02.2", 0x0400)
            }));

            ColorMaps.Add("spacerng.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("cv01.1", 0x0000),
                new KeyValuePair<string, int>("cv02.2", 0x0400)
            }));

            ColorMaps.Add("spcewarla.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("cv01_1.bin", 0x0000),
                new KeyValuePair<string, int>("cv02_2.bin", 0x0400)
            }));

            ColorMaps.Add("invadernc.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("82s137_1.ic17", 0x0000),
                new KeyValuePair<string, int>("82s137_2.ic17", 0x0000)
            }));

            ColorMaps.Add("invadpt2.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("pv06.1", 0x0000),
                new KeyValuePair<string, int>("pv07.2", 0x0400)
            }));

            ColorMaps.Add("invadpt2br.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("pv06.1", 0x0000),
                new KeyValuePair<string, int>("pv07.2", 0x0400)
            }));

            ColorMaps.Add("moonbase.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("cv02.h7", 0x0400),
                new KeyValuePair<string, int>("cv01.g7", 0x0000)
            }));

            ColorMaps.Add("moonbasea.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("cv02.h7", 0x0400),
                new KeyValuePair<string, int>("cv01.g7", 0x0000)
            }));

            ColorMaps.Add("invrvnge.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("colour.bin", 0x0000)
            }));

            ColorMaps.Add("invrvngea.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("colour.bin", 0x0000)
            }));

            ColorMaps.Add("invrvngeb.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("colour.bin", 0x0000)
            }));

            ColorMaps.Add("invrvngedu.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("ir.3r", 0x0000)
            }));

            ColorMaps.Add("invrvngegw.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("ir.3r", 0x0000)
            }));

            ColorMaps.Add("spclaser.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("01.1", 0x0000),
                new KeyValuePair<string, int>("02.2", 0x0400)
            }));

            ColorMaps.Add("intruder.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("01.1", 0x0000),
                new KeyValuePair<string, int>("02.2", 0x0400)
            }));

            ColorMaps.Add("laser.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("01.1", 0x0000),
                new KeyValuePair<string, int>("02.2", 0x0400)
            }));

            ColorMaps.Add("spcewarl.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("01.1", 0x0000),
                new KeyValuePair<string, int>("02.2", 0x0400)
            }));

            ColorMaps.Add("galxwars.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("01.1", 0x0000),
                new KeyValuePair<string, int>("02.2", 0x0400)
            }));

            ColorMaps.Add("galxwars2.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("01.1", 0x0000),
                new KeyValuePair<string, int>("02.2", 0x0400)
            }));

            ColorMaps.Add("galxwarst.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("01.1", 0x0000),
                new KeyValuePair<string, int>("02.2", 0x0400)
            }));

            ColorMaps.Add("galxwarst2.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("01.1", 0x0000),
                new KeyValuePair<string, int>("02.2", 0x0400)
            }));

            ColorMaps.Add("starw1.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("cv01", 0x0000),
                new KeyValuePair<string, int>("cv02", 0x0400)
            }));

            ColorMaps.Add("lrescue.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("7643-1.cpu", 0x0000)
            }));

            ColorMaps.Add("mlander.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("01.bin", 0x0000),
                new KeyValuePair<string, int>("02.bin", 0x0400)
            }));

            ColorMaps.Add("grescue.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("7643-1.cpu", 0x0000)
            }));

            ColorMaps.Add("desterth.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("7643-1.cpu", 0x0000)
            }));

            ColorMaps.Add("lrescuem.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("cv01-7643.2c", 0x0000),
                new KeyValuePair<string, int>("cv02-7643.1c", 0x0400)
            }));

            ColorMaps.Add("lrescuem2.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("cv01-7643.2c", 0x0000),
                new KeyValuePair<string, int>("cv02-7643.1c", 0x0400)
            }));

            ColorMaps.Add("cosmo.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("n-1.7d", 0x0800),
                new KeyValuePair<string, int>("n-2.6e", 0x0000)
            }));

            ColorMaps.Add("schaser.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("rt06.ic2", 0x0000)
            }));

            ColorMaps.Add("schasera.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("rt06.ic2", 0x0000)
            }));

            ColorMaps.Add("schaserb.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("rt06.ic2", 0x0000)
            }));

            ColorMaps.Add("schaserm.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("rt06.ic2", 0x0000)
            }));

            ColorMaps.Add("crashrd.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("rt06.ic2", 0x0000)
            }));

            ColorMaps.Add("schasercv.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("cv01", 0x0000),
                new KeyValuePair<string, int>("cv02", 0x0400)
            }));

            ColorMaps.Add("schaserc.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("rt06.ic2", 0x0000)
            }));

            ColorMaps.Add("lupin3.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("lp08.1", 0x0000),
                new KeyValuePair<string, int>("lp09.2", 0x0400)
            }));

            ColorMaps.Add("polaris.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("ps08.1b", 0x0000)
            }));

            ColorMaps.Add("polarisa.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("ps08.1b", 0x0000)
            }));

            ColorMaps.Add("polariso.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("ps08.1b", 0x0000)
            }));

            ColorMaps.Add("polarisbr.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("ps08.1b", 0x0000)
            }));

            ColorMaps.Add("ozmawars.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("01.1", 0x0000),
                new KeyValuePair<string, int>("02.2", 0x0400)
            }));

            ColorMaps.Add("ozmawars2.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("01.1", 0x0000),
                new KeyValuePair<string, int>("02.2", 0x0400)
            }));

            ColorMaps.Add("ballbomb.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("tn06", 0x0000),
                new KeyValuePair<string, int>("tn07", 0x0400)
            }));

            ColorMaps.Add("indianbt.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("mb7054.1", 0x0000),
                new KeyValuePair<string, int>("mb7054.2", 0x0400)
            }));

            ColorMaps.Add("indianbtbr.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("mb7054.1", 0x0000),
                new KeyValuePair<string, int>("mb7054.2", 0x0400)
            }));

            ColorMaps.Add("shuttlei.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("82s129.2b", 0x0000)
            }));

            ColorMaps.Add("steelwkr.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("la05.1", 0x0000),
                new KeyValuePair<string, int>("la06.2", 0x0400)
            }));
        }
    }
}
