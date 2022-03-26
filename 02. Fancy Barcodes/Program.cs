using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"(@#+)(?<product>[A-Z][A-Za-z0-9]{4,}[A-Z])(@#+)";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    string product = match.Groups[3].Value;
                    string productGroup = string.Empty;

                    foreach (char chr in product)
                    {
                        if (char.IsDigit(chr))
                        {
                            productGroup += chr;
                        }
                    }
                    if (productGroup == string.Empty)
                    {
                        productGroup = "00";
                    }
                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
