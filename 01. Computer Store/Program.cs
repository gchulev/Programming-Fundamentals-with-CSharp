using System;

namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main()
        {
            double totalWithoutTax = 0;

            string command = Console.ReadLine();

            while (command != "special" && command != "regular")
            {
                double currentPrice = double.Parse(command);

                if (currentPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    totalWithoutTax += currentPrice;
                }

                command = Console.ReadLine();
            }

            double taxes = totalWithoutTax * 0.2;
            double total = totalWithoutTax + taxes;

            if (total > 0)
            {
                if (command == "special")
                {
                    total -= total * 0.1;
                }

                Console.WriteLine($"Congratulations you've just bought a new computer!\nPrice without taxes: {totalWithoutTax:f2}$\nTaxes: {taxes:f2}$\n----------- \nTotal price: {total:f2}$");
            }
            else
            {
                Console.WriteLine("Invalid order!");
            }

        }
    }
}
