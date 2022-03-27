using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string emojiPattern = @"((::)|(\*\*))(?<letters>[A-Z][a-z]{2,})\1";
            string digitsPatter = @"\d";
            uint coolThreshold = 1;
            List<string> coolEmojies = new List<string>();

            MatchCollection emojies = Regex.Matches(input, emojiPattern);
            MatchCollection digits = Regex.Matches(input, digitsPatter);

            foreach (Match digit in digits)
            {
                coolThreshold *= uint.Parse(digit.Value);
            }

            if (emojies.Count > 0)
            {
                foreach (Match emoji in emojies)
                {
                    string emojiText = emoji.Groups["letters"].Value;

                    int emojiCoolness = 0;
                    foreach (char chr in emojiText)
                    {
                        emojiCoolness += chr;
                    }
                    if (emojiCoolness > coolThreshold)
                    {
                        coolEmojies.Add(emoji.Value);
                    }
                }
            }
            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{emojies.Count} emojis found in the text. The cool ones are:{Environment.NewLine}{string.Join($"{Environment.NewLine}", coolEmojies)}");
        }
    }
}
