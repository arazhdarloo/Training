using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Season_Finder_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter season number: ");
            byte seasonNumber = byte.Parse(Console.ReadLine());

            switch (seasonNumber)
            {
                case 1:
                    Console.WriteLine("spring");
                    break;
                case 2:
                    Console.WriteLine("summer");
                    break;
                case 3:
                    Console.WriteLine("fall");
                    break;
                case 4:
                    Console.WriteLine("winter");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

            Console.ReadKey();
        }
    }
}
