using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Player
    {
        //fields
        public string playername;
        private int health;
        private int strength;

        public int Health { get => health; private set { health = value;  } }

        public Player(string startingplayername, int startinghealth, int startingstrength = 10)
        {
            playername = startingplayername;
            Health = startinghealth; 
        }

        //method
        //offentligt tilgængelig, returnerer ingenting, tager en int som parameter
        public void UpdateHealth(int value)
        {
            Health += value; 
        }
        //tjek om player er død
        public bool IsDead()
        {
            return Health <= 0; 
        }

    }
}
