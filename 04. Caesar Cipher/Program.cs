using System;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                int charNum = chars[i] + 3;
                chars[i] = (char)charNum;
            }
            chars.ToString();
            Console.WriteLine(chars);
        }
    }
}
