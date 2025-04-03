using System;

namespace ConsoleApp2
{
    class Average
    {
        static void Main()
        {
            Console.WriteLine("Enter First Number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Third Number:");
            double c = Convert.ToDouble(Console.ReadLine());
            double avg = (a + b + c) / 3;
            Console.WriteLine($"The Average of 3 numbers: {avg}");
        }
    }
}
