using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1.containers
{
    class Backpack : Taske
    {
        private bool IsWearableOnBack = true;

        public Backpack(int volume)
        {
            Kapacitet = volume;
            Navn = "Rygsæk";
        }

        public Ration GetRation()
        {
            Ration ration;

            foreach(StorableItem r in _indhold)
            {
                if(r.GetType() == typeof(Ration))
                {
                    ration = (Ration)r;
                    _indhold.Remove(r);

                    return ration;
                }
            }

            return null;

        }

    }
}
