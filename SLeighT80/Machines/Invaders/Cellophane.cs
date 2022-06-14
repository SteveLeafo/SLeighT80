using System.Drawing;

namespace SLeighT80.Machines.Invaders
{
    internal class Cellophane
    {
        /// <summary>
        /// Changes the color of a pixel based on it's location
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="value"></param>
        /// <param name="bit"></param>
        /// <returns></returns>
        internal static Color ApplyRedAndGreen(int x, int y, int value, int bit)
        {
            // Find the current row
            y = y - bit + 1;

            if (((value >> bit) & 1) != 0)
            {
                // Call return Color.White here for the black and white version;
                if (ColourMap.ActiveColorMap != null)
                {
                    return ColourMap.GetColor(1023 - ((27 - (x / 8)) * 32 + ((y / 8))));
                }

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
