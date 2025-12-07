using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculating_GPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float totalScores = 0;
            int numberOfStudents = 5;
            for (int i = 1; i <= numberOfStudents; i++)
            {
                Console.Write("Enter the score of student number " + i + ": ");
                float score = float.Parse(Console.ReadLine());
                totalScores += score;
            }
            Console.WriteLine("total scores = " + totalScores);
            Console.WriteLine("GPA = " + totalScores / numberOfStudents);


            Console.ReadKey();
        }
    }
}
