using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Sword
    {
        private int _damage;
        private int _durability;
        private int _weight; 
        public Sword(int damage, int durability, int weight)
        {
            _damage = damage;
            _durability = durability;
            _weight = weight;
        }
    }
}
