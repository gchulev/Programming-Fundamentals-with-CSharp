using System;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(",",StringSplitOptions.RemoveEmptyEntries);
            string healthPattern = @"[^0-9+\-*/.]";
            string baseDamagePatternDigits = @"(-?\d*)(\d+(\.\d+)?)";
            string baseDamagePatternSpecialSimbols = @"[*/]";

            foreach (string deamon in input)
            {
                //TODO: logic implementation
            }
            //TODO: another test
        }
    }
}
