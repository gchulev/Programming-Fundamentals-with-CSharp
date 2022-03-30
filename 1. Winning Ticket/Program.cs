using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _1._Winning_Ticket
{
    internal class Program
    {
        static void Main()
        {
            string winningTicketPattern = @"(?<symbolmatch>@{6,10})|(#{6,10})|(\${6,10})|(\^{6,10})|(&{6,10})";
            //string jackpotTicketPattern = @"([@#$^]{10})\1";
            List<string> tickets = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
            Regex rgx = new Regex(winningTicketPattern);

            if (tickets.Count > 0)
            {
                foreach (string ticket in tickets)
                {
                    if (ticket.Length != 20)
                    {
                        Console.WriteLine("invalid ticket");
                        continue;
                    }

                    Match leftMatch = rgx.Match(ticket.Substring(0, 10));
                    Match rightMatch = rgx.Match(ticket.Substring(10));

                    int minLen = Math.Min(leftMatch.Length, rightMatch.Length);

                    string leftSide = leftMatch.Value.Substring(0, minLen);
                    string rightSide = rightMatch.Value.Substring(0, minLen);

                    if (!leftMatch.Success || !rightMatch.Success)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                        continue;
                    }

                    if (leftSide.Equals(rightSide))
                    {
                        if (leftSide.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {leftSide.Length}{leftSide[0]} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {leftSide.Length}{leftSide[0]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                        continue;
                    }
                }
            }
        }
    }
}
