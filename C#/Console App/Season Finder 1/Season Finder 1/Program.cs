using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Season_Finder_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter season number: ");
            byte seasonNumber = byte.Parse(Console.ReadLine());

            if (seasonNumber == 1)
                Console.WriteLine("spring");
            else if (seasonNumber == 2)
                Console.WriteLine("summer");
            else if (seasonNumber == 3)
                Console.WriteLine("fall");
            else if (seasonNumber == 4)
                Console.WriteLine("winter");
            else Console.WriteLine("error");

            Console.ReadKey();
        }
    }
}
