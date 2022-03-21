using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tankCapacity = 255;
            int currentFilledCapacity = 0;
            
            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (tankCapacity >= liters + currentFilledCapacity)
                {
                    currentFilledCapacity += liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(currentFilledCapacity);
        }
    }
}
