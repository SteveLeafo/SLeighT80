using System.Collections.Generic;

namespace SLeighT80.Machines.Invaders
{
    // All these values came directly from the  MAME source code
    static class Loader
    {
        public static Dictionary<string, List<KeyValuePair<string, int>>> SupportedGames = new Dictionary<string, List<KeyValuePair<string, int>>>();

        internal static void UpdateSupportedGames()
        {
            // Load this from file?
            SupportedGames.Add("balloon.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("tn01", 0x0000),
                new KeyValuePair<string, int>("tn02", 0x0800),
                new KeyValuePair<string, int>("tn03", 0x1000),
                new KeyValuePair<string, int>("tn04", 0x1800),
                new KeyValuePair<string, int>("tn05-1", 0x4000)
            }));

            SupportedGames.Add("cosmo.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("1.36",  0x0000),
                new KeyValuePair<string, int>("2.35",  0x0800),
                new KeyValuePair<string, int>("3.34",  0x1000),
                new KeyValuePair<string, int>("4.33",  0x1800),
                new KeyValuePair<string, int>("5.32",  0x4000),
                new KeyValuePair<string, int>("6.31",  0x4800),
                new KeyValuePair<string, int>("7.42",  0x5000),
            }));

            SupportedGames.Add("galxwarst.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("galxwars.0", 0x0000),
                new KeyValuePair<string, int>("galxwars.1", 0x0400),
                new KeyValuePair<string, int>("galxwars.2", 0x0800),
                new KeyValuePair<string, int>("galxwars.3", 0x0c00),
                new KeyValuePair<string, int>("galxwars.4", 0x4000),
                new KeyValuePair<string, int>("galxwars.5", 0x4400)
            }));

            SupportedGames.Add("indianbt.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("1.36", 0x0000),
                new KeyValuePair<string, int>("2.35", 0x0800),
                new KeyValuePair<string, int>("3.34", 0x1000),
                new KeyValuePair<string, int>("4.33", 0x1800),
                new KeyValuePair<string, int>("5.32", 0x4000),
                new KeyValuePair<string, int>("6.31", 0x4800),
                new KeyValuePair<string, int>("7.42", 0x5000),
                new KeyValuePair<string, int>("8.41", 0x5800),
            }));

            SupportedGames.Add("invaders.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("invaders.h", 0x0000),
                new KeyValuePair<string, int>("invaders.g", 0x0800),
                new KeyValuePair<string, int>("invaders.f", 0x1000),
                new KeyValuePair<string, int>("invaders.e", 0x1800)
            }));

            SupportedGames.Add("lrescue.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("lrescue.1", 0x0000),
                new KeyValuePair<string, int>("lrescue.2", 0x0800),
                new KeyValuePair<string, int>("lrescue.3", 0x1000),
                new KeyValuePair<string, int>("lrescue.4", 0x1800),
                new KeyValuePair<string, int>("lrescue.5", 0x4000),
                new KeyValuePair<string, int>("lrescue.6", 0x4800),
            }));

            SupportedGames.Add("ozmawars.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("mw01", 0x0000),
                new KeyValuePair<string, int>("mw02", 0x0800),
                new KeyValuePair<string, int>("mw03", 0x1000),
                new KeyValuePair<string, int>("mw04", 0x1800),
                new KeyValuePair<string, int>("mw05", 0x4000),
                new KeyValuePair<string, int>("mw06", 0x4800),
            }));

            SupportedGames.Add("phoenix.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("ic45",  0x0000),
                new KeyValuePair<string, int>("ic46",  0x0800),
                new KeyValuePair<string, int>("ic47",  0x1000),
                new KeyValuePair<string, int>("ic48",  0x1800),
                new KeyValuePair<string, int>("ic45",  0x2000),
                new KeyValuePair<string, int>("ic46",  0x2800),
                new KeyValuePair<string, int>("ic47",  0x3000),
                new KeyValuePair<string, int>("ic48",  0x3800),
            }));
        }
    }
}
