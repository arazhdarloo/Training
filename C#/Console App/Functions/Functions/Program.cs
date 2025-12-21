using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        static void Factorial(int number)
        {
            int n = 1;
            for (int i = 1; i <= number; i++) { 
                n = n * i;
            }
            Console.WriteLine(n);
        }
        static void EvenOrOdd(int number)
        {
            if(number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
        static void quadraticEquation(int a, int b, int c)
        {
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
        static bool isTriangle(int a, int b, int c)
        {
            if (a + b > c && a + c > b && b + c > a) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            Factorial(5);
            EvenOrOdd(4);
            quadraticEquation(4, 3, -1);
            Console.WriteLine(isTriangle(4, 3, 14));

            Console.ReadKey();
        }
    }
}
