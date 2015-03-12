using System;
using System.Globalization;
using System.Threading;

class BitShooter
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        ulong target = /*18446744073709551615;*/ ulong.Parse(Console.ReadLine());
        int[] shots = new int[2];
        for (int i = 0; i < 3; i++)
        {
            string[] shot = Console.ReadLine().Split();
            for (int j = 0; j < shot.Length; j++)
            {
                shots[j] = int.Parse(shot[j]);
            }
            int startBit = shots[0] - (shots[1] / 2);
            int finalBit = shots[0] + (shots[1] / 2);
            int range = shots[1];
            ulong damage = 0;
            for (int bit = startBit; bit <= finalBit; bit++)
            {
                if (bit >= 0 && bit < 64)
                {
                    damage |= (ulong)1 << bit;
                }
            }
            target &= ~damage;
        }
        int left = 0;
        int right = 0;
        for (int i = 63; i >= 0; i--)
        {
            ulong bitCheck = (target >> i) & 1;
            if (bitCheck == 1 && i > 31)
            {
                left++;
            }
            else if (bitCheck == 1 && i <= 31)
            {
                right++;
            }
        }
        Console.WriteLine("left: {0}", left);
        Console.WriteLine("right: {0}", right);
    }
}
