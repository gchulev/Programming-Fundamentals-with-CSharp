using System;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double totalSum = 0;

            foreach (string str in input)
            {
                string startingLetter = string.Empty;
                string endingLetter = string.Empty;
                string digit = string.Empty;

                for (int i = 0; i < str.Length; i++)
                {

                    if (char.IsLetter(str[i]))
                    {
                        // do this only after the first element
                        if (i > 0)
                        {
                            if (char.IsDigit(str[i - 1]))
                            {
                                endingLetter = str[i].ToString();
                                break;
                            }
                            else
                            {
                                startingLetter = str[i].ToString();
                            }
                        }
                        else
                        {
                            startingLetter = str[i].ToString();
                        }
                    }
                    else if (char.IsDigit(str[i]))
                    {
                        digit += str[i].ToString();
                    }
                }

                double currentResult = 0;
                char startingChar = char.Parse(startingLetter);
                char endingChar = char.Parse(endingLetter);
                double number = double.Parse(digit);

                if (char.IsLower(startingChar))
                {
                    int currentAlphabetPos = char.ToUpper(startingChar) - 64;
                    currentResult = number * currentAlphabetPos; //the char is lower case
                }
                else
                {
                    int currentAlphabetPos = char.ToUpper(startingChar) - 64;
                    currentResult = number / currentAlphabetPos; //the char is upper case
                }
                if (char.IsLower(endingChar))
                {
                    int currentAlphabetPos = char.ToUpper(endingChar) - 64;
                    currentResult += currentAlphabetPos; //lower case
                }
                else
                {
                    int currentAlphabetPos = char.ToUpper(endingChar) - 64;
                    currentResult -= currentAlphabetPos; //upper case
                }

                totalSum += currentResult;
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
