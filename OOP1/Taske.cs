using OOP1.containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Taske
    {
        protected int _kapacitet = 0;
        protected string _navn = "Beholder";
        protected List<StorableItem> _indhold = new List<StorableItem>();
        public int Kapacitet { get { return _kapacitet; } set { _kapacitet = value; } }
        public string Navn { get { return _navn; } set { _navn = value; } }

        public void AddItem(StorableItem item)
        {
            _indhold.Add(item);
        }

        public int CountItems(StorableItem targetitem = null)
        {
            //hvis vi vil tælle en specifik genstand
            if (targetitem != null)
            {
                int count = 0;
                foreach (StorableItem item in _indhold)
                {
                    if (item.GetType() == targetitem.GetType())
                    {
                        count++;
                    }
                }
                return count;
            }
            //hvis vi bare vil kende den totale mængde
            return _indhold.Count();
        }
        public virtual bool HasSpace()
        {
            return _indhold.Count < Kapacitet;
        }
    }
}
