using System;
using System.Linq;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        public static object Stringbuilder { get; private set; }

        static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                string currentLetter = input[i].ToString();
                if (i == input.Length - 1)
                {
                    sb.Append(input[i]);
                }
                else
                {
                    if (input[i + 1].ToString() != currentLetter)
                    {
                        sb.Append(currentLetter);
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
