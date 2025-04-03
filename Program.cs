using System;

namespace Avg
{
    class Program
    {
        static void Main()
        {
            double a, b, c;
            Console.WriteLine("Enter The First Number: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Second Number: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Third Number: ");
            c = double.Parse(Console.ReadLine());

            double avg = (a + b + c) / 3;
            Console.WriteLine("Average of three numbers is: " + avg);
        }
    }
}
