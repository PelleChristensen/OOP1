using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.Cardgame
{
    
    public class Deck
    {
        private List<Card> cards = new List<Card>();

        public Deck() {

            for (int s = 1; s <= 4; s++)
            {
                for (int i = 1; i <= 13; i++)
                {
                    Card kort; 
                    
                    switch(s)
                    {
                        case 1:
                            kort = new Card(Card.SUIT.SPADES, i);
                            cards.Add(kort);
                            break;
                        case 2:
                            kort = new Card(Card.SUIT.HEARTS, i);
                            cards.Add(kort);
                            break;
                        case 3:
                            kort = new Card(Card.SUIT.DIAMOND, i);
                            cards.Add(kort);
                            break;
                        case 4:
                            kort = new Card(Card.SUIT.CLUBS, i);
                            cards.Add(kort);
                            break;
                    }
                    
                }
                
            }

            foreach(Card kort in cards)
            {
                Console.WriteLine("Kort: " + kort.suit + " " + kort.value);
            }
        }

    }
}
