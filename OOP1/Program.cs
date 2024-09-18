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

            Player hero = new Player("siegfried", 20);
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
