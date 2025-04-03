using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class biggest
    {
        static void Main()
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a>b && a > c)
            {
                Console.WriteLine($"The Biggest Number is {a}");
            }
            if (b>a && b > c)
            {
                Console.WriteLine($"THe Biggest Number is {b}");
            }
            else
            {
                Console.WriteLine($"THe Biggest Number is {c}");

            }

        }
    }
}
