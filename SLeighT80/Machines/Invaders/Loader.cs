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
            SupportedGames.Add("searthin.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("earthinv.h", 0x0000),
                new KeyValuePair<string, int>("earthinv.g", 0x0800),
                new KeyValuePair<string, int>("earthinv.f", 0x1000),
                new KeyValuePair<string, int>("earthinv.e", 0x1800)
            }));

            SupportedGames.Add("searthina.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("unkh.h1", 0x0000),
                new KeyValuePair<string, int>("unkg.g1", 0x0400),
                new KeyValuePair<string, int>("unkf.f1", 0x0800),
                new KeyValuePair<string, int>("unke.e1", 0x0c00),
                new KeyValuePair<string, int>("unkd.d1", 0x1000),
                new KeyValuePair<string, int>("unkc.c1", 0x1400),
                new KeyValuePair<string, int>("unkb.b1", 0x1800),
                new KeyValuePair<string, int>("unka.a1", 0x1c00)
            }));

            SupportedGames.Add("supinvsion.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("h-am4708.bin", 0x0000),
                new KeyValuePair<string, int>("g-am4708.bin", 0x0400),
                new KeyValuePair<string, int>("f-am4708.bin", 0x0800),
                new KeyValuePair<string, int>("e-am4708.bin", 0x0c00),
                new KeyValuePair<string, int>("d-am4708.bin", 0x1000),
                new KeyValuePair<string, int>("c-am4708.bin", 0x1400),
                new KeyValuePair<string, int>("b-am4708.bin", 0x1800),
                new KeyValuePair<string, int>("a-am4708.bin", 0x1c00)
            }));

            SupportedGames.Add("searthie.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("searthie.h", 0x0000),
                new KeyValuePair<string, int>("searthie.g", 0x0800),
                new KeyValuePair<string, int>("searthie.f", 0x1000),
                new KeyValuePair<string, int>("searthie.e", 0x1800)
            }));

            SupportedGames.Add("invadrmr.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("11.1t", 0x0000),
                new KeyValuePair<string, int>("sv02.1p", 0x0400),
                new KeyValuePair<string, int>("20.1n", 0x0800),
                new KeyValuePair<string, int>("sv04.1j", 0x1400),
                new KeyValuePair<string, int>("13.1h", 0x1800),
                new KeyValuePair<string, int>("sv06.1g", 0x1c00)
            }));

            SupportedGames.Add("claybust.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("0.a1", 0x0000),
                new KeyValuePair<string, int>("1.a2", 0x0400),
                new KeyValuePair<string, int>("2.a4", 0x0800),
                new KeyValuePair<string, int>("3.a5", 0x0c00),
                new KeyValuePair<string, int>("4.a6", 0x1000),
                new KeyValuePair<string, int>("5.a8", 0x1400)
            }));

            SupportedGames.Add("gunchamp.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("251.a1", 0x0000),
                new KeyValuePair<string, int>("252.a2", 0x0400),
                new KeyValuePair<string, int>("253.a4", 0x0800),
                new KeyValuePair<string, int>("254.a5", 0x0c00),
                new KeyValuePair<string, int>("255.a6", 0x1000),
                new KeyValuePair<string, int>("256.a8", 0x1400),
                new KeyValuePair<string, int>("257.a9", 0x1800),
                new KeyValuePair<string, int>("258.a10", 0x1c00)
            }));

            SupportedGames.Add("spaceatt.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("h", 0x0000),
                new KeyValuePair<string, int>("sv02.bin", 0x0400),
                new KeyValuePair<string, int>("f", 0x0800),
                new KeyValuePair<string, int>("c", 0x1400),
                new KeyValuePair<string, int>("b", 0x1800),
                new KeyValuePair<string, int>("a", 0x1c00)
            }));

            SupportedGames.Add("spaceattbp.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("06e.bin", 0x0000),
                new KeyValuePair<string, int>("12l.bin", 0x0000),
                new KeyValuePair<string, int>("05de.bin", 0x0400),
                new KeyValuePair<string, int>("11hl.bin", 0x0400),
                new KeyValuePair<string, int>("04d.bin", 0x0800),
                new KeyValuePair<string, int>("10h.bin", 0x0800),
                new KeyValuePair<string, int>("03b.bin", 0x1400),
                new KeyValuePair<string, int>("09g.bin", 0x1400),
                new KeyValuePair<string, int>("02ab.bin", 0x1800),
                new KeyValuePair<string, int>("08f.bin", 0x1800),
                new KeyValuePair<string, int>("01a.bin", 0x1c00),
                new KeyValuePair<string, int>("07ef.bin", 0x1c00)
            }));

            SupportedGames.Add("spaceatt2k.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("h1.bin", 0x0000),
                new KeyValuePair<string, int>("g1.bin", 0x0800),
                new KeyValuePair<string, int>("f1.bin", 0x1000),
                new KeyValuePair<string, int>("e1.bin", 0x1800)
            }));

            SupportedGames.Add("spaceat2.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("spaceatt.h", 0x0000),
                new KeyValuePair<string, int>("spaceatt.g", 0x0800),
                new KeyValuePair<string, int>("spaceatt.f", 0x1000),
                new KeyValuePair<string, int>("spaceatt.e", 0x1800)
            }));

            SupportedGames.Add("cosmicin.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("cn7472n-7921.bin", 0x0000),
                new KeyValuePair<string, int>("cn7471n-7918.bin", 0x0800),
                new KeyValuePair<string, int>("cn7470n-7918.bin", 0x1000),
                new KeyValuePair<string, int>("cn7469n-7921.bin", 0x1800)
            }));

            SupportedGames.Add("galmonst.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("h.5m", 0x0000),
                new KeyValuePair<string, int>("g.5n", 0x0400),
                new KeyValuePair<string, int>("f.5p", 0x0800),
                new KeyValuePair<string, int>("c.5t", 0x1400),
                new KeyValuePair<string, int>("b.5u", 0x1800),
                new KeyValuePair<string, int>("a.5v", 0x1c00)
            }));

            SupportedGames.Add("spacecom.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("1f.ic67", 0x0000),
                new KeyValuePair<string, int>("2g.ic82", 0x0400),
                new KeyValuePair<string, int>("3f.ic68", 0x0800),
                new KeyValuePair<string, int>("4g.ic83", 0x0c00),
                new KeyValuePair<string, int>("5f.ic69", 0x1000),
                new KeyValuePair<string, int>("6g.ic84", 0x1400),
                new KeyValuePair<string, int>("7f.ic70", 0x1800),
                new KeyValuePair<string, int>("8g.ic85", 0x1c00)
            }));

            SupportedGames.Add("sinvzen.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("1.bin", 0x0000),
                new KeyValuePair<string, int>("2.bin", 0x0400),
                new KeyValuePair<string, int>("3.bin", 0x0800),
                new KeyValuePair<string, int>("4.bin", 0x0c00),
                new KeyValuePair<string, int>("5.bin", 0x1000),
                new KeyValuePair<string, int>("6.bin", 0x1400),
                new KeyValuePair<string, int>("7.bin", 0x1800),
                new KeyValuePair<string, int>("8.bin", 0x1c00)
            }));

            SupportedGames.Add("sinvemag.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("sv01.36", 0x0000),
                new KeyValuePair<string, int>("emag_si.b", 0x0400),
                new KeyValuePair<string, int>("emag_si.c", 0x0800),
                new KeyValuePair<string, int>("emag_si.d", 0x1400),
                new KeyValuePair<string, int>("emag_si.e", 0x1800),
                new KeyValuePair<string, int>("emag_si.f", 0x1c00)
            }));

            SupportedGames.Add("tst_invd.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("test.h", 0x0000),
                new KeyValuePair<string, int>("invaders.g", 0x0800),
                new KeyValuePair<string, int>("invaders.f", 0x1000),
                new KeyValuePair<string, int>("invaders.e", 0x1800)
            }));

            SupportedGames.Add("alieninv.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("alieninv.h", 0x0000),
                new KeyValuePair<string, int>("alieninv.g", 0x0800),
                new KeyValuePair<string, int>("alieninv.f", 0x1000),
                new KeyValuePair<string, int>("alieninv.e", 0x1800)
            }));

            SupportedGames.Add("alieninvp2.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("1h.bin", 0x0000),
                new KeyValuePair<string, int>("1g.bin", 0x0800),
                new KeyValuePair<string, int>("1f.bin", 0x1000),
                new KeyValuePair<string, int>("1e.bin", 0x1800)
            }));

            SupportedGames.Add("sitv1.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("tv01.s1", 0x0000),
                new KeyValuePair<string, int>("tv02.rp1", 0x0800),
                new KeyValuePair<string, int>("tv03.n1", 0x1000),
                new KeyValuePair<string, int>("tv04.m1", 0x1800)
            }));

            SupportedGames.Add("sitv.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("tv0h.s1", 0x0000),
                new KeyValuePair<string, int>("tv02.rp1", 0x0800),
                new KeyValuePair<string, int>("tv03.n1", 0x1000),
                new KeyValuePair<string, int>("tv04.m1", 0x1800)
            }));

            SupportedGames.Add("sicv.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("cv17.36", 0x0000),
                new KeyValuePair<string, int>("cv18.35", 0x0800),
                new KeyValuePair<string, int>("cv19.34", 0x1000),
                new KeyValuePair<string, int>("cv20.33", 0x1800)
            }));

            SupportedGames.Add("sicv1.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("cv11.s1", 0x0000),
                new KeyValuePair<string, int>("cv12.r1", 0x0400),
                new KeyValuePair<string, int>("cv13.np1", 0x0800),
                new KeyValuePair<string, int>("cv14.jk1", 0x1400),
                new KeyValuePair<string, int>("cv15.i1", 0x1800),
                new KeyValuePair<string, int>("cv16.g1", 0x1c00)
            }));

            SupportedGames.Add("sisv1.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("sv01.36", 0x0000),
                new KeyValuePair<string, int>("sv02.35", 0x0400),
                new KeyValuePair<string, int>("sv03.34", 0x0800),
                new KeyValuePair<string, int>("sv04.31", 0x1400),
                new KeyValuePair<string, int>("sv05.42", 0x1800),
                new KeyValuePair<string, int>("sv06.41", 0x1c00)
            }));

            SupportedGames.Add("sisv2.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("sv01.36", 0x0000),
                new KeyValuePair<string, int>("sv02.35", 0x0400),
                new KeyValuePair<string, int>("sv10.34", 0x0800),
                new KeyValuePair<string, int>("sv04.31", 0x1400),
                new KeyValuePair<string, int>("sv09.42", 0x1800),
                new KeyValuePair<string, int>("sv06.41", 0x1c00)
            }));

            SupportedGames.Add("sisv3.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("sv0h.36", 0x0000),
                new KeyValuePair<string, int>("sv02.35", 0x0400),
                new KeyValuePair<string, int>("sv10.34", 0x0800),
                new KeyValuePair<string, int>("sv04.31", 0x1400),
                new KeyValuePair<string, int>("sv09.42", 0x1800),
                new KeyValuePair<string, int>("sv06.41", 0x1c00)
            }));

            SupportedGames.Add("sisv.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("sv0h.36", 0x0000),
                new KeyValuePair<string, int>("sv11.35", 0x0400),
                new KeyValuePair<string, int>("sv12.34", 0x0800),
                new KeyValuePair<string, int>("sv04.31", 0x1400),
                new KeyValuePair<string, int>("sv13.42", 0x1800),
                new KeyValuePair<string, int>("sv14.41", 0x1c00)
            }));

            SupportedGames.Add("spacerng.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("sr1.u36", 0x0000),
                new KeyValuePair<string, int>("sr2.u35", 0x0800),
                new KeyValuePair<string, int>("sr3.u34", 0x1000),
                new KeyValuePair<string, int>("sr4.u33", 0x1800)
            }));

            SupportedGames.Add("spceking.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("invaders.h", 0x0000),
                new KeyValuePair<string, int>("spcekng2", 0x0800),
                new KeyValuePair<string, int>("spcekng3", 0x1000),
                new KeyValuePair<string, int>("spcekng4", 0x1800)
            }));

            SupportedGames.Add("spcewars.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("sanritsu.1", 0x0000),
                new KeyValuePair<string, int>("sanritsu.2", 0x0400),
                new KeyValuePair<string, int>("sanritsu.3", 0x0800),
                new KeyValuePair<string, int>("sanritsu.4", 0x0c00),
                new KeyValuePair<string, int>("sanritsu.5", 0x1000),
                new KeyValuePair<string, int>("sanritsu.6", 0x1400),
                new KeyValuePair<string, int>("sanritsu.7", 0x1800),
                new KeyValuePair<string, int>("sanritsu.8", 0x1c00),
                new KeyValuePair<string, int>("sanritsu.9", 0x4000)
            }));

            SupportedGames.Add("spcewarla.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("ps1.bin", 0x0000),
                new KeyValuePair<string, int>("ps2.bin", 0x0400),
                new KeyValuePair<string, int>("ps3.bin", 0x0800),
                new KeyValuePair<string, int>("ps4.bin", 0x0c00),
                new KeyValuePair<string, int>("ps5.bin", 0x1000),
                new KeyValuePair<string, int>("ps6.bin", 0x1400),
                new KeyValuePair<string, int>("ps7.bin", 0x1800),
                new KeyValuePair<string, int>("ps8.bin", 0x1c00),
                new KeyValuePair<string, int>("ps9.bin", 0x4000)
            }));

            SupportedGames.Add("spacewr3.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("ic36.bin", 0x0000),
                new KeyValuePair<string, int>("ic35.bin", 0x0800),
                new KeyValuePair<string, int>("ic34.bin", 0x1000),
                new KeyValuePair<string, int>("ic33.bin", 0x1800),
                new KeyValuePair<string, int>("ic32.bin", 0x4000)
            }));

            SupportedGames.Add("swipeout.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("sw1.bin", 0x0000),
                new KeyValuePair<string, int>("sw2.bin", 0x0800),
                new KeyValuePair<string, int>("sw3.bin", 0x1000),
                new KeyValuePair<string, int>("sw4.bin", 0x1800),
                new KeyValuePair<string, int>("sw5.bin", 0x4000)
            }));

            SupportedGames.Add("invaderl.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("c01", 0x0000),
                new KeyValuePair<string, int>("c02", 0x0400),
                new KeyValuePair<string, int>("c03", 0x0800),
                new KeyValuePair<string, int>("c07", 0x1000),
                new KeyValuePair<string, int>("c04", 0x1400),
                new KeyValuePair<string, int>("c05", 0x1800),
                new KeyValuePair<string, int>("sv06.bin", 0x1c00)
            }));

            SupportedGames.Add("invadernc.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("1.ic65", 0x0000),
                new KeyValuePair<string, int>("2.ic66", 0x0400),
                new KeyValuePair<string, int>("3.ic67", 0x0800),
                new KeyValuePair<string, int>("7.ic57", 0x1000),
                new KeyValuePair<string, int>("4.ic70", 0x1400),
                new KeyValuePair<string, int>("5.ic71", 0x1800),
                new KeyValuePair<string, int>("6.ic72", 0x1c00)
            }));

            SupportedGames.Add("invader4.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("spin4.a", 0x0000),
                new KeyValuePair<string, int>("spin4.b", 0x0800),
                new KeyValuePair<string, int>("spin4.c", 0x1000),
                new KeyValuePair<string, int>("spin4.d", 0x1800)
            }));

            SupportedGames.Add("jspecter.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("3305.u6", 0x0000),
                new KeyValuePair<string, int>("3306.u7", 0x1400)
            }));

            SupportedGames.Add("jspecter2.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("unksi.b2", 0x0000),
                new KeyValuePair<string, int>("unksi.a2", 0x1400)
            }));

            SupportedGames.Add("invadpt2.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("pv01", 0x0000),
                new KeyValuePair<string, int>("pv02", 0x0800),
                new KeyValuePair<string, int>("pv03", 0x1000),
                new KeyValuePair<string, int>("pv04", 0x1800),
                new KeyValuePair<string, int>("pv05", 0x4000)
            }));

            SupportedGames.Add("invadpt2br.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("pv01", 0x0000),
                new KeyValuePair<string, int>("br_pv02", 0x0800),
                new KeyValuePair<string, int>("br_pv03", 0x1000),
                new KeyValuePair<string, int>("br_pv04", 0x1800),
                new KeyValuePair<string, int>("br_pv05", 0x4000)
            }));

            SupportedGames.Add("invaddlx.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("invdelux.h", 0x0000),
                new KeyValuePair<string, int>("invdelux.g", 0x0800),
                new KeyValuePair<string, int>("invdelux.f", 0x1000),
                new KeyValuePair<string, int>("invdelux.e", 0x1800),
                new KeyValuePair<string, int>("invdelux.d", 0x4000)
            }));

            SupportedGames.Add("vortex.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("1.t36", 0x0000),
                new KeyValuePair<string, int>("2.t35", 0x0800),
                new KeyValuePair<string, int>("3.t34", 0x1000),
                new KeyValuePair<string, int>("4.t33", 0x1800),
                new KeyValuePair<string, int>("5.t32", 0x4000),
                new KeyValuePair<string, int>("6.t31", 0x4800)
            }));

            SupportedGames.Add("moonbase.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("ze3-1.a4", 0x0000),
                new KeyValuePair<string, int>("ze3-2.c4", 0x0400),
                new KeyValuePair<string, int>("ze3-3.e4", 0x0800),
                new KeyValuePair<string, int>("ze3-4.f4", 0x0c00),
                new KeyValuePair<string, int>("ze3-5.h4", 0x1000),
                new KeyValuePair<string, int>("ze3-6.l4", 0x1400),
                new KeyValuePair<string, int>("ze3-7.a5", 0x1800),
                new KeyValuePair<string, int>("ze3-8.c5", 0x1c00),
                new KeyValuePair<string, int>("ze3-9.e5", 0x4000),
                new KeyValuePair<string, int>("ze3-10.f5", 0x4400)
            }));

            SupportedGames.Add("moonbasea.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("ze3-1.a4", 0x0000),
                new KeyValuePair<string, int>("ze3-2.c4", 0x0400),
                new KeyValuePair<string, int>("ze3-3.e4", 0x0800),
                new KeyValuePair<string, int>("ze3-4_alt.f4", 0x0c00),
                new KeyValuePair<string, int>("ze3-5.h4", 0x1000),
                new KeyValuePair<string, int>("ze3-6.l4", 0x1400),
                new KeyValuePair<string, int>("ze3-7.a5", 0x1800),
                new KeyValuePair<string, int>("ze3-8.c5", 0x1c00),
                new KeyValuePair<string, int>("ze3-9.e5", 0x4000),
                new KeyValuePair<string, int>("ze3-10.f5", 0x4400)
            }));

            SupportedGames.Add("invrvnge.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("h.ic36", 0x0000),
                new KeyValuePair<string, int>("g.ic35", 0x0800),
                new KeyValuePair<string, int>("f.ic34", 0x1000),
                new KeyValuePair<string, int>("e.ic33", 0x1800)
            }));

            SupportedGames.Add("invrvngea.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("h.ic36", 0x0000),
                new KeyValuePair<string, int>("g.ic35", 0x0800),
                new KeyValuePair<string, int>("f.ic34", 0x1000),
                new KeyValuePair<string, int>("e.ic33", 0x1800)
            }));

            SupportedGames.Add("invrvngeb.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("invrvnge.h", 0x0000),
                new KeyValuePair<string, int>("invrvnge.g", 0x0800),
                new KeyValuePair<string, int>("invrvnge.f", 0x1000),
                new KeyValuePair<string, int>("invrvnge.e", 0x1800)
            }));

            SupportedGames.Add("invrvngedu.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("ir.5m", 0x0000),
                new KeyValuePair<string, int>("ir.5n", 0x0800),
                new KeyValuePair<string, int>("ir.5p", 0x1000),
                new KeyValuePair<string, int>("ir.5r", 0x1800)
            }));

            SupportedGames.Add("invrvngegw.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("ir.5m", 0x0000),
                new KeyValuePair<string, int>("ir.5n", 0x0800),
                new KeyValuePair<string, int>("ir.5p", 0x1000),
                new KeyValuePair<string, int>("ir.5r", 0x1800)
            }));

            SupportedGames.Add("spclaser.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("la01", 0x0000),
                new KeyValuePair<string, int>("la02", 0x0800),
                new KeyValuePair<string, int>("la03", 0x1000),
                new KeyValuePair<string, int>("la04", 0x1800)
            }));

            SupportedGames.Add("intruder.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("la01-1.36", 0x0000),
                new KeyValuePair<string, int>("la02-1.35", 0x0800),
                new KeyValuePair<string, int>("la03-1.34", 0x1000),
                new KeyValuePair<string, int>("la04-1.33", 0x1800)
            }));

            SupportedGames.Add("laser.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("1.u36", 0x0000),
                new KeyValuePair<string, int>("2.u35", 0x0800),
                new KeyValuePair<string, int>("3.u34", 0x1000),
                new KeyValuePair<string, int>("4.u33", 0x1800)
            }));

            SupportedGames.Add("spcewarl.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("spcewarl.1", 0x0000),
                new KeyValuePair<string, int>("spcewarl.2", 0x0800),
                new KeyValuePair<string, int>("spcewarl.3", 0x1000),
                new KeyValuePair<string, int>("spcewarl.4", 0x1800)
            }));

            SupportedGames.Add("galxwars.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("univgw3.0", 0x0000),
                new KeyValuePair<string, int>("univgw4.1", 0x0400),
                new KeyValuePair<string, int>("univgw5.2", 0x0800),
                new KeyValuePair<string, int>("univgw6.3", 0x0c00),
                new KeyValuePair<string, int>("univgw1.4", 0x4000),
                new KeyValuePair<string, int>("univgw2.5", 0x4400)
            }));

            SupportedGames.Add("galxwars2.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("3192.h6", 0x0000),
                new KeyValuePair<string, int>("3193.h7", 0x4000)
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

            SupportedGames.Add("galxwarst2.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("gv01.bin", 0x0000),
                new KeyValuePair<string, int>("gv02.bin", 0x0400),
                new KeyValuePair<string, int>("gv03.bin", 0x0800),
                new KeyValuePair<string, int>("gv04.bin", 0x0c00),
                new KeyValuePair<string, int>("gv05.bin", 0x4000),
                new KeyValuePair<string, int>("gv06.bin", 0x4400)
            }));

            SupportedGames.Add("starw.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("roma", 0x0000),
                new KeyValuePair<string, int>("romb", 0x0400),
                new KeyValuePair<string, int>("romc", 0x0800),
                new KeyValuePair<string, int>("romd", 0x1400),
                new KeyValuePair<string, int>("rome", 0x1800),
                new KeyValuePair<string, int>("romf", 0x1c00)
            }));

            SupportedGames.Add("starw1.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("gc.75", 0x0000),
                new KeyValuePair<string, int>("gc.77", 0x0400),
                new KeyValuePair<string, int>("gc.76", 0x0800),
                new KeyValuePair<string, int>("gc.80", 0x1400),
                new KeyValuePair<string, int>("gc.81", 0x1800),
                new KeyValuePair<string, int>("gc.82", 0x1c00)
            }));

            SupportedGames.Add("lrescue.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("lrescue.1", 0x0000),
                new KeyValuePair<string, int>("lrescue.2", 0x0800),
                new KeyValuePair<string, int>("lrescue.3", 0x1000),
                new KeyValuePair<string, int>("lrescue.4", 0x1800),
                new KeyValuePair<string, int>("lrescue.5", 0x4000),
                new KeyValuePair<string, int>("lrescue.6", 0x4800)
            }));

            SupportedGames.Add("mlander.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("ml1.u36", 0x0000),
                new KeyValuePair<string, int>("ml2.u35", 0x0800),
                new KeyValuePair<string, int>("ml3.u34", 0x1000),
                new KeyValuePair<string, int>("ml4.u33", 0x1800),
                new KeyValuePair<string, int>("ml5.u32", 0x4000),
                new KeyValuePair<string, int>("ml6.u31", 0x4800)
            }));

            SupportedGames.Add("grescue.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("lrescue.1", 0x0000),
                new KeyValuePair<string, int>("lrescue.2", 0x0800),
                new KeyValuePair<string, int>("lrescue.3", 0x1000),
                new KeyValuePair<string, int>("grescue.4", 0x1800),
                new KeyValuePair<string, int>("grescue.5", 0x4000),
                new KeyValuePair<string, int>("lrescue.6", 0x4800)
            }));

            SupportedGames.Add("desterth.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("36_h.bin", 0x0000),
                new KeyValuePair<string, int>("35_g.bin", 0x0800),
                new KeyValuePair<string, int>("34_f.bin", 0x1000),
                new KeyValuePair<string, int>("33_e.bin", 0x1800),
                new KeyValuePair<string, int>("32_d.bin", 0x4000),
                new KeyValuePair<string, int>("31_c.bin", 0x4800),
                new KeyValuePair<string, int>("42_b.bin", 0x5000)
            }));

            SupportedGames.Add("escmars.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("2516_em.m5", 0x0000),
                new KeyValuePair<string, int>("2716_em.n5", 0x0800),
                new KeyValuePair<string, int>("2516_em.p5", 0x1000),
                new KeyValuePair<string, int>("2516_em.r5", 0x1800),
                new KeyValuePair<string, int>("2716_em.s5", 0x4000),
                new KeyValuePair<string, int>("2716_em.t5", 0x4800)
            }));

            SupportedGames.Add("lrescuem.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("48.ic36", 0x0000),
                new KeyValuePair<string, int>("49.ic35", 0x0400),
                new KeyValuePair<string, int>("50.ic34", 0x0800),
                new KeyValuePair<string, int>("51.ic33", 0x0c00),
                new KeyValuePair<string, int>("52.ic32", 0x1000),
                new KeyValuePair<string, int>("53.ic31", 0x1400),
                new KeyValuePair<string, int>("54.ic42", 0x1800),
                new KeyValuePair<string, int>("55.ic41", 0x1c00),
                new KeyValuePair<string, int>("56.ic40", 0x4000),
                new KeyValuePair<string, int>("57.ic39", 0x4400),
                new KeyValuePair<string, int>("58.ic38", 0x4800),
                new KeyValuePair<string, int>("59.ic37", 0x4c00)
            }));

            SupportedGames.Add("lrescuem2.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("0.bin", 0x0000),
                new KeyValuePair<string, int>("1.bin", 0x0800),
                new KeyValuePair<string, int>("2.bin", 0x1000),
                new KeyValuePair<string, int>("3.bin", 0x1800),
                new KeyValuePair<string, int>("4.bin", 0x4000),
                new KeyValuePair<string, int>("5.bin", 0x4800),
                new KeyValuePair<string, int>("6.bin", 0x5000)
            }));

            SupportedGames.Add("cosmo.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("1.36", 0x0000),
                new KeyValuePair<string, int>("2.35", 0x0800),
                new KeyValuePair<string, int>("3.34", 0x1000),
                new KeyValuePair<string, int>("4.33", 0x1800),
                new KeyValuePair<string, int>("5.32", 0x4000),
                new KeyValuePair<string, int>("6.31", 0x4800),
                new KeyValuePair<string, int>("7.42", 0x5000)
            }));

            SupportedGames.Add("cosmicmo.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("ii-1.h1", 0x0000),
                new KeyValuePair<string, int>("ii-2.h2", 0x0400),
                new KeyValuePair<string, int>("ii-3.h3", 0x0800),
                new KeyValuePair<string, int>("ii-4.h4", 0x0c00),
                new KeyValuePair<string, int>("ii-5.h5", 0x4000),
                new KeyValuePair<string, int>("ii-6.h6", 0x4400),
                new KeyValuePair<string, int>("ii-7.h7", 0x4800)
            }));

            SupportedGames.Add("cosmicm2.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("3907.bin", 0x0000),
                new KeyValuePair<string, int>("3906.bin", 0x4000)
            }));

            SupportedGames.Add("superinv.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("00", 0x0000),
                new KeyValuePair<string, int>("01", 0x0400),
                new KeyValuePair<string, int>("02", 0x0800),
                new KeyValuePair<string, int>("03", 0x1400),
                new KeyValuePair<string, int>("04", 0x1800),
                new KeyValuePair<string, int>("05", 0x1c00)
            }));

            SupportedGames.Add("invasion.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("10136-0.0k", 0x0000),
                new KeyValuePair<string, int>("10136-1.1k", 0x0400),
                new KeyValuePair<string, int>("10136-2.2k", 0x0800),
                new KeyValuePair<string, int>("10136-5.5k", 0x1400),
                new KeyValuePair<string, int>("10136-6.6k", 0x1800),
                new KeyValuePair<string, int>("10136-7.7k", 0x1c00)
            }));

            SupportedGames.Add("invasiona.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("invasiona_0.bin", 0x0000),
                new KeyValuePair<string, int>("invasiona_1.bin", 0x0400),
                new KeyValuePair<string, int>("invasiona_2.bin", 0x0800),
                new KeyValuePair<string, int>("invasiona_3.bin", 0x1400),
                new KeyValuePair<string, int>("invasiona_4.bin", 0x1800),
                new KeyValuePair<string, int>("invasiona_5.bin", 0x1c00)
            }));

            SupportedGames.Add("invasiona2.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("0.0.bin", 0x0000),
                new KeyValuePair<string, int>("1.1.bin", 0x0400),
                new KeyValuePair<string, int>("2.2.bin", 0x0800),
                new KeyValuePair<string, int>("3.5.bin", 0x1400),
                new KeyValuePair<string, int>("4.6.bin", 0x1800),
                new KeyValuePair<string, int>("5.7.bin", 0x1c00)
            }));

            SupportedGames.Add("invasionb.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("invasionb_0.bin", 0x0000),
                new KeyValuePair<string, int>("invasionb_1.bin", 0x0400),
                new KeyValuePair<string, int>("invasionb_2.bin", 0x0800),
                new KeyValuePair<string, int>("invasionb_5.bin", 0x1400),
                new KeyValuePair<string, int>("invasionb_6.bin", 0x1800),
                new KeyValuePair<string, int>("invasionb_7.bin", 0x1c00)
            }));

            SupportedGames.Add("invasionrz.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("rz0.0k", 0x0000),
                new KeyValuePair<string, int>("rz1.1k", 0x0400),
                new KeyValuePair<string, int>("rz2.2k", 0x0800),
                new KeyValuePair<string, int>("rz5.5k", 0x1400),
                new KeyValuePair<string, int>("rz6.6k", 0x1800),
                new KeyValuePair<string, int>("rz7.7k", 0x1c00)
            }));

            SupportedGames.Add("invasionrza.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("rz0-0.9k", 0x0000),
                new KeyValuePair<string, int>("rz1-1.8k", 0x0400),
                new KeyValuePair<string, int>("rz2-2.7k", 0x0800),
                new KeyValuePair<string, int>("rz5-5.4k", 0x1400),
                new KeyValuePair<string, int>("rz6-6.3k", 0x1800),
                new KeyValuePair<string, int>("rz6-6.3ka", 0x1800),
                new KeyValuePair<string, int>("rz7-7.2k", 0x1c00)
            }));

            SupportedGames.Add("invadersem.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("h.bin", 0x0000),
                new KeyValuePair<string, int>("g.bin", 0x0400),
                new KeyValuePair<string, int>("f.bin", 0x0800),
                new KeyValuePair<string, int>("c.bin", 0x1400),
                new KeyValuePair<string, int>("b.bin", 0x1800),
                new KeyValuePair<string, int>("a.bin", 0x1c00)
            }));

            SupportedGames.Add("ultrainv.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("in-01.bin", 0x0000),
                new KeyValuePair<string, int>("in-02.bin", 0x0400),
                new KeyValuePair<string, int>("in-03.bin", 0x0800),
                new KeyValuePair<string, int>("in-04.bin", 0x1400),
                new KeyValuePair<string, int>("in-05.bin", 0x1800),
                new KeyValuePair<string, int>("in-06.bin", 0x1c00)
            }));

            SupportedGames.Add("rollingc.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("rc01.bin", 0x0000),
                new KeyValuePair<string, int>("rc02.bin", 0x0400),
                new KeyValuePair<string, int>("rc03.bin", 0x0800),
                new KeyValuePair<string, int>("rc04.bin", 0x0c00),
                new KeyValuePair<string, int>("rc05.bin", 0x1000),
                new KeyValuePair<string, int>("rc06.bin", 0x1400),
                new KeyValuePair<string, int>("rc07.bin", 0x1800),
                new KeyValuePair<string, int>("rc08.bin", 0x1c00),
                new KeyValuePair<string, int>("rc09.bin", 0x4000),
                new KeyValuePair<string, int>("rc10.bin", 0x4800),
                new KeyValuePair<string, int>("rc11.bin", 0x5000),
                new KeyValuePair<string, int>("rc12.bin", 0x5800)
            }));

            SupportedGames.Add("schaser.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("rt13.bin", 0x0000),
                new KeyValuePair<string, int>("rt14.bin", 0x0400),
                new KeyValuePair<string, int>("rt15.bin", 0x0800),
                new KeyValuePair<string, int>("rt16.bin", 0x0c00),
                new KeyValuePair<string, int>("rt17.bin", 0x1000),
                new KeyValuePair<string, int>("rt18.bin", 0x1400),
                new KeyValuePair<string, int>("rt19.bin", 0x1800),
                new KeyValuePair<string, int>("rt20.bin", 0x1c00),
                new KeyValuePair<string, int>("rt21.bin", 0x4000),
                new KeyValuePair<string, int>("rt22.bin", 0x4400)
            }));

            SupportedGames.Add("schasera.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("rt13.bin", 0x0000),
                new KeyValuePair<string, int>("rt15.bin", 0x0800),
                new KeyValuePair<string, int>("rt17.bin", 0x1000),
                new KeyValuePair<string, int>("rt19.bin", 0x1800),
                new KeyValuePair<string, int>("rt21.bin", 0x4000)
            }));

            SupportedGames.Add("schaserb.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("rt33.bin", 0x0000),
                new KeyValuePair<string, int>("rt34.bin", 0x0800),
                new KeyValuePair<string, int>("rt35.bin", 0x1000),
                new KeyValuePair<string, int>("rt36.bin", 0x1800),
                new KeyValuePair<string, int>("rt37.bin", 0x4000)
            }));

            SupportedGames.Add("schaserm.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("mr26.71", 0x0000),
                new KeyValuePair<string, int>("rt08.70", 0x0800),
                new KeyValuePair<string, int>("rt09.69", 0x1000),
                new KeyValuePair<string, int>("mr27.62", 0x1800),
                new KeyValuePair<string, int>("rt11.61", 0x4000)
            }));

            SupportedGames.Add("crashrd.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("2716-5m.bin", 0x0000),
                new KeyValuePair<string, int>("2716-5n.bin", 0x0800),
                new KeyValuePair<string, int>("2716-5p.bin", 0x1000),
                new KeyValuePair<string, int>("2716-5r.bin", 0x1800),
                new KeyValuePair<string, int>("2716-5s.bin", 0x4000)
            }));

            SupportedGames.Add("sflush.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("fr05.sc2", 0xd800),
                new KeyValuePair<string, int>("fr04.sc3", 0xe000),
                new KeyValuePair<string, int>("fr03.sc4", 0xe800),
                new KeyValuePair<string, int>("fr02.sc5", 0xf000),
                new KeyValuePair<string, int>("fr01.sc6", 0xf800)
            }));

            SupportedGames.Add("schasercv.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("1", 0x0000),
                new KeyValuePair<string, int>("2", 0x0400),
                new KeyValuePair<string, int>("3", 0x0800),
                new KeyValuePair<string, int>("4", 0x0c00),
                new KeyValuePair<string, int>("5", 0x1000),
                new KeyValuePair<string, int>("6", 0x1400),
                new KeyValuePair<string, int>("7", 0x1800),
                new KeyValuePair<string, int>("8", 0x1c00),
                new KeyValuePair<string, int>("9", 0x4000),
                new KeyValuePair<string, int>("10", 0x4400)
            }));

            SupportedGames.Add("schaserc.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("45.ic30", 0x0000),
                new KeyValuePair<string, int>("46.ic36", 0x0400),
                new KeyValuePair<string, int>("rt15.bin", 0x0800),
                new KeyValuePair<string, int>("rt16.bin", 0x0c00),
                new KeyValuePair<string, int>("rt17.bin", 0x1000),
                new KeyValuePair<string, int>("rt18.bin", 0x1400),
                new KeyValuePair<string, int>("rt19.bin", 0x1800),
                new KeyValuePair<string, int>("47.ic39", 0x1c00),
                new KeyValuePair<string, int>("rt21.bin", 0x4000),
                new KeyValuePair<string, int>("rt22.bin", 0x4400)
            }));

            SupportedGames.Add("lupin3.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("lp01.36", 0x0000),
                new KeyValuePair<string, int>("lp02.35", 0x0800),
                new KeyValuePair<string, int>("lp03.34", 0x1000),
                new KeyValuePair<string, int>("lp04.33", 0x1800),
                new KeyValuePair<string, int>("lp05.32", 0x4000),
                new KeyValuePair<string, int>("lp06.31", 0x4800)
            }));

            SupportedGames.Add("lupin3a.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("lp12.bin", 0x0000),
                new KeyValuePair<string, int>("lp13.bin", 0x0800),
                new KeyValuePair<string, int>("lp14.bin", 0x1000),
                new KeyValuePair<string, int>("lp15.bin", 0x1800),
                new KeyValuePair<string, int>("lp16.bin", 0x4000),
                new KeyValuePair<string, int>("lp17.bin", 0x4800),
                new KeyValuePair<string, int>("lp18.bin", 0x5000)
            }));

            SupportedGames.Add("polaris.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("ps01-1.30", 0x0000),
                new KeyValuePair<string, int>("ps09.36", 0x0800),
                new KeyValuePair<string, int>("ps03-1.31", 0x1000),
                new KeyValuePair<string, int>("ps04.37", 0x1800),
                new KeyValuePair<string, int>("ps05.32", 0x4000),
                new KeyValuePair<string, int>("ps10.38", 0x4800),
                new KeyValuePair<string, int>("ps26", 0x5000)
            }));

            SupportedGames.Add("polarisa.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("ps01.30", 0x0000),
                new KeyValuePair<string, int>("ps09.36", 0x0800),
                new KeyValuePair<string, int>("ps03.31", 0x1000),
                new KeyValuePair<string, int>("ps04.37", 0x1800),
                new KeyValuePair<string, int>("ps05.32", 0x4000),
                new KeyValuePair<string, int>("ps10.38", 0x4800)
            }));

            SupportedGames.Add("polariso.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("ps01.30", 0x0000),
                new KeyValuePair<string, int>("ps02.36", 0x0800),
                new KeyValuePair<string, int>("ps03.31", 0x1000),
                new KeyValuePair<string, int>("ps04.37", 0x1800),
                new KeyValuePair<string, int>("ps05.32", 0x4000),
                new KeyValuePair<string, int>("ps06.38", 0x4800)
            }));

            SupportedGames.Add("polarisbr.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("1", 0x0000),
                new KeyValuePair<string, int>("2", 0x0800),
                new KeyValuePair<string, int>("3", 0x1000),
                new KeyValuePair<string, int>("4", 0x1800),
                new KeyValuePair<string, int>("5", 0x4000),
                new KeyValuePair<string, int>("6", 0x4800),
                new KeyValuePair<string, int>("7", 0x5000)
            }));

            SupportedGames.Add("ozmawars.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("mw01", 0x0000),
                new KeyValuePair<string, int>("mw02", 0x0800),
                new KeyValuePair<string, int>("mw03", 0x1000),
                new KeyValuePair<string, int>("mw04", 0x1800),
                new KeyValuePair<string, int>("mw05", 0x4000),
                new KeyValuePair<string, int>("mw06", 0x4800)
            }));

            SupportedGames.Add("ozmawars2.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("oz1", 0x0000),
                new KeyValuePair<string, int>("oz2", 0x0400),
                new KeyValuePair<string, int>("oz3", 0x0800),
                new KeyValuePair<string, int>("oz4", 0x0c00),
                new KeyValuePair<string, int>("oz5", 0x1000),
                new KeyValuePair<string, int>("oz6", 0x1400),
                new KeyValuePair<string, int>("oz7", 0x1800),
                new KeyValuePair<string, int>("oz8", 0x1c00),
                new KeyValuePair<string, int>("oz9", 0x4000),
                new KeyValuePair<string, int>("oz10", 0x4400),
                new KeyValuePair<string, int>("oz11", 0x4800),
                new KeyValuePair<string, int>("oz12", 0x4c00)
            }));

            SupportedGames.Add("ozmawarsmr.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("73.1s", 0x0000),
                new KeyValuePair<string, int>("74.1pr", 0x0400),
                new KeyValuePair<string, int>("75.1n", 0x0800),
                new KeyValuePair<string, int>("76.1m", 0x0c00),
                new KeyValuePair<string, int>("77.1l", 0x1000),
                new KeyValuePair<string, int>("78.1kj", 0x1400),
                new KeyValuePair<string, int>("79.1h", 0x1800),
                new KeyValuePair<string, int>("80.1g", 0x1c00),
                new KeyValuePair<string, int>("81.1ef", 0x4000),
                new KeyValuePair<string, int>("82.1d", 0x4400),
                new KeyValuePair<string, int>("83.1c", 0x4800),
                new KeyValuePair<string, int>("84.1b", 0x4c00)
            }));

            SupportedGames.Add("solfight.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("solfight.m", 0x0000),
                new KeyValuePair<string, int>("solfight.n", 0x0800),
                new KeyValuePair<string, int>("solfight.p", 0x1000),
                new KeyValuePair<string, int>("solfight.r", 0x1800),
                new KeyValuePair<string, int>("mw05", 0x4000),
                new KeyValuePair<string, int>("solfight.t", 0x4800)
            }));

            SupportedGames.Add("spaceph.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("sv01.bin", 0x0000),
                new KeyValuePair<string, int>("sv02.bin", 0x0400),
                new KeyValuePair<string, int>("sv03.bin", 0x0800),
                new KeyValuePair<string, int>("sv04.bin", 0x0c00),
                new KeyValuePair<string, int>("sv05.bin", 0x1000),
                new KeyValuePair<string, int>("sv06.bin", 0x1400),
                new KeyValuePair<string, int>("sv07.bin", 0x1800),
                new KeyValuePair<string, int>("sv08.bin", 0x1c00),
                new KeyValuePair<string, int>("sv09.bin", 0x4000),
                new KeyValuePair<string, int>("sv10.bin", 0x4400),
                new KeyValuePair<string, int>("sv11.bin", 0x4800),
                new KeyValuePair<string, int>("sv12.bin", 0x4c00)
            }));

            SupportedGames.Add("ballbomb.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("tn01", 0x0000),
                new KeyValuePair<string, int>("tn02", 0x0800),
                new KeyValuePair<string, int>("tn03", 0x1000),
                new KeyValuePair<string, int>("tn04", 0x1800),
                new KeyValuePair<string, int>("tn05-1", 0x4000)
            }));

            SupportedGames.Add("yosakdon.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("yd1.bin", 0x0000),
                new KeyValuePair<string, int>("yd2.bin", 0x0400),
                new KeyValuePair<string, int>("yd3.bin", 0x0800),
                new KeyValuePair<string, int>("yd4.bin", 0x0c00),
                new KeyValuePair<string, int>("yd5.bin", 0x1400),
                new KeyValuePair<string, int>("yd6.bin", 0x1800),
                new KeyValuePair<string, int>("yd7.bin", 0x1c00)
            }));

            SupportedGames.Add("yosakdona.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("yosaku1", 0x0000),
                new KeyValuePair<string, int>("yd2.bin", 0x0400),
                new KeyValuePair<string, int>("yosaku3", 0x0800),
                new KeyValuePair<string, int>("yosaku4", 0x0c00),
                new KeyValuePair<string, int>("yosaku5", 0x1400),
                new KeyValuePair<string, int>("yosaku6", 0x1800),
                new KeyValuePair<string, int>("yosaku7", 0x1c00)
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
                new KeyValuePair<string, int>("8.41", 0x5800)
            }));

            SupportedGames.Add("indianbtbr.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("1.36", 0x0000),
                new KeyValuePair<string, int>("2.35", 0x0800),
                new KeyValuePair<string, int>("3.34", 0x1000),
                new KeyValuePair<string, int>("4.33", 0x1800),
                new KeyValuePair<string, int>("5.32", 0x4000),
                new KeyValuePair<string, int>("6.31", 0x4800),
                new KeyValuePair<string, int>("7.42", 0x5000),
                new KeyValuePair<string, int>("8.41", 0x5800)
            }));

            SupportedGames.Add("shuttlei.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("1.13c", 0x0000),
                new KeyValuePair<string, int>("2.11c", 0x0400),
                new KeyValuePair<string, int>("3.13d", 0x0800),
                new KeyValuePair<string, int>("4.11d", 0x0c00),
                new KeyValuePair<string, int>("5.13e", 0x1000),
                new KeyValuePair<string, int>("8.11f", 0x1c00)
            }));

            SupportedGames.Add("skylove.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("01", 0x0000),
                new KeyValuePair<string, int>("02", 0x0400),
                new KeyValuePair<string, int>("03", 0x0800),
                new KeyValuePair<string, int>("04", 0x0c00),
                new KeyValuePair<string, int>("05", 0x1000),
                new KeyValuePair<string, int>("06", 0x1400),
                new KeyValuePair<string, int>("07", 0x1800),
                new KeyValuePair<string, int>("08", 0x1c00)
            }));

            SupportedGames.Add("darthvdr.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("rom0", 0x0000),
                new KeyValuePair<string, int>("rom1", 0x0400),
                new KeyValuePair<string, int>("rom2", 0x0800),
                new KeyValuePair<string, int>("rom3", 0x0c00),
                new KeyValuePair<string, int>("rom4", 0x1000),
                new KeyValuePair<string, int>("rom5", 0x1400)
            }));

            SupportedGames.Add("astropal.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("2708.0a", 0x0000),
                new KeyValuePair<string, int>("2708.1a", 0x0400),
                new KeyValuePair<string, int>("2708.2a", 0x0800),
                new KeyValuePair<string, int>("2708.3a", 0x0c00),
                new KeyValuePair<string, int>("2708.4a", 0x1000),
                new KeyValuePair<string, int>("2708.5a", 0x1400),
                new KeyValuePair<string, int>("2708.6a", 0x1800),
                new KeyValuePair<string, int>("2708.7a", 0x1c00)
            }));

            SupportedGames.Add("steelwkr.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("1.36", 0x0000),
                new KeyValuePair<string, int>("2.35", 0x0400),
                new KeyValuePair<string, int>("3.34", 0x0800),
                new KeyValuePair<string, int>("4.33", 0x0c00),
                new KeyValuePair<string, int>("5.32", 0x1000),
                new KeyValuePair<string, int>("6.31", 0x1400),
                new KeyValuePair<string, int>("7.42", 0x1800),
                new KeyValuePair<string, int>("8.41", 0x1c00)
            }));

            SupportedGames.Add("galactic.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("1", 0x0000),
                new KeyValuePair<string, int>("2", 0x0800),
                new KeyValuePair<string, int>("3", 0x1000),
                new KeyValuePair<string, int>("4", 0x1800),
                new KeyValuePair<string, int>("5", 0x4000),
                new KeyValuePair<string, int>("6", 0x4800),
                new KeyValuePair<string, int>("7", 0x5000)
            }));

            SupportedGames.Add("spacmiss.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("1", 0x0000),
                new KeyValuePair<string, int>("2", 0x0800),
                new KeyValuePair<string, int>("3", 0x1000),
                new KeyValuePair<string, int>("4", 0x1800),
                new KeyValuePair<string, int>("5", 0x4000),
                new KeyValuePair<string, int>("6", 0x4800),
                new KeyValuePair<string, int>("7", 0x5000)
            }));

            SupportedGames.Add("attackfc.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("30a.bin", 0x0000),
                new KeyValuePair<string, int>("36a.bin", 0x0400),
                new KeyValuePair<string, int>("31a.bin", 0x0800),
                new KeyValuePair<string, int>("37a.bin", 0x0c00),
                new KeyValuePair<string, int>("32a.bin", 0x1000),
                new KeyValuePair<string, int>("33a.bin", 0x1800),
                new KeyValuePair<string, int>("39a.bin", 0x1c00)
            }));

            SupportedGames.Add("cane.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("mrcane.71", 0x0000),
                new KeyValuePair<string, int>("mrcane.70", 0x0800),
                new KeyValuePair<string, int>("mrcane.69", 0x1000),
                new KeyValuePair<string, int>("mrcane.62", 0x1800)
            }));

            SupportedGames.Add("orbite.zip", new List<KeyValuePair<string, int>>(new[]
            {
                new KeyValuePair<string, int>("mrxx.71", 0x0000),
                new KeyValuePair<string, int>("mrxx.70", 0x0800),
                new KeyValuePair<string, int>("mrxx.69", 0x1000)
            }));

        }
    }
}
