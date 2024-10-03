using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.classes
{
    public class Dyr
    {
        protected string navn;
        protected int alder;
        protected int energi;

        public virtual void Spise(int energi) 
        {
            Console.WriteLine(@"Dyret {navn} får noget at spise. Det får " + energi + " ekstra energi"); 
            this.energi += energi;
        }

        public void Sove(int tid) 
        { 
            
        }
    }
}
