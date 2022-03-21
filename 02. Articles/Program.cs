using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    internal class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();
            int n = int.Parse(Console.ReadLine());

            Article article = new Article();
            article.Title = input[0];
            article.Content = input[1];
            article.Author = input[2];

            for (int i = 0; i < n; i++)
            {
                string[] commandArr = Console.ReadLine().Split(": ").ToArray();
                string command = commandArr[0];
                string content = commandArr[1];

                if (command == "Edit")
                {
                    article.Edit(content);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(content);
                }
                else if (command == "Rename")
                {
                    article.Rename(content);
                }

            }

            Console.WriteLine(article.ToString(article.Title, article.Content, article.Author));
        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article()
        {

        }
        public void Edit(string content)
        {
            Content = content;
        }
        public void ChangeAuthor(string author)
        {
            Author = author;
        }
        public void Rename(string title)
        {
            Title = title;
        }
        public string ToString(string itemOne, string itemTwo, string itemTree)
        {
            return $"{itemOne} - {itemTwo}: {itemTree}";
        }
    }
}
