using System.Diagnostics;
using System.Text;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            #region ugedageogkaffe
            int[] ugedage = { 5, 4, 3, 5, 6, 6, 4 };
            int total = 0; 

            //vi anvender længden af arrayet 'ugedage' til at 
            for(int i = 0; i < ugedage.Length; i++)
            {
                total += ugedage[i];
            }

            float gennemsnit = total / ugedage.Length;

            Debug.WriteLine($"Du drak {gennemsnit} kopper kaffe per dag");
            #endregion
            */


            #region minefield
            
            int length = 5;
            int height = 5;
            float[,] minefield = new float[5, 5];
            Random n = new Random();
            for (int x = 0; x < length; x++)
            {
                for(int y = 0; y < height; y++)
                {
                    minefield[x, y] = float.Round(n.NextSingle(), 3);
                    //Console.WriteLine("X " + x + " Y " + y + " " + minefield[x, y]);
                }
            }

            List<string> lines = new List<string>();
            string topline = "*******";

            lines.Add(topline);
            
            for (var x = 0; x < length; x++)
            {
                string line = "*"; 
                for (var y = 0; y < height; y++)
                {
                    char marker = 'o';
                    if (minefield[x,y] <= 0.1f)
                    {
                        marker = 'ø';
                    }
                    line += marker;
                }
                line += "*";
                lines.Add(line);
               
            }
            lines.Add(topline);

            //foreach er en forlykke der løber alle variable af en type igennem i et array, hvor man ikke 
            //kender længde.... den giver dog mere mening ved lister
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            

            #endregion

            #region kryptering 

            int positionsskift = 3; 
            string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÆØÅ1234567890";

            //eksempel på at bruge en string i et array
            string hilsen = "hello";
            bool makeBig = false;
            string bigHello = "";

            StringBuilder result = new StringBuilder(); 
            for (var i = 0; i < hilsen.Length; i++)
            {
                 
                Debug.WriteLine("makebig: " + makeBig);
                if (makeBig)
                {
                    result.Append(Char.ToUpper(hilsen[i]));
                }
                else
                {
                    result.Append(Char.ToLower(hilsen[i]));
                }

                makeBig = !makeBig; //laver lige makebig til det modsatte af det nuværende
            }

            Debug.WriteLine("hilsen: " + result);

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
