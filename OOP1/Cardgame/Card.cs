using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Cardgame
{
    public class Card
    {
        public enum SUIT { SPADES, HEARTS, DIAMOND, CLUBS }
        public SUIT suit;
        public int value; 
        public Card(SUIT cardsuit, int cardvalue) 
        { 
            suit = cardsuit;
            value = cardvalue;
        }

    }
}
