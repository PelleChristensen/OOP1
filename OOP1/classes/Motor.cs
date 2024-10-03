using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.classes
{
    public class Motor
    {
        private int _effekt;
        private string _brændstoftype;
        private int _cylindre;
        private int _kapacitet;

        public Motor(int effekt, int cylindre, int kapacitet, string brændstoftype)
        {
            _effekt = effekt;
            _cylindre = cylindre;
            _kapacitet = kapacitet;
            _brændstoftype = brændstoftype.Trim();
        }
        public double beregnHastighed()
        {
            // En simpel formel for at estimere hastigheden (fiktiv)
            double hastighed = (_effekt * _kapacitet) / (_cylindre * 0.1);
            return hastighed; // Returnerer hastigheden i km/t
        }
    }


}
