using System;
using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int bombPower = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChr = input[i];

                if (currentChr == '>')
                {
                    sb.Append(currentChr);
                    int currentBombPower = input[i + 1] - '0';
                    bombPower += currentBombPower;
                }
                else
                {
                    if (bombPower > 0)
                    {
                        bombPower--;
                    }
                    else
                    {
                        sb.Append(currentChr);
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
