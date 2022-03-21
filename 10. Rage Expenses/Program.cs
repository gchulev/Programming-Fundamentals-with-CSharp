using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadset = 0;
            int trashedMouse = 0;
            int trashedKeyboard = 0;
            int trashedDisplay = 0;
            

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    trashedHeadset++;
                }
                if (i % 3 == 0)
                {
                    trashedMouse++;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    trashedKeyboard++;
                }
                if (i % 2 == 0 && i % 3 == 0 && trashedKeyboard % 2 == 0)
                {
                    trashedDisplay++;
                }
            }

            double expenses = headsetPrice * trashedHeadset + mousePrice * trashedMouse + keyboardPrice * trashedKeyboard + displayPrice * trashedDisplay;

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
