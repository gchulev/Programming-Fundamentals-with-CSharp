using System;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main()
        {
            int nrOfHeroes = int.Parse(Console.ReadLine());
            List<Hero> heroes = new List<Hero>();

            for (int i = 0; i < nrOfHeroes; i++)
            {
                string heroToAdd = Console.ReadLine();
                string name = heroToAdd.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0];
                int hp = int.Parse(heroToAdd.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
                int mp = int.Parse(heroToAdd.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2]);
                heroes.Add(new Hero(name, hp, mp));
            }

            string action = Console.ReadLine();

            while (action != "End")
            {
                if (action.Contains("CastSpell"))
                {
                    string heroName = action.Split(" - ", StringSplitOptions.RemoveEmptyEntries)[1];
                    int mpNeeded = int.Parse(action.Split(" - ", StringSplitOptions.RemoveEmptyEntries)[2]);
                    string spellName = action.Split(" - ", StringSplitOptions.RemoveEmptyEntries)[3];
                    Hero hero = heroes.Find(x => x.Name.Equals(heroName));

                    if (hero.Manapoints >= mpNeeded)
                    {
                        hero.Manapoints -= mpNeeded;
                        Console.WriteLine($"{hero.Name} has successfully cast {spellName} and now has {hero.Manapoints} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{hero.Name} does not have enough MP to cast {spellName}!");
                    }

                }
                else if (action.Contains("TakeDamage"))
                {
                    string heroName = action.Split(" - ", StringSplitOptions.RemoveEmptyEntries)[1];
                    int damage = int.Parse(action.Split(" - ", StringSplitOptions.RemoveEmptyEntries)[2]);
                    string attacker = action.Split(" - ", StringSplitOptions.RemoveEmptyEntries)[3];
                    Hero hero = heroes.Find(x => x.Name.Equals(heroName));

                    hero.Hitpoints -= damage;

                    if (hero.Hitpoints <= 0)
                    {
                        Console.WriteLine($"{hero.Name} has been killed by {attacker}!");
                        heroes.Remove(hero);
                    }
                    else
                    {
                        Console.WriteLine($"{hero.Name} was hit for {damage} HP by {attacker} and now has {hero.Hitpoints} HP left!");
                    }
                }
                else if (action.Contains("Recharge"))
                {
                    string heroName = action.Split(" - ", StringSplitOptions.RemoveEmptyEntries)[1];
                    int ammount = int.Parse(action.Split(" - ", StringSplitOptions.RemoveEmptyEntries)[2]);
                    Hero hero = heroes.Find(x => x.Name.Equals(heroName));
                    int mpRecovered = 0;

                    if (hero.Manapoints + ammount > 200)
                    {
                        mpRecovered = 200 - hero.Manapoints;
                        hero.Manapoints = 200;
                    }
                    else
                    {
                        mpRecovered = ammount;
                        hero.Manapoints += ammount;
                    }
                    Console.WriteLine($"{hero.Name} recharged for {mpRecovered} MP!");
                }
                else if (action.Contains("Heal"))
                {
                    string heroName = action.Split(" - ", StringSplitOptions.RemoveEmptyEntries)[1];
                    int ammount = int.Parse(action.Split(" - ", StringSplitOptions.RemoveEmptyEntries)[2]);
                    Hero hero = heroes.Find(x => x.Name.Equals(heroName));
                    int hpRecovered = 0;

                    if (hero.Hitpoints + ammount > 100)
                    {
                        hpRecovered = 100 - hero.Hitpoints;
                        hero.Hitpoints = 100;
                    }
                    else
                    {
                        hpRecovered = ammount;
                        hero.Hitpoints += ammount;
                    }
                    Console.WriteLine($"{hero.Name} healed for {hpRecovered} HP!");
                }
                action = Console.ReadLine();
            }
            foreach (Hero hero in heroes)
            {
                Console.WriteLine($"{hero.Name}{Environment.NewLine}  HP: {hero.Hitpoints}{Environment.NewLine}  MP: {hero.Manapoints}");
            }
        }
    }
    class Hero
    {
        public string Name { get; set; }
        public int Hitpoints { get; set; }
        public int Manapoints { get; set; }

        public Hero(string name, int hp, int mp)
        {
            Name = name;
            Hitpoints = hp;
            Manapoints = mp;
        }
    }
}
