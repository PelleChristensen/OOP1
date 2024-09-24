using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.containers
{
    internal class Ration : StorableItem
    {
        private int _energy = 10;
        private bool _consumable = true;
        public int Energy { get { return _energy; } }
        public bool Consumable { get => _consumable; }

        public Ration()
        { 
        
        }

    }
}
