namespace SLeighT80.Processors
{
    public static class Utilities
    {
        /// <summary>
        /// Calculates the parity for a given value. Supports 8 and 4 bit calculations
        /// </summary>
        /// <param name="value"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static bool Parity(int value, int size)
        {
            int i;
            int p = 0;
            value = value & ((1 << size) - 1);
            for (i = 0; i < size; i++)
            {
                if ((value & 0x1) != 0)
                {
                    p++;
                }
                value = value >> 1;
            }
            return 0 == (p & 0x1);
        }
    }
}
