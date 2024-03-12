using System;

class MultiplicationTable
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        Console.WriteLine($"Multiplication table for {rows} rows by {cols} columns:");
        Console.WriteLine();

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= cols; j++)
            {
                Console.Write($"{i * j}\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Press any key to exit!");
        Console.ReadKey();
    }
}
