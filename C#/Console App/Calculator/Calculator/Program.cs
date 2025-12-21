using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter first number: ");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.Write("Enter operator (+, -, /, *): ");
                char operate = char.Parse(Console.ReadLine());
                Console.Write("Enter secound number: ");
                int secoundNumber = int.Parse(Console.ReadLine());

                switch (operate)
                {
                    case '*':
                        Console.WriteLine("result = " + (firstNumber * secoundNumber));
                        break;
                    case '/':
                        Console.WriteLine("result = " + (firstNumber / secoundNumber));
                        break;
                    case '+':
                        Console.WriteLine("result = " + (firstNumber + secoundNumber));
                        break;
                    case '-':
                        Console.WriteLine("result = " + (firstNumber - secoundNumber));
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
        }
    }
}
