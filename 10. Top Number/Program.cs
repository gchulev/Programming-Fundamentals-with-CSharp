using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());
            string result = string.Empty;

            for (int i = 1; i <= endOfRange; i++)
            {
                string input = i.ToString();

                if (DivisibleCheck(input) && CheckForOddNum(input))
                {
                    result += input + "\n";
                }
            }
            Console.WriteLine(result);
        }
        public static bool DivisibleCheck(string input)
        {
            int sum = 0;

            foreach (char item in input)
            {
                sum += int.Parse(item.ToString());
            }

            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckForOddNum(string input)
        {
            bool hasOddNum = false;

            foreach (char item in input)
            {
                if (int.Parse(item.ToString()) % 2 != 0)
                {
                    hasOddNum = true;
                    break;
                }
                else
                {
                    hasOddNum = false;
                }
            }
            return hasOddNum;
        }
    }
}
