using System.Diagnostics;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region ugedageogkaffe
            int[] ugedage = { 5, 4, 3, 1, 6, 4, 4 };
            int total = 0; 

            //vi anvender længden af arrayet 'ugedage' til at 
            for(int i = 0; i < ugedage.Length; i++)
            {
                total += ugedage[i];
            }

            float gennemsnit = total / ugedage.Length;

            Debug.WriteLine($"Du drak {gennemsnit} kopper kaffe per dag");
            #endregion


            #region minefield
            int length = 5;
            int height = 5;
            float[,] minefield = new float[5, 5];

            for(var x = 0; x < length; x++)
            {
                for(var y = 0; y < height; y++)
                {
                    Random n = new Random();
                    minefield[x, y] = float.Round(n.NextSingle(), 3);
                    //Debug.WriteLine("X " + x + " Y " + y + " " + minefield[x, y]);
                }
            }

            string[] lines = new string[height];

            for (var x = 0; x < length; x++)
            {
                string line = "*"; 
                for (var y = 0; y < height; y++)
                {
                    char marker = 'o';
                    if (minefield[x,y] <= 0.1f)
                    {
                        marker = '*';
                    }

                    line += marker;
          
                }
                line += "*";
                lines[x] = line;
            }

            //foreach er en forlykke der løber alle variable af en type igennem i et array, hvor man ikke 
            //kender længde.... den giver dog mere mening ved lister
            foreach(string line in lines)
            {
                Debug.WriteLine(line);
            }

            #endregion

            #region dicefunction
            //Returnér en integer med en tilfældig værdi
            int RollDice()
            {
                Random r = new Random();
                return r.Next(1, 6);
            }

            #endregion
        }
    }
}
