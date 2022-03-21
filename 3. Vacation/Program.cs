using System;

namespace _3._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            double priceForPerson = 0;
            double totalPrice = 0;

            if (groupType == "Students")
            {
                if (day == "Friday")
                {
                    priceForPerson = 8.45;
                }
                else if (day == "Saturday")
                {
                    priceForPerson = 9.80;
                }
                else if (day == "Sunday")
                {
                    priceForPerson = 10.46;
                }

                totalPrice = priceForPerson * groupCount;

                if (groupCount >= 30)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }
            else if (groupType == "Business")
            {
                if (day == "Friday")
                {
                    priceForPerson = 10.90;
                }
                else if (day == "Saturday")
                {
                    priceForPerson = 15.6;
                }
                else if (day == "Sunday")
                {
                    priceForPerson = 16;
                }

                totalPrice = priceForPerson * groupCount;

                if (groupCount >= 100)
                {
                    totalPrice = priceForPerson * (groupCount - 10);
                }
            }
            else if (groupType == "Regular")
            {
                if (day == "Friday")
                {
                    priceForPerson = 15;
                }
                else if (day == "Saturday")
                {
                    priceForPerson = 20;
                }
                else if (day == "Sunday")
                {
                    priceForPerson = 22.5;
                }

                totalPrice = priceForPerson * groupCount;

                if (groupCount >= 10 && groupCount <= 20)
                {
                    totalPrice -= totalPrice * 0.05;
                }
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
