using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sides");
            Console.Write("enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("enter c: ");
            int c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
                Console.WriteLine("You can make a triangle.");
            else Console.WriteLine("You can't make a triangle.");


            Console.ReadKey();
        }
    }
}
