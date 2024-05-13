using AudioPlayerApp;
using SLeighT80.Processors.i8080;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;


namespace SLeighT80.Machines.Invaders
{
    class Sound
    {
        // Use this for any looping sounds
        private static SoundPlayer m_loopingSound;

        // Remember the last port
        private static byte m_lastOutPort5;

        internal static byte LastOutPort3;

        // Sample names from the MAME source code
        public static string[] invaders_sample_names = new[]
        {
            "1.wav",        /* shot/missle */
            "2.wav",        /* base hit/explosion */
            "3.wav",        /* invader hit */
            "4.wav",        /* fleet move 1 */
            "5.wav",        /* fleet move 2 */
            "6.wav",        /* fleet move 3 */
            "7.wav",        /* fleet move 4 */
            "8.wav",        /* UFO/saucer hit */
            "9.wav",        /* bonus base */
        };

        public static string[] lrescue_sample_names = new[]
        {
            "beamgun.wav",              /* shot/missle */
            "rescueshipexplosion.wav",  /* base hit/explosion*/
            "alienexplosion.wav",       /* invader hit */
            "thrust.wav",               /* fleet move 1 */
            "bonus2.wav",               /* fleet move 2 */
            "stepl.wav",         /* fleet move 4 */
            "bonus3.wav",               /* fleet move 3 */
            "shootingstar.wav",                /* UFO/saucer hit */
            "steph.wav",                /* bonus base */
        };

        public static string[] lupin3_sample_names = new[]
        {
            "cap.wav",      /* go to jail */
            "bark.wav",     /* dog barking */
            "walk1.wav",        /* walk, get money */
            "walk2.wav",        /* walk, get money */
            "warp.wav",     /* translocate, deposit money */
            "extend.wav",       /* bonus man */
            "kick.wav",     /* lands on top of building, wife kicks man */
        };

        public static string[] activeSamples = lrescue_sample_names;
        static string sampleFile = "invaders.zip";

        public static void SetActiveSample(string fileName)
        {
            sounds.Clear();
            soundLengths.Clear();
            players.Clear();

            switch (Path.GetFileName(fileName))
            {
                case "lupin3.zip":
                case "lupin3a.zip":
                    activeSamples = lrescue_sample_names;
                    sampleFile = "lrescue.zip";
                    break;
                case "desterth.zip":
                case "lrescue.zip":
                case "grescue.zip":
                    activeSamples = lrescue_sample_names;
                    sampleFile = "lrescue.zip";
                    break;
                default:
                    activeSamples = invaders_sample_names;
                    sampleFile = "invaders.zip";
                    break;
            }

            Port3Sounds = new[] {
                "0.wav",
                activeSamples[0],
                activeSamples[1],
                activeSamples[2],
                activeSamples[8]};

            Port5Sounds = new [] {
                activeSamples[3],
                activeSamples[4],
                activeSamples[5],
                activeSamples[6],
                activeSamples[7]};
        }
        private static string[] Port3Sounds =
        {
            "0.wav",
            activeSamples[0],
            activeSamples[1],
            activeSamples[2],
            activeSamples[8]
        };

        private static string[] Port5Sounds =
        {
            activeSamples[3],
            activeSamples[4],
            activeSamples[5],
            activeSamples[6],
            activeSamples[7]
        };

        static byte PORT_IN_1 = 0;
        static byte PORT_IN_2 = 1;

        static byte PORT_OUT_3 = 2;
        static byte PORT_OUT_5 = 3;

        static byte SHIFT_LSB = 4;
        static byte SHIFT_MSB = 5;

        /// <summary>
        /// Called from the IN instruction to play the sounds as per the original hardware's sound board
        /// </summary>
        /// <param name="machine"></param>
        internal static void PlaySounds(i8080 machine)
        {
            if (machine.Ports[PORT_OUT_3] != LastOutPort3)
            {
                if ((machine.Ports[PORT_OUT_3] & 0x1) != 0 && (LastOutPort3 & 0x1) == 0)
                {
                    PlayLoopingSoundFile(Port3Sounds[0]);
                }
                else if ((machine.Ports[PORT_OUT_3] & 0x1) == 0 && (LastOutPort3 & 0x1) != 0)
                {
                    StopLoopingSoundFile();
                }
                else
                {
                    PlaySound(machine.Ports[PORT_OUT_3], LastOutPort3, Port3Sounds, true);
                }
                LastOutPort3 = machine.Ports[PORT_OUT_3];
            }

            if (machine.Ports[PORT_OUT_5] != m_lastOutPort5)
            {
                PlaySound(machine.Ports[PORT_OUT_5], m_lastOutPort5, Port5Sounds, true);
                m_lastOutPort5 = machine.Ports[PORT_OUT_5];
            }
        }

