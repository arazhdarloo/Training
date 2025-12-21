using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Enter c: ");
                int c = int.Parse(Console.ReadLine());

                int d = (b * b) - (4 * a * c);

                if (d > 0)
                {
                    Console.WriteLine((-b + Math.Sqrt(d)) / (2 * a));
                    Console.WriteLine((-b - Math.Sqrt(d)) / (2 * a));
                }
                else if (d == 0)
                {
                    Console.WriteLine(-b / (2 * a));
                }
                else
                {
                    Console.WriteLine("It has no roots");
                }
            }
        }
    }
}
