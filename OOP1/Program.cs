using System.Diagnostics;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region ugedageogkaffe
            int[] ugedage = ​{ 7, 5, 3, 3, 5, 1, 6 };
            int total = 0; 

            //vi anvender længden af arrayet 'ugedage' til at 
            for(int i = 0; i <= ugedage.Length; i++)
            {
                total += ugedage[i];
            }

            float gennemsnit = total / ugedage.Length;

            Debug.WriteLine($"Du drak {gennemsnit} kopper kaffe per dag");
            #endregion

            Debug.WriteLine("2: **************");
            Debug.WriteLine("3: **********");
            Debug.WriteLine("4: ***************");

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
