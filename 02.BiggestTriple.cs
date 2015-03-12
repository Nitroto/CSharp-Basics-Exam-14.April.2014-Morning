using System;
using System.Globalization;
using System.Threading;

class BiggestTriple
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string[] userInput = Console.ReadLine().Split(' ');
        int maxSum = int.MinValue;
        int index = 1;
        int curentSum = 0;
        int startOfMax = 0;
        int lastOfMax = 0;
        for (int i = 0; i < userInput.Length; i++)
        {
            curentSum += int.Parse(userInput[i]);
            if (index == 3 || i == (userInput.Length - 1))
            {
                if (maxSum < curentSum)
                {
                    startOfMax = i - (index - 1);
                    lastOfMax = i;
                    maxSum = curentSum;
                }
                curentSum = 0;
                index = 0;
            }
            index++;
        }
        for (int i = startOfMax; i <= lastOfMax; i++)
        {
            Console.Write("{0} ", userInput[i]);
        }
        Console.WriteLine();
    }
}
