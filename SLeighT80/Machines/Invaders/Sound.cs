using SLeighT80.Processors.i8080;
using System;
using System.IO;
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

        private static readonly string[] Port3Sounds =
        {
            "0.wav",
            "1.wav",
            "2.wav",
            "3.wav",
            "9.wav",
        };

        private static readonly string[] Port5Sounds =
        {
            "4.wav",
            "5.wav",
            "6.wav",
            "7.wav",
            "8.wav",
        };

        /// <summary>
        /// Call the from the IN instruction to play the sounds as per the original hardware's sound board
        /// </summary>
        /// <param name="machine"></param>
        internal static void PlaySounds(i8080 machine)
        {
            if (machine.PORT_OUT_3 != LastOutPort3)
            {
                if ((machine.PORT_OUT_3 & 0x1) != 0 && (LastOutPort3 & 0x1) == 0)
                {
                    PlayLoopingSoundFile(Port3Sounds[0]);
                }
                else if ((machine.PORT_OUT_3 & 0x1) == 0 && (LastOutPort3 & 0x1) != 0)
                {
                    StopLoopingSoundFile();
                }
                else
                {
                    PlaySound(machine.PORT_OUT_3, LastOutPort3, Port3Sounds, true);
                }
                LastOutPort3 = machine.PORT_OUT_3;
            }

            if (machine.PORT_OUT_5 != m_lastOutPort5)
            {
                PlaySound(machine.PORT_OUT_5, m_lastOutPort5, Port5Sounds, true);
                m_lastOutPort5 = machine.PORT_OUT_5;
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
            for (int i = 0; i < 5; ++i)
            {
                if ((port & (1 << i)) != 0 && (lastPort & 1 << i) == 0)
                {
                    if (i < soundTable.Length)
                    {
                        if (threaded)
                        {
                            PlaySoundFileThreaded(soundTable[i]);
                        }
                        else
                        {
                            PlaySoundFile(soundTable[i]);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Uses mciSendString to play a wav file, but threads out the operation
        /// </summary>
        /// <param name="strAudioFilePath"></param>
        private static void PlaySoundFileThreaded(string strAudioFilePath)
        {
            if (File.Exists(strAudioFilePath))
            {
                try
                {
                    ThreadPool.QueueUserWorkItem(a =>
                    {
                        StringBuilder sb = new StringBuilder();
                        Guid g = Guid.NewGuid();
                        NativeMethods.mciSendString("open \"" + strAudioFilePath + "\" alias " + g.ToString(), sb, 0, IntPtr.Zero);
                        NativeMethods.mciSendString("play " + g.ToString(), sb, 0, IntPtr.Zero);
                    });
                }
                catch (Exception)
                {
                    // Log
                }
            }
        }

        /// <summary>
        /// Uses mciSendString to play a wav file
        /// </summary>
        /// <param name="strAudioFilePath"></param>
        private static void PlaySoundFile(string strAudioFilePath)
        {
            if (File.Exists(strAudioFilePath))
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    Guid g = Guid.NewGuid();
                    NativeMethods.mciSendString("open \"" + strAudioFilePath + "\" alias " + g.ToString(), sb, 0, IntPtr.Zero);
                    NativeMethods.mciSendString("play " + g.ToString(), sb, 0, IntPtr.Zero);
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
        private static void StopLoopingSoundFile()
        {
            m_loopingSound?.Stop();
        }
    }
}
