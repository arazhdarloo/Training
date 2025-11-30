using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimeter_and_Area_of_​​a_Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter width: ");
                int width = int.Parse(Console.ReadLine());
                Console.Write("Enter height: ");
                int height = int.Parse(Console.ReadLine());

                Console.WriteLine("Area is " + (width * height));
                Console.WriteLine("Perimeter is " + 2 * (width + height));
            }
        }
    }
}
