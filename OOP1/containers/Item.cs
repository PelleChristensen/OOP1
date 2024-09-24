using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.containers
{
    internal class Item
    {
        private int volumen;
        private int weight;

        public int Volumen { get => volumen; set => volumen = value; }
        protected int Weight { get => weight; set => weight = value; }
    }
}
