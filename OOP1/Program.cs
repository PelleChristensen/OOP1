using OOP1.containers;
using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Backpack bp = new Backpack(10);

            Ration r = new Ration();
            Ration r2 = new Ration();
            Rope rope = new Rope(10); 
            Wand w = new Wand();

            bp.AddItem(r);
            bp.AddItem(r2);
            bp.AddItem(rope);
            bp.AddItem(w);

            Console.WriteLine("Rations in backpack:" + bp.CountItems(w)) ;

            Player hero = new Player("siegfried", 20);

            Console.WriteLine(hero.playername + " has " + hero.Health + " health");
            
            if(bp.CountItems(new Ration()) > 0)
            {
                Ration newration = bp.GetRation();
                hero.UpdateHealth(newration.Energy);
            }

            Console.WriteLine(hero.playername + " has " + hero.Health + " health");

            return;

            //Player hero = new Player("siegfried", 20);
            Player enemy = new Player("Fafnir", 50);

            Console.WriteLine(hero + " and " + enemy + " finally faced off!");
            Console.WriteLine(hero + ": You shall taste my steel, monster!");
            Console.WriteLine(enemy + ": *Homicidal roar*");

            do
            {
                int heroattack = RollDice(1);
                int enemyattack = RollDice(2);
                int damage = 0;

                Console.WriteLine("Hero attack: " + heroattack + " enemyattack: " + enemyattack);
                if(heroattack > enemyattack)
                {
                    Console.WriteLine(enemy + " roars as " + hero + " sinks the sword in");
                    enemy.UpdateHealth(-2);
                } else if (heroattack == enemyattack)
                {
                    Console.WriteLine("the two combatants avoids each others strikes");
                } else
                {
                    Console.WriteLine(enemy.playername + " bites deep into " + hero.playername);
                    hero.UpdateHealth(-2);
                }

            } while (!hero.IsDead() && !enemy.IsDead());

            if(hero.IsDead() && enemy.IsDead())
            {
                Console.WriteLine(enemy.playername + " and " + hero.playername + "both died ....... BOOO");
            } else if(hero.IsDead())
            {
                Console.WriteLine(enemy.playername + " kills " + hero.playername);
            } 
            else
            {
                Console.WriteLine(hero.playername + " kills " + enemy.playername);
            }


            int RollDice(int amount = 1)
            {
                Random r = new Random();
                int result = 0;
                int index = 0;

                while (index < amount)
                {
                    result += r.Next(1, 7);
                    index++;
                } 

                return result;
            }
        }
    }
}
