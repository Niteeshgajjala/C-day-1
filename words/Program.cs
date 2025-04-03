using System;
namespace Words
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a string: ");
            string s = Console.ReadLine();
            int n = s.Length;
            int wordCount = 0;
            char prevChar = ' ';

            for (int i = 0; i < n; i++)
            {
                if (s[i] != ' ' && prevChar == ' ')
                {
                    wordCount++;
                }
                prevChar = s[i];
            }
            Console.WriteLine($"The number of words is: {wordCount}");
        }
    }
}
