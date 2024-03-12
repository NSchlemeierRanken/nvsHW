using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW01_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PERCENT_RAISE = 0.04;

            Console.WriteLine("This program calculates salaries for 3 employees if they got a 4% raise every year for 3 years!");
            Console.WriteLine();
            Console.Write("Enter the name of the first employee: ");
            string name1 = Console.ReadLine();
            Console.Write("Enter the salary of the first employee: ");
            double salary1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the name of the second employee: ");
            string name2 = Console.ReadLine();
            Console.Write("Enter the salary of the second employee: ");
            double salary2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the name of the third employee: ");
            string name3 = Console.ReadLine();
            Console.Write("Enter the salary of the third employee: ");
            double salary3 = double.Parse(Console.ReadLine());

            double salary1Year1 = salary1 + (salary1 * PERCENT_RAISE);
            double salary1Year2 = salary1Year1 + (salary1Year1 * PERCENT_RAISE);

            double salary2Year1 = salary2 + (salary2 * PERCENT_RAISE);
            double salary2Year2 = salary2Year1 + (salary2Year1 * PERCENT_RAISE);

            double salary3Year1 = salary3 + (salary3 * PERCENT_RAISE);
            double salary3Year2 = salary3Year1 + (salary3Year1 * PERCENT_RAISE);

            
            Console.WriteLine("+------------+------------+------------+------------+");
            Console.WriteLine($"| Year       | {name1,10} | {name2,10} | {name3,10} |");
            Console.WriteLine("+------------+------------+------------+------------+");
            Console.WriteLine($"| 2024       | ${salary1,10:F2} | ${salary2,10:F2} | ${salary3,10:F2} |");
            Console.WriteLine($"| 2025       | ${salary1Year1,10:F2} | ${salary2Year1,10:F2} | ${salary3Year1,10:F2} |");
            Console.WriteLine($"| 2026       | ${salary1Year2,10:F2} | ${salary2Year2,10:F2} | ${salary3Year2,10:F2} |");
            Console.WriteLine("+------------+------------+------------+------------+");

            Console.WriteLine("Please press a key to exit!");
            Console.ReadKey();
        }
    }
}
