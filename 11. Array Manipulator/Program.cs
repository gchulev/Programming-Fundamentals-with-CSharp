using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main()
        {
            int[] inputArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            int maxEvenIndex = -1;
            int maxOddIndex = -1;
            int minEvenIndex = -1;
            int minOddIndex = -1;

            while (command != "end")
            {
                //Exchange logic
                if (command.Split()[0] == "exchange")
                {
                    int index = int.Parse(command.Split()[1]);

                    if (index >= 0 && index < inputArr.Length)
                    {
                        int[] exchangeArr = new int[inputArr.Length];

                        for (int i = 0; i < inputArr.Length; i++)
                        {
                            if (i < inputArr.Length - (index + 1))
                            {
                                exchangeArr[i] = inputArr[index + 1 + i];
                            }
                            else
                            {
                                exchangeArr[i] = inputArr[i - (inputArr.Length - (index + 1))];
                            }
                        }
                        inputArr = exchangeArr;
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                //min and max odd and even logic
                else if (command.Split()[0] == "max")
                {
                    //Max even logic
                    if (command.Split()[1] == "even")
                    {
                        int currentMaxEvenNum = -1;

                        for (int i = 0; i < inputArr.Length; i++)
                        {
                            if (inputArr[i] % 2 == 0)
                            {
                                if (currentMaxEvenNum <= inputArr[i])
                                {
                                    currentMaxEvenNum = inputArr[i];
                                    maxEvenIndex = i;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        if (maxEvenIndex < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine($"{maxEvenIndex}");
                        }
                    }
                    //Max odd logic
                    else if (command.Split()[1] == "odd")
                    {
                        int currentMaxOddNum = -1;

                        for (int i = 0; i < inputArr.Length; i++)
                        {
                            if (inputArr[i] % 2 != 0)
                            {
                                if (currentMaxOddNum <= inputArr[i])
                                {
                                    currentMaxOddNum = inputArr[i];
                                    maxOddIndex = i;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        if (maxOddIndex < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine($"{maxOddIndex}");
                        }
                    }
                }
                //min odd and even logic
                else if (command.Split()[0] == "min")
                {
                    //Min even logic
                    if (command.Split()[1] == "even")
                    {
                        int currentMinEvenNum = int.MaxValue;
                        for (int i = 0; i < inputArr.Length; i++)
                        {
                            if (inputArr[i] % 2 == 0)
                            {
                                if (currentMinEvenNum >= inputArr[i])
                                {
                                    currentMinEvenNum = inputArr[i];
                                    minEvenIndex = i;
                                }
                            }
                        }
                        if (minEvenIndex < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine($"{minEvenIndex}");
                        }
                    }
                    //Min odd logic
                    else if (command.Split()[1] == "odd")
                    {
                        int currentMinOddNum = int.MaxValue;

                        for (int i = 0; i < inputArr.Length; i++)
                        {
                            if (inputArr[i] != 0)
                            {
                                if (currentMinOddNum >= inputArr[i])
                                {
                                    currentMinOddNum = inputArr[i];
                                    minOddIndex = i;
                                }
                            }
                        }
                        if (minOddIndex < 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine($"{minOddIndex}");
                        }
                    }
                }
                //logic for first and last odd and even {count}
                else if (command.Split()[0] == "first")
                {
                    //first even
                    if (command.Split()[2] == "even")
                    {
                        string[] firstEvenArr = new string[int.Parse(command.Split()[1])];

                        if (int.Parse(command.Split()[1]) <= inputArr.Length)
                        {
                            int counter = 0;
                            foreach (var item in inputArr)
                            {
                                if (counter < int.Parse(command.Split()[1]))
                                {
                                    if (item % 2 == 0)
                                    {
                                        firstEvenArr[counter] = item.ToString();
                                        counter++;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }

                            if (firstEvenArr.All(x => x == null || x == string.Empty))
                            {
                                Console.WriteLine("[]");
                            }
                            else if (firstEvenArr.Any(x => x != null || x != string.Empty))
                            {
                                Console.WriteLine($"[{string.Join(", ", firstEvenArr.Where(x => !string.IsNullOrEmpty(x)))}]");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                    }
                    //first odd
                    else if (command.Split()[2] == "odd")
                    {
                        string[] firstOddArr = new string[int.Parse(command.Split()[1])];

                        if (int.Parse(command.Split()[1]) <= inputArr.Length)
                        {
                            int counter = 0;
                            foreach (var item in inputArr)
                            {
                                if (counter < int.Parse(command.Split()[1]))
                                {
                                    if (item % 2 != 0)
                                    {
                                        firstOddArr[counter] = item.ToString();
                                        counter++;
                                    }
                                }
                            }
                            if (firstOddArr.All(x => x == null || x == string.Empty))
                            {
                                Console.WriteLine("[]");
                            }
                            else if (firstOddArr.Any(x => !string.IsNullOrEmpty(x)))
                            {
                                Console.WriteLine($"[{string.Join(", ", firstOddArr.Where(x => !string.IsNullOrEmpty(x)))}]");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                    }
                }
                else if (command.Split()[0] == "last")
                {
                    //last even
                    if (command.Split()[2] == "even")
                    {
                        int counter = 0;
                        int tempArrayLength = int.Parse(command.Split()[1]);

                        if (tempArrayLength <= inputArr.Length)
                        {
                            string[] tempArray = new string[tempArrayLength];

                            for (int i = inputArr.Length - 1; i >= 0; i--)
                            {
                                if (counter < tempArrayLength)
                                {
                                    if (inputArr[i] % 2 == 0)
                                    {
                                        tempArray[tempArrayLength - 1 - counter] = inputArr[i].ToString();
                                        counter++;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                            if (tempArray.All(x => x == null))
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", tempArray.Where(x => x != null))}]");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }

                    }
                    //last odd
                    else if (command.Split()[2] == "odd")
                    {
                        int counter = 0;
                        int tempArrayLength = int.Parse(command.Split()[1]);

                        if (tempArrayLength <= inputArr.Length)
                        {
                            string[] tempArray = new string[tempArrayLength];

                            for (int i = inputArr.Length - 1; i >= 0; i--)
                            {
                                if (counter < tempArrayLength)
                                {
                                    if (inputArr[i] % 2 != 0)
                                    {
                                        tempArray[tempArrayLength - 1 - counter] = inputArr[i].ToString();
                                        counter++;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                            if (tempArray.All(x => x == null))
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", tempArray.Where(x => x != null))}]");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", inputArr)}]");
        }

        //TODO: put all logic in separate methods
        //Exchange index logic
        public static string ExchangeIndex(string command)
        {
            int[] inputArr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            if (command.Split()[0] == "exchange")
            {
                int index = int.Parse(command.Split()[1]);

                if (index >= 0 && index < inputArr.Length)
                {
                    int[] exchangeArr = new int[inputArr.Length];

                    for (int i = 0; i < inputArr.Length; i++)
                    {
                        if (i < inputArr.Length - (index + 1))
                        {
                            exchangeArr[i] = inputArr[index + 1 + i];
                        }
                        else
                        {
                            exchangeArr[i] = inputArr[i - (inputArr.Length - (index + 1))];
                        }
                    }
                }
                else
                {
                    return "Invalid Index";
                }
            }
            return string.Empty;
        }
    }
}
