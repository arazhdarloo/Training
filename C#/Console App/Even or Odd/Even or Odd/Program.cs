using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_or_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enetr a number: ");
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                    Console.WriteLine("its Even");
                else
                    Console.WriteLine("its Odd");
            }
        }
    }
}
