using System;

namespace _01._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main()
        {
            int studentCount = int.Parse(Console.ReadLine());
            int lecturesNum = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            int maxAttendances = 0;
            double totalBonus = 0;

            for (int i = 0; i < studentCount; i++)
            {
                int currentAttendances = int.Parse(Console.ReadLine());

                if (currentAttendances > maxAttendances)
                {
                    maxAttendances = currentAttendances;
                }
            }

            if (studentCount == 0 || lecturesNum == 0)
            {
                totalBonus = 0;
            }
            else
            {
                totalBonus = Math.Round(maxAttendances / (double)lecturesNum * (5 + additionalBonus), MidpointRounding.ToPositiveInfinity);
            }


            Console.WriteLine($"Max Bonus: {totalBonus}.");
            Console.WriteLine($"The student has attended {maxAttendances} lectures.");
        }
    }
}
