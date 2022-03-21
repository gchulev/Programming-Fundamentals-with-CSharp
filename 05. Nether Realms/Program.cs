using System;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string healthPattern = @"[^0-9+\-*/.]";
            string baseDamagePatternDigits = @"(-?\d*)(\d+(\.\d+)?)";
            string baseDamagePatternSpecialSimbols = @"(?<star>\*?)(?<forwardslash>\/?)";
        }
    }
}
