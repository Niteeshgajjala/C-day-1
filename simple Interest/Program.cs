using System;

namespace simple_Interest
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter Principal Amount: ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Enter Rate of Interest per annum: ");
            double r = double.Parse(Console.ReadLine());

            Console.Write("Enter Time in years: ");
            double t = double.Parse(Console.ReadLine());

            double si = (p * r * t) / 100;
            Console.WriteLine($"The Simple Interest is {si}");
        }
    }
}
