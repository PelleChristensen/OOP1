using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Taske
    {

        private int _volume;
        private List<STUFF> inventory = new List<STUFF>();

        public enum STUFF { HEALINGPOTION = 1, MADPAKKE, SWORD, MAP, WAND };

        public STUFF item; 
        public Taske(int volume = 5)
        {
            _volume = volume;
        }

        public void AddItem(STUFF item)
        {
            inventory.Add(item);
        }

        public void ListInventory()
        {
            foreach(STUFF item in inventory)
            {
                Console.WriteLine(item);
            }
        }

    }
}
