using System;
using System.Globalization;
using System.Threading;

class WineGlass
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int spacesBefore = 0;
        int wine = n - 2;
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', spacesBefore));
            Console.Write(new string('\\', 1));
            Console.Write(new string('*', wine));
            Console.Write(new string('/', 1));
            Console.Write(new string('.', spacesBefore));
            Console.WriteLine();
            spacesBefore++;
            wine -= 2;
        }
        spacesBefore -= 1;
        int rows = (n / 2) - 1;
        if (n >= 12)
        {
            rows = (n / 2) - 2;
        }
        for (int i = 0; i < rows; i++)
        {
            Console.Write(new string('.', spacesBefore));
            Console.Write(new string('|', 1));
            Console.Write(new string('|', 1));
            Console.Write(new string('.', spacesBefore));
            Console.WriteLine();
        }
        for (int i = 0; i < (n / 2 - rows); i++)
        {
            Console.WriteLine(new string('-', n));
        }
    }
}
