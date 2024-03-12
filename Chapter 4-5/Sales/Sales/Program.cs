using System;

class SalesTracker
{
    static void Main(string[] args)
    {
        decimal totalSalesD = 0m, totalSalesE = 0m, totalSalesF = 0m;

        while (true)
        {
            Console.Write("Enter salesperson initial (d, e, f) or 'z' to display totals:");
            string input = Console.ReadLine().ToLower();

            if (input == "z")
            {
                decimal grandTotal = totalSalesD + totalSalesE + totalSalesF;
                Console.WriteLine($"Total sales for Danielle: {totalSalesD:C}");
                Console.WriteLine($"Total sales for Edward: {totalSalesE:C}");
                Console.WriteLine($"Total sales for Francis: {totalSalesF:C}");
                Console.WriteLine($"Total for all sales: {grandTotal:C}");

                decimal highestTotal = Math.Max(totalSalesD, Math.Max(totalSalesE, totalSalesF));
                string topSalesperson = highestTotal == totalSalesD ? "Danielle" :
                                        highestTotal == totalSalesE ? "Edward" : "Francis";
                Console.WriteLine($"Salesperson with the highest total: {topSalesperson}");

                Console.WriteLine("Press any key to exit!");
                Console.ReadKey();

                break;
            }
            else if (input == "d" || input == "e" || input == "f")
            {
                Console.Write("Enter the sales amount: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal salesAmount) && salesAmount >= 0)
                {
                    switch (input)
                    {
                        case "d":
                            totalSalesD += salesAmount;
                            break;
                        case "e":
                            totalSalesE += salesAmount;
                            break;
                        case "f":
                            totalSalesF += salesAmount;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid sales amount. Please enter a positive number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid initial. Please enter 'd', 'e', 'f', or 'z'.");
            }
        }
    }
}
