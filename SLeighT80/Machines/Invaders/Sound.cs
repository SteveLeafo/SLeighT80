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
        private static SoundPlayer loopingSound;

        // Remember the last port
        private static byte last_out_port5;

        internal static byte last_out_port3;

        private static string[] port3sounds = new string[]
        {
            "0.wav",
            "1.wav",
            "2.wav",
            "3.wav",
            "9.wav",
        };

        private static string[] port5sounds = new string[]
        {
            "4.wav",
            "5.wav",
            "6.wav",
            "7.wav",
            "8.wav",
        };

        /// <summary>
        /// Call the from the IN instruction to play the sounds as per the original hardwares sound board
        /// </summary>
        /// <param name="machine"></param>
        internal static void PlaySounds(i8080 machine)
        {
            if (machine.PORT_OUT_3 != last_out_port3)
            {
                if ((machine.PORT_OUT_3 & 0x1) != 0 && (last_out_port3 & 0x1) == 0)
                {
                    PlayLoopingSoundFile(port3sounds[0]);
                }
                else if ((machine.PORT_OUT_3 & 0x1) == 0 && (last_out_port3 & 0x1) != 0)
                {
                    StopLoopingSoundFile();
                }
                else
                {
                    PlaySound(machine.PORT_OUT_3, last_out_port3, port3sounds, true);
                }
                last_out_port3 = machine.PORT_OUT_3;
            }

            if (machine.PORT_OUT_5 != last_out_port5)
            {
                PlaySound(machine.PORT_OUT_5, last_out_port5, port5sounds, true);
                last_out_port5 = machine.PORT_OUT_5;
            }
        }

        /// <summary>
        /// Checks the input ports and tries the play the correct sound file
        /// </summary>
        /// <param name="port"></param>
        /// <param name="lastPort"></param>
        /// <param name="soundTable"></param>
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
                    loopingSound = new SoundPlayer(strAudioFilePath);
                    ThreadPool.QueueUserWorkItem(a => loopingSound.PlayLooping());
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
            if (loopingSound != null)
            {
                loopingSound.Stop();
            }
        }
    }
}
