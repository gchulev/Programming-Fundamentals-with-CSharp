using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Followers
{
    internal class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            List<Follower> followersList = new List<Follower>();

            while (command != "Log out")
            {
                if (command.Contains("New follower"))
                {
                    string name = command.Split(": ", StringSplitOptions.RemoveEmptyEntries)[1];
                    if (!followersList.Exists(x => x.FollowerName.Equals(name)))
                    {
                        followersList.Add(new Follower(name, 0, 0));
                    }
                }
                else if (command.Contains("Like"))
                {
                    string name = command.Split(": ", StringSplitOptions.RemoveEmptyEntries)[1];
                    int count = int.Parse(command.Split(": ", StringSplitOptions.RemoveEmptyEntries)[2]);

                    if (!followersList.Exists(x => x.FollowerName.Equals(name)))
                    {
                        followersList.Add(new Follower(name, 0, 0));
                    }
                    Follower currentFollower = followersList.Find(x => x.FollowerName.Equals(name));
                    currentFollower.Likes += count;
                }
                else if (command.Contains("Comment"))
                {
                    string name = command.Split(": ", StringSplitOptions.RemoveEmptyEntries)[1];

                    if (!followersList.Exists(x => x.FollowerName.Equals(name)))
                    {
                        followersList.Add(new Follower(name, 0, 0));
                    }
                    Follower currentFollower = followersList.Find(x => x.FollowerName.Equals(name));
                    currentFollower.Comments++;
                }
                else if (command.Contains("Blocked"))
                {
                    string name = command.Split(": ", StringSplitOptions.RemoveEmptyEntries)[1];

                    if (!followersList.Exists(x => x.FollowerName.Equals(name)))
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }
                    else
                    {
                        followersList.Remove(followersList.Find(x => x.FollowerName.Equals(name)));
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{followersList.Count} followers");

            foreach (Follower follower in followersList)
            {
                Console.WriteLine($"{follower.FollowerName}: {follower.Likes + follower.Comments}");
            }
        }
    }

    class Follower
    {
        public string FollowerName { get; set; }
        public int Likes { get; set; }
        public int Comments { get; set; }

        public Follower(string name, int likes, int comments)
        {
            FollowerName = name;
            Likes = likes;
            Comments = comments;
        }
    }
}
