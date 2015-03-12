using System;
using System.Globalization;
using System.Threading;

class LongestAlphabeticalWord
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        char[] word = Console.ReadLine().ToCharArray();
        int n = int.Parse(Console.ReadLine());
        char[,] matrix = new char[n, n];
        int index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = word[index];
                index = index + 1 < word.Length ? (index + 1) : 0;
            }
        }
        string longestWord = string.Empty;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                string toRight = GetLongestWord(matrix, i, j, 1, 0);
                longestWord = FindLongestWord(longestWord, toRight);
                string toLeft = GetLongestWord(matrix, i, j, -1, 0);
                longestWord = FindLongestWord(longestWord, toLeft);
                string toDown = GetLongestWord(matrix, i, j, 0, 1);
                longestWord = FindLongestWord(longestWord, toDown);
                string toUp = GetLongestWord(matrix, i, j, 0, -1);
                longestWord = FindLongestWord(longestWord, toUp);
            }
        }
        Console.WriteLine(longestWord);
    }
    static string GetLongestWord(char[,] matrix, int row, int col, int directionX, int directionY)
    {
        char currentLetter = matrix[row, col];
        string longestWord = "" + currentLetter;
        while (true)
        {
            if (row + directionY < 0 || row + directionY == matrix.GetLength(0) || col + directionX < 0 || col + directionX == matrix.GetLength(1))
            {
                break;
            }
            char nextLetter = matrix[row + directionY, col + directionX];
            if (nextLetter <= currentLetter)
            {
                break;
            }
            longestWord += nextLetter;
            currentLetter = nextLetter;
            row += directionY;
            col += directionX;
        }
        return longestWord;
    }
    static string FindLongestWord(string currentLongest, string checkedLongest)
    {
        if (currentLongest.Length > checkedLongest.Length || (currentLongest.Length == checkedLongest.Length && currentLongest.CompareTo(checkedLongest) < 0))
        {
            return currentLongest;
        }
        return checkedLongest;
    }
}
