using System;
using System.Collections.Generic;

namespace _04._Orders
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string command = Console.ReadLine();

            while (command != "buy")
            {
                string productName = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0];
                double itemPrice = double.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
                int itemQuantity = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2]);

                if (products.ContainsKey(productName))
                {
                    if (products[productName].Price != itemPrice)
                    {
                        products[productName].Price = itemPrice;
                    }
                    products[productName].Quantity += itemQuantity;
                }
                else
                {
                    Product newProduct = new Product(productName, itemPrice, itemQuantity);
                    products.Add(productName, newProduct);
                }

                command = Console.ReadLine();
            }

            foreach (var prod in products)
            {
                Console.WriteLine($"{prod.Key} -> {prod.Value.Price * prod.Value.Quantity:f2}");
            }
        }
    }
}
class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, double price, int quantity)
    {
        this.Name = name;
        this.Price = price;
        this.Quantity = quantity;
    }
}
