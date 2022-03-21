using System;

namespace _01._SoftUni_Reception
{
    internal class Program
    {
        static void Main()
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int totalStudenCount = int.Parse(Console.ReadLine());

            int totalHelpPerHr = firstEmployee + secondEmployee + thirdEmployee;
            int hourCtr = 0;

            while (totalStudenCount > 0)
            {
                totalStudenCount -= totalHelpPerHr;
                hourCtr++;

                if (hourCtr % 4 == 0 && hourCtr != 0)
                {
                    hourCtr++;
                }
            }

            Console.WriteLine($"Time needed: {hourCtr}h.");
        }
    }
}
