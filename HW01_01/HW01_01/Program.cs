using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double KM_PER_MILE = 1.6;
            Console.WriteLine("This program converts miles to kilometers!");
            Console.WriteLine();
            Console.Write("Enter the distance in miles: ");
            string input = Console.ReadLine();
            double miles = double.Parse(input);
            double kilometers = miles * KM_PER_MILE;
            Console.WriteLine($"{miles} miles is {kilometers} kilometers");
            Console.WriteLine("Please press any key to exit!");
            Console.ReadKey();
        }
    }
}
