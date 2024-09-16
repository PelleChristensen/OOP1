namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ugedage = ​{ 7, 5, 3, 3, 5, 1, 6 }; int kaffetotal = 0;

            //array.Length angiver antallet af arrayelementerfor(int i = 0; i < ugedage.Length; i++)​
            {​	kaffetotal += ugedage[i]; ​
}
            //Dette er branch for loops og de eksempler som dertil kommer
            #region startkode
            //Whack that hero
            int health = 55;
            int enemydamage = 8;
            int armor = 8;
            int attacks = 12;

            for (int i = 0; i <= attacks; i++)
            {
                int damage = enemydamage – i;
                if(damage <= 0)
                {
                    Console.WriteLine("Fjenden er løbet tør for energi");
                    break;

                }
                health -= damage;

            }

            if (health < 20)
            {
                //Enemy surrenders, make win stuff
            }
            else
            {
                Console.Write(“Hah! Puny hero, hits like a bunny!”); //implement game over
            }

            #endregion

            #region while løkke
            //Der bliver angrebet hvis betingelsen er opfyldt
            while (health > 10)
            {
                int damage = enemydamage - armor;
                if (damage > 0)
                {
                    //register damage and make feedback to user
                    health -= damage;
                    Console.WriteLine("***************************************************");
                    Console.WriteLine("*  The enemy causes " + damage + "damage to hero  *");
                    Console.WriteLine("***************************************************");
                }
                else
                {
                    Console.WriteLine("***************************************************");
                    Console.WriteLine("*       The enemy causes no damage on hero        *");
                    Console.WriteLine("***************************************************");
                }
            }

            #endregion

            #region do-while løkke
            //der bliver angrebet først og tjekket efter betingelse bagefter. 
            do
            {
                int damage = enemydamage - armor;

            } while (health > 0);

            #endregion

            #region for-loop 

            int attacks = 40;
            int totaldamage = 0;

            for (int i = 0; i <= attacks; i++)
            {
                totaldamage = armor - enemydamage;
            }

            Console.WriteLine("***************************************************");
            Console.WriteLine("*  The hero receives " + totaldamage + "  damage  *");
            Console.WriteLine("***************************************************");
            #endregion

            #region guess a number
            //minispil "gæt et tal"
            Random random = new Random();
            int answer = random.Next(0, 10); //svaret bliver et tal imellem 0 og 10; 
            bool gamecomplete = false;
            do
            {
                Console.WriteLine("Sæt på et tal imellem 0 og 10");
                string response = Console.ReadLine();
                int guess;
                bool isInteger = Int32.TryParse(response, out guess);

                if (isInteger)
                {
                    if (guess == answer)
                    {
                        Console.WriteLine("Dit svar er korrekt! du har vundet!");
                    }
                    else
                    {
                        Console.WriteLine("Svaret er forkert! Prøv igen!");
                    }
                }
                else
                {
                    Console.WriteLine("Ugyldigt svar. Prøv igen");
                }
            } while (!gamecomplete);

            #endregion

            #region dicefunction
            //Returnér en integer med en tilfældig værdi
            int RollDice()
            {
                Random r = new Random();
                return r.Next(1, 6);
            }

            #region
        }
    }
}
