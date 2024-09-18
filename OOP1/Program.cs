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
            #region rul terninger og vis resultat

            List<int> terningeslag = new List<int>();
            List<string> visuelleresultater = new List<string>();
            int margin = 8;
            int totalscore = 0;
            int terningerul = 150;
            //rul nogle terninger
            for (var i = 0; i < terningerul; i++)
            {
                int dicethrow = RollDice(2);
                terningeslag.Add(dicethrow);
                totalscore += dicethrow;
            }
            int longestcount = FindLongestString(terningeslag);
            visuelleresultater = VisualiseResults(terningeslag, margin,longestcount);

            BuildGraph(visuelleresultater, longestcount + margin);

            Console.WriteLine("Total af resultater : " + totalscore);
            Console.WriteLine("Gennemsnitlig værdi: " + totalscore / terningerul);

            //Den her funktion tegner grafen og laver layout
            void BuildGraph(List<string> stringresultat, int layoutbredde)
            {             
                StringBuilder str = new StringBuilder(); //bruges til at bygge en string
                List<string> linjer = new List<string>(); //opbevaring af de strings vi får skabt

                for (int i = 0; i <= layoutbredde; i++)
                {
                    str.Append("*");
                }

                string start = "*";
                string end = "*";

                Console.WriteLine(str.ToString());

                foreach (string line in stringresultat)
                {
                    Console.WriteLine(start + line + end);
                }
                Console.WriteLine(str.ToString());
            }

            //denn funktion laver terningeresultatere om så de kan vises visuelt i en graf
            List<string> VisualiseResults(List<int> listofnumbers, int margin, int longestitem)
            {
                //vi laver en liste af strings som kun lever herinde
                List<string> stringresults = new List<string>();
                //sæt den totale bredde som visualiseringen skal have
                int maxcount = 0;
                int mincount = 99999;
                int longeststring = longestitem + margin; 

                foreach (int item in listofnumbers)
                {
                    if (maxcount < item) { maxcount = item; }
                    if (mincount > item) { mincount = item; };
                }

                int totalmargin = maxcount + margin; 
                for (int i = mincount; i <= maxcount; i++)
                {
                    StringBuilder resultstring = new StringBuilder();
                    if(i < 10) { resultstring.Append(" "); };

                    resultstring.Append(i + ": ");
                    foreach (int result in listofnumbers)
                    {
                        if (i == result)
                        {
                            resultstring.Append("+");
                        }
                    }

                    //lad os lige smække nogle mellemrum i til sidst så linjerne er lige lange
                    for(int xtras = resultstring.Length; xtras < longeststring; xtras++)
                    {
                        resultstring.Append(" ");
                    }

                    stringresults.Add(resultstring.ToString());
                }
                return stringresults;
            }

            //resultatet af et sæt terningeslag D6
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

            int FindLongestString(List<int> list)
            {
                int longestcount = 0;
                int maxcount = 0;
                for (var j = list.Min(); j <= list.Max(); j++)   
                {
                    int count = 0;
                    for (var i = 0; i < list.Count(); i++)
                    {
                        if (list[i] == j)
                        {
                            count++; 
                        }
                    }
                    if(count > maxcount) { maxcount = count;  }
                }
                return maxcount;
            }


            #endregion

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
            

            List<int[]> liste = new List<int[]>();

            int[] p = { 1, 2 };
            int[] q = { 2, 3 };
            liste.Add(p);

            foreach (int[] item in liste)
            {
                Console.WriteLine("Item: " + item[0] + " " + item[1]);
            }

            return;
            #region minefield

            int length = 5;
            int height = 5;
            float[,] minefield = new float[5, 5];
            Random n = new Random();
            for (int x = 0; x < length; x++)
            {
                for (int y = 0; y < height; y++)
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
                    if (minefield[x, y] <= 0.1f)
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
            */
        }
    }
}
