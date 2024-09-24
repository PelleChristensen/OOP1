using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.containers
{
    
    internal class Rope : StorableItem
    {
        private int _length;
        public int Length { get => _length; set => _length = value; }

        public Rope(int length)
        {
            Length = length;
        }
    }
}
