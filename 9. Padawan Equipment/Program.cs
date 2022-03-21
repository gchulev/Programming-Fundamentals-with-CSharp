using System;

namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightSaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double totalLightSabersMoney = lightSaberPrice * Math.Ceiling((studentsCount * 0.1) + studentsCount);
            double totalRobesMoney = studentsCount * robePrice;
            double totalBeltsMoney;

            if (studentsCount > 6)
            {
                totalBeltsMoney = beltPrice * (studentsCount - (studentsCount / 6));
            }
            else
            {
                totalBeltsMoney = beltPrice * studentsCount;
            }

            double moneyNeeded = totalBeltsMoney + totalLightSabersMoney + totalRobesMoney;

            if (money >= moneyNeeded)
            {
                Console.WriteLine($"The money is enough - it would cost {moneyNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {moneyNeeded - money:f2}lv more.");
            }

        }
    }
}
