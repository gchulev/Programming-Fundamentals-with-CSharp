using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articlesList = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ").ToArray();
                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article article = new Article()
                {
                    Title = title,
                    Content = content,
                    Author = author
                };
                articlesList.Add(article);
            }

            string command = Console.ReadLine();

            if (command == "title")
            {
                articlesList.Sort((x, y) => string.Compare(x.Title, y.Title));
            }
            else if (command == "content")
            {
                articlesList.Sort((x, y) => string.Compare(x.Content, y.Content));
            }
            else if (command == "author")
            {
                articlesList.Sort((x, y) => string.Compare(x.Author, y.Author));
            }

            foreach (Article item in articlesList)
            {
                Console.WriteLine(item.ToString(item.Title, item.Content, item.Author));
            }
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
        public string ToString(string itemOne, string itemTwo, string itemTree)
        {
            return $"{itemOne} - {itemTwo}: {itemTree}";
        }
    }
}
