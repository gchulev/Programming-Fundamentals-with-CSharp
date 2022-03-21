using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> inputList = new List<string>();
            Dictionary<string, int> outputList = new Dictionary<string, int>();

            while (input != "stop")
            {
                inputList.Add(input);
                input = Console.ReadLine();
            }

            for (int i = 0; i < inputList.Count; i += 2)
            {
                if (i % 2 == 0)
                {
                    if (outputList.ContainsKey(inputList[i]))
                    {
                        int newQuantity = outputList[inputList[i]] + int.Parse(inputList[i + 1]);
                        outputList[inputList[i]] = newQuantity;
                    }
                    else
                    {
                        outputList.Add(inputList[i], int.Parse(inputList[i + 1]));
                    }
                }
            }

            foreach (KeyValuePair<string, int> keyValuePair in outputList)
            {
                Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");
            }
        }
    }
}
