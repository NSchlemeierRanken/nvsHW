using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double score1;
            double score2;
            double score3;
            double score4;

            Console.WriteLine("This program takes 4 test scores and calculates the average!");
            Console.WriteLine();
            Console.Write("Enter the first test score: ");
            score1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the second test score: ");
            score2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the third test score: ");
            score3 = double.Parse(Console.ReadLine());
            Console.Write("Enter the fourth test score: ");
            score4 = double.Parse(Console.ReadLine());

            double average = (score1 + score2 + score3 + score4) / 4;
            Console.WriteLine($"The average test score is: {average}");

            Console.WriteLine("Press a key to exit!");
            Console.ReadKey();
        }
    }
}
