﻿using System;
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

        public Player(string startingplayername, int startinghealth)
        {
            playername = startingplayername;
            health = startinghealth; 
        }

        //method
        //offentligt tilgængelig, returnerer ingenting, tager en int som parameter
        public void UpdateHealth(int value)
        {
            int disease = -2; 
            health += value - disease; 
        }
        //tjek om player er død
        public bool IsDead()
        {
            return health <= 0; 
        }

    }
}