using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.classes
{
    internal class Hjul
    {
        private float _friktion;
        private float _slidbane; 

        public Hjul(float friktion, float slidbane)
        {
            _friktion = friktion;
            _slidbane = slidbane;
        }
    }
}
