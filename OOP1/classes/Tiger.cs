using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.classes
{
    public class Tiger : Dyr
    {
        private int skade = 5;

        public Tiger(string navn, int alder, int energi)
        {
            this.navn = navn;
            this.alder = alder;
            this.energi = energi;

            Console.WriteLine("RAWRR!! Den mægtige tiger '" + navn + "' er opstået!!");
        }

        public override void Spise(int energi)
        {
            Console.WriteLine(@"Tigeren '" + navn + "' får noget at spise. Den får " + energi + " ekstra energi");
            energi += energi;
        }

        public void Spise(string genstand)
        {
            Console.WriteLine(@"Tigeren '" + navn + "' får noget at spise. Den spiser en " + genstand);
        }
    }
}
