using System;
namespace Biggest
{
    class Program
    {
        static void Main()
        {
            int a, b, c;

            Console.WriteLine("Enter The First Number: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Second Number: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Third Number: ");
            c = int.Parse(Console.ReadLine());

            if (a >= b && a >= c)
            {
                Console.WriteLine($"The Biggest Number is {a}");
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine($"The Biggest Number is {b}");
            }
            else
            {
                Console.WriteLine($"The Biggest Number is {c}");
            }
        }
    }
}
