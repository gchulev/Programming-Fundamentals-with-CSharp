using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    internal class Program
    {
        static void Main()
        {
            List<Piece> pieceCollection = new List<Piece>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('|');
                string pieceName = input[0];
                string author = input[1];
                string key = input[2];

                pieceCollection.Add(new Piece(pieceName, author, key));
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                if (command.Contains("Add"))
                {
                    string[] input = command.Split('|');
                    string pieceName = input[1];
                    string author = input[2];
                    string key = input[3];

                    if (!pieceCollection.Exists(x => x.PieceName == pieceName))
                    {
                        pieceCollection.Add(new Piece(pieceName, author, key));

                        Console.WriteLine($"{pieceName} by {author} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{ pieceName } is already in the collection!");
                    }
                }
                else if (command.Contains("Remove"))
                {
                    string pieceName = command.Split('|')[1];

                    if (pieceCollection.Exists(x => x.PieceName == pieceName))
                    {
                        Piece pieceToRemove = pieceCollection.Find(x => x.PieceName.Equals(pieceName));
                        pieceCollection.Remove(pieceToRemove);

                        Console.WriteLine($"Successfully removed {pieceToRemove.PieceName}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }
                else if (command.Contains("ChangeKey"))
                {
                    string[] input = command.Split('|');
                    string pieceName = input[1];
                    string newKey = input[2];

                    if (pieceCollection.Exists(x => x.PieceName.Equals(pieceName)))
                    {
                        Piece pieceToEdit = pieceCollection.Find(x => x.PieceName.Equals(pieceName));
                        pieceToEdit.Key = newKey;

                        Console.WriteLine($"Changed the key of {pieceName} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }

                command = Console.ReadLine();
            }

            foreach (Piece piece in pieceCollection)
            {
                Console.WriteLine($"{piece.PieceName} -> Composer: {piece.Author}, Key: {piece.Key}");
            }
        }
    }
    internal class Piece
    {
        public Piece(string peaceName, string author, string key)
        {
            PieceName = peaceName;
            Author = author;
            Key = key;
        }
        public string PieceName { get; set; }
        public string Author { get; set; }
        public string Key { get; set; }
    }
}
