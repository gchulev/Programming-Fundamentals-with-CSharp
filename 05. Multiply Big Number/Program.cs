using System;
using System.Linq;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main()
        {
            string numOne = Console.ReadLine().Trim();
            string numTwoInput = Console.ReadLine().Trim();
            int numTwo = string.IsNullOrEmpty(numTwoInput) ? 0 : int.Parse(numTwoInput);
            numOne = numOne.StartsWith('0') && numOne.Length > 1 ? numOne.Trim('0') : numOne;

            StringBuilder sb = new StringBuilder();
            int numToKeep = 0;
            int numToappend = 0;

            if (numOne == string.Empty)
            {
                Console.WriteLine(numOne);
                return;
            }

            //division by zero
            if (numTwo == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = numOne.Length - 1; i >= 0; i--)
            {
                int multiplication = int.Parse(numOne[i].ToString()) * numTwo;

                if (i == 0)
                {
                    numToappend = multiplication + numToKeep;
                    sb.Append(new string(numToappend.ToString().Reverse().ToArray()));
                }
                else
                {
                    numToappend = (multiplication + numToKeep) % 10;
                    numToKeep = (multiplication + numToKeep) / 10;
                    sb.Append(numToappend);
                }
            }
            string result = new string(sb.ToString().Reverse().ToArray());
            Console.WriteLine(result);
        }
    }
}
