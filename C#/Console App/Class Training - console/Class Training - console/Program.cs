using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Training___console
{
    internal class EvenOrOdd
    {
        public int number;
        public string check()
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
    }
    internal class QuadraticEquation
    {
        public double a;
        public double b;
        public double c;

        public void calc()
        {
            double d = Math.Pow(b, 2) - 4 * a * c;

            if (d > 0)
            {
                Console.WriteLine("x1 : " + (-b + Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("x2 : " + (-b - Math.Sqrt(d)) / (2 * a));
            }
            else if (d == 0)
            {
                Console.WriteLine("x : " + (-b / (2 * a)));
            }
            else
            {
                Console.WriteLine("didn't have real root");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            EvenOrOdd evenOrOdd = new EvenOrOdd();
            evenOrOdd.number = 1;
            Console.WriteLine(evenOrOdd.check());


            QuadraticEquation quadraticEquation = new QuadraticEquation();
            quadraticEquation.a = 5;
            quadraticEquation.b = 6;
            quadraticEquation.c = 1;
            quadraticEquation.calc();

            Console.ReadLine();
        }
    }
}
