using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int[] bestSequence = new int[dnaLength];
            int bestSequenceSum = 0;
            int bestSequenceCntr = 0;
            int bestSequenceIndex = -1;
            int bestSequenceCount = 0;

            int currentSubSequenceIndex = -1;
            int sequenceCounter = 0;

            while (command != "Clone them!")
            {
                int[] sequence = command.Split('!', StringSplitOptions.RemoveEmptyEntries).ToArray().Select(int.Parse).ToArray();

                sequenceCounter++;

                int bestSubSequenceIndex = -1;
                int longestSubSequenceCntr = 0;
                int currentSubSequenceCntr = 1;

                if (sequence.Sum() > 0)
                {
                    for (int i = 0; i < sequence.Length; i++)
                    {
                        //skipping all 0's
                        if (sequence[i] > 0)
                        {
                            if (i == sequence.Length - 1)
                            {
                                if (longestSubSequenceCntr < currentSubSequenceCntr && currentSubSequenceCntr > 1)
                                {
                                    longestSubSequenceCntr = currentSubSequenceCntr;
                                    bestSubSequenceIndex = currentSubSequenceIndex;
                                }
                            }
                            else
                            {
                                if (sequence[i] == sequence[i + 1])
                                {
                                    if (currentSubSequenceCntr == 1)
                                    {
                                        currentSubSequenceIndex = i;
                                    }
                                    currentSubSequenceCntr++;
                                }
                                else
                                {
                                    if (longestSubSequenceCntr < currentSubSequenceCntr && currentSubSequenceCntr > 1)
                                    {
                                        longestSubSequenceCntr = currentSubSequenceCntr;
                                        bestSubSequenceIndex = currentSubSequenceIndex;
                                        currentSubSequenceCntr = 1;
                                    }
                                    else
                                    {
                                        currentSubSequenceCntr = 1;
                                    }
                                }
                            }
                        }

                    }
                    if (currentSubSequenceCntr < 1)
                    {
                        bestSequence = sequence;
                        bestSequenceCount = sequenceCounter;
                        bestSequenceSum = sequence.Sum();
                    }

                    if (bestSequenceCntr < longestSubSequenceCntr)
                    {
                        bestSequenceCntr = longestSubSequenceCntr;
                        bestSequenceIndex = bestSubSequenceIndex;
                        bestSequence = sequence;
                        bestSequenceCount = sequenceCounter;
                        bestSequenceSum = bestSequence.Sum();

                    }
                    else if (bestSequenceCntr == longestSubSequenceCntr && bestSequenceIndex > bestSubSequenceIndex)
                    {
                        bestSequenceIndex = bestSubSequenceIndex;
                        bestSequence = sequence;
                        bestSequenceCount = sequenceCounter;
                        bestSequenceSum = bestSequence.Sum();
                    }
                    else if (bestSequenceCntr == longestSubSequenceCntr && bestSequenceIndex == bestSubSequenceIndex)
                    {
                        int currentBestSum = bestSequence.Sum();
                        int currentSequenceSum = sequence.Sum();

                        if (currentBestSum < currentSequenceSum)
                        {
                            bestSequence = sequence;
                            bestSequenceCount = sequenceCounter;
                            bestSequenceSum = currentSequenceSum;
                        }
                    }
                }
                else
                {
                    //this means that all sequences are from 0's without any 1' eg. 0!0!0!0 - skipping all 0 sequences
                    if (bestSequenceCount == 0)
                    {
                        bestSequenceCount = sequenceCounter;
                        bestSequence = sequence;
                        bestSequenceSum = sequence.Sum();
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSequenceCount} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(' ', bestSequence));
        }
    }
}
