using System;

namespace _7._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double totalMoney = 0;

            while (command != "Start")
            {
                double coin = double.Parse(command);

                if (coin == 0.1)
                {
                    totalMoney += coin;
                }
                else if (coin == 0.2)
                {
                    totalMoney += coin;
                }
                else if (coin == 0.5)
                {
                    totalMoney += coin;
                }
                else if (coin == 1)
                {
                    totalMoney += coin;
                }
                else if (coin == 2)
                {
                    totalMoney += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {

                if (command == "Nuts")
                {
                    if (totalMoney < 2.0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        totalMoney -= 2.0;
                        Console.WriteLine($"Purchased {command.ToLower()}");
                    }
                }
                else if (command == "Water")
                {
                    if (totalMoney < 0.7)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        totalMoney -= 0.7;
                        Console.WriteLine($"Purchased {command.ToLower()}");
                    }
                }
                else if (command == "Crisps")
                {
                    if (totalMoney < 1.5)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        totalMoney -= 1.5;
                        Console.WriteLine($"Purchased {command.ToLower()}");
                    }
                }
                else if (command == "Soda")
                {
                    if (totalMoney < 0.8)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        totalMoney -= 0.8;
                        Console.WriteLine($"Purchased {command.ToLower()}");
                    }
                }
                else if (command == "Coke")
                {
                    if (totalMoney < 1.0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        totalMoney -= 1.0;
                        Console.WriteLine($"Purchased {command.ToLower()}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}