         /// <summary>
        /// Checks the input ports and tries the play the correct sound file
        /// </summary>
        /// <param name="port"></param>
        /// <param name="lastPort"></param>
        /// <param name="soundTable"></param>
        /// <param name="threaded"></param>
        private static void PlaySound(byte port, byte lastPort, string[] soundTable, bool threaded = false)
        {
            for (int i = 0; i< 5; ++i)
            {
                if ((port & (1 << i)) != 0 && (lastPort & 1 << i) == 0)
                {
                    if (i<soundTable.Length)
                    {
                        if (threaded)
                        {
                            PlaySoundFileDX(soundTable[i]);
                        }
                        else
                        {
                            PlaySoundFileDX(soundTable[i]);
                        }
                    }
                }
            }
        }

        static Dictionary<string, DateTime> sounds = new Dictionary<string, DateTime>();
        static Dictionary<string, AudioPlayer> players = new Dictionary<string, AudioPlayer>();
        static Dictionary<string, int> soundLengths = new Dictionary<string, int>();

        public static int GetSoundLength(string fileName)
        {
            int length = 0;
            if (!soundLengths.TryGetValue(fileName, out length))
            {

                StringBuilder lengthBuf = new StringBuilder(32);

                NativeMethods.mciSendString(string.Format("open \"{0}\" type waveaudio alias wave", fileName), null, 0, IntPtr.Zero);
                NativeMethods.mciSendString("status wave length", lengthBuf, lengthBuf.Capacity, IntPtr.Zero);
                NativeMethods.mciSendString("close wave", null, 0, IntPtr.Zero);

                int.TryParse(lengthBuf.ToString(), out length);
                soundLengths.Add(fileName, length);
            }
            return length;
        }

        /// <summary>
        /// Uses mciSendString to play a wav file, but threads out the operation
        /// </summary>
        /// <param name="strAudioFilePath"></param>
        private static void PlaySoundFileDX(string strAudioFilePath)
        {
            DateTime lastPlayed;
            bool first = false;
            if (!sounds.TryGetValue(strAudioFilePath, out lastPlayed))
            {
                lastPlayed = DateTime.Now;
                sounds.Add(strAudioFilePath, lastPlayed);
                first = true;
            }
            else
            {
                sounds[strAudioFilePath] = DateTime.Now;
            }
            if (first || (DateTime.Now - lastPlayed).TotalMilliseconds > GetSoundLength(strAudioFilePath))
            {
                try
                {
                    AudioPlayer ap;
                    if (!players.TryGetValue(strAudioFilePath, out ap))
                    {
                        string fileName = "Samples\\" + sampleFile;

                        if (File.Exists(fileName))
                        {
                            using (var file = File.OpenRead(fileName))
                            using (var zip = new ZipArchive(file, ZipArchiveMode.Read))
                            {
                                ZipArchiveEntry entry = zip.Entries.FirstOrDefault(a => a.Name == strAudioFilePath);
                                if (entry != null)
                                {
                                    using (var stream = entry.Open())
                                    {
                                        ap = new AudioPlayer();
                                        stream.CopyTo(ap.audioStream);
                                        ap.Init();
                                        players.Add(strAudioFilePath, ap);
                                    }
                                }
                            }
                        }
                    }
                    
                    ap?.Play();
                }
                catch (Exception)
                {
                    // Log
                }
            }
        }

        /// <summary>
        /// Uses System.Media to play a wav file in a loop
        /// </summary>
        /// <param name="strAudioFilePath"></param>
        private static void PlayLoopingSoundFile(string strAudioFilePath)
        {
            if (File.Exists(strAudioFilePath))
            {
                try
                {
                    m_loopingSound = new SoundPlayer(strAudioFilePath);
                    ThreadPool.QueueUserWorkItem(a => m_loopingSound.PlayLooping());
                }
                catch (Exception)
                {
                    // Log
                }
            }
        }

        /// <summary>
        /// Stops the currently looping sounds file
        /// </summary>
        public static void StopLoopingSoundFile()
        {
            m_loopingSound?.Stop();
        }
    }
}
