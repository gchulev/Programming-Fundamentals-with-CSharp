using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            List<Person> listOfPeople = new List<Person>();

            while (command != "End")
            {
                string name = command.Split(' ')[0];
                string id = command.Split(' ')[1];
                int age = int.Parse(command.Split(' ')[2]);

                if (listOfPeople.Any(q => q.Id == id))
                {
                    listOfPeople.Find(x => x.Id == id).Name = name;
                    listOfPeople.Find(x => x.Id == id).Age = age;

                }
                else
                {
                    listOfPeople.Add(new Person { Id = id, Name = name, Age = age });
                }

                command = Console.ReadLine();
            }
            var orderedList = listOfPeople.OrderBy(x => x.Age);

            foreach (Person person in orderedList)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
}
