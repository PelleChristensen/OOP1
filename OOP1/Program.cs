using OOP1.Cardgame;
using OOP1.classes;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dyr tiger = new Tiger("Bettemus", 3, 100);
            Tiger tiger2 = new Tiger("Garfield", 10, 200);
            
            tiger.Spise(49);
            tiger.Spise("Candy Floss"); //the big cat hates you!!
            //lad os se på 
            tiger2.Spise("Mars Bar");
            tiger2.Spise(20);
        }
    }
}
