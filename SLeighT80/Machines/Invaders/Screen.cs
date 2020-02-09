using SLeighT80.Processors.i8080;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace SLeighT80.Machines.Invaders
{
    public class Screen
    {
        // This is the last drawn value for a given address if it hasn't changed use the last value
        static byte[] cache = new byte[256 * 224 / 8];

        // So we can thread out the memory plots
        static object gdiLock = new object();

        // The current scale factor
        static int scaleFactor = 3;

        // The current frames per second
        static double fps;

        // The bitmap we will draw to
        static Bitmap gameBitmap;

        // The graphics device we are drawing to
        static Graphics graphics;

        // The font we will use to display the FPS counter
        static Font drawFont = new Font("Arial", 10);

        // The FPS counter
        static Stopwatch fpsCounter;

        // If the scale factor changes, we need to re-create the bit map we are drawing on to
        static int lastScaleFactor = -1;

        /// <summary>
        /// Paint the screen to a decive context
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="machine"></param>
        /// <param name="rectangle"></param>
        /// <param name="offset"></param>
        internal static void Paint(Graphics graphics, i8080 machine, Rectangle rectangle, int offset, int factor)
        {
            scaleFactor = factor;

            if (gameBitmap == null || lastScaleFactor != scaleFactor)
            {
                lastScaleFactor = scaleFactor;
                gameBitmap = new Bitmap(224 * scaleFactor, 256 * scaleFactor + offset  / scaleFactor);
                Screen.graphics = Graphics.FromImage(gameBitmap);
                fpsCounter = new Stopwatch();
                fpsCounter.Start();
                for (int i = 0; i <  cache.Length; ++i)
                {
                    cache[i] = 0xff;
                }
            }
            machine.Painting = true;
            bool changed = Render(Screen.graphics, machine.RAM, offset / scaleFactor);
            if (changed)
            {
                machine.Frames++;
            }

            graphics.DrawImageUnscaled(gameBitmap, (rectangle.Width - gameBitmap.Width) / 2, rectangle.Top);
            graphics.DrawString("fps: " + fps.ToString("F"), drawFont, Brushes.Green, 3.0f, rectangle.Height - 20);

            if (fpsCounter.ElapsedMilliseconds > 1000)
            {
                fps = (double)machine.Frames / fpsCounter.ElapsedMilliseconds * 1000.0;
                fps = Math.Round(fps * 2, MidpointRounding.AwayFromZero) / 2;
                fpsCounter.Restart();
                machine.Frames = 0;
            }
            machine.Painting = false;
        }

        /// <summary>
        /// Plots the machines video ram to a bitmap
        /// </summary>
        /// <param name="g"></param>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static unsafe bool Render(Graphics g, byte[] buffer, int offset = 0)
        {
            bool changed = false;
            var image = gameBitmap;
            BitmapData imageData = null;
            int bytesPerPixel = 3;
            byte* scan0 = null;
            int stride = 0;

            int addr = 0;
            for (addr = 0x2400; addr < 0x2400 + 256 * 224 / 8; ++addr)
            {
                if (cache[addr - 0x2400] != buffer[addr])
                {
                    if (!changed)
                    {
                        imageData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                        scan0 = (byte*)imageData.Scan0.ToPointer();
                        stride = imageData.Stride;
                    }
                    changed = true;
                    break;
                }
            }

            if (changed)
            {
                Parallel.For(addr, 0x2400 + 256 * 224 / 8, a =>
                {
                    int address = a - 0x2400;
                    int y = ~(((address & 0x1f) * 8) & 0xFF) & 0xFF;
                    int x = address >> 5;

                    int screenX = x * scaleFactor;
                    int screenY = offset + y * scaleFactor;

                    for (var i = 0; i < 8; ++i)
                    {
                        Color c = ApplyCelophane(x, y - 1, buffer[a], i);

                        for (int v1 = 0; v1 < scaleFactor - 1; ++v1)
                        {

                            byte* row = scan0 + ((v1 + screenY - i * (scaleFactor)) * stride);

                            for (int v = 0; v < (scaleFactor - 1); ++v)
                            {
                                row[(v + screenX) * bytesPerPixel] = c.B;
                                row[(v + screenX) * bytesPerPixel + 1] = c.G;
                                row[(v + screenX) * bytesPerPixel + 2] = c.R;
                            }
                        }
                    }

                    cache[a - 0x2400] = buffer[a];
                }
            );

            }
            if (changed)
            {
                image.UnlockBits(imageData);
            }
            return changed;
        }

        /// <summary>
        /// Changes the color of a pixel based on it's location
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="value"></param>
        /// <param name="bit"></param>
        /// <returns></returns>
        static Color ApplyCelophane(int x, int y, int value, int bit)
        {
            y = y - bit + 1;
            if (((value >> bit) & 1) != 0)
            {
                // Call return Color.White here for the black and white version;

                if (y >= 184 && y <= 239 && x >= 0 && x <= 223)
                {
                    return Color.FromArgb(0, 255, 0);
                }
                if (y >= 239 && y <= 247 && x >= 16 && x <= 133)
                {
                    return Color.FromArgb(0, 255, 0);
                }
                if (y >= 32 && y >= 64 && x >= 0 && x <= 233)
                {
                    return Color.White;
                }
                return Color.FromArgb(255, 0, 0);
            }
            return Color.Black;
        }
    }
}
