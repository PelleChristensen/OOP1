using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class DungeonFloor
    {
        private int[,] dungeonfloor;
        private int _width;
        private int _height;
        public DungeonFloor(int width, int height)
        {
            _width = width;
            _height = height;
            GenerateDungeonFloor(_width, _height);
        }

        private void GenerateDungeonFloor(int width, int height)
        {
            dungeonfloor = new int[width, height];
            Random n = new Random();
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    float seed = float.Round(n.NextSingle(), 3);
                    int tiletype = 0; //normal tile
                    if(seed < 0.1f)
                    {
                        //healing tile
                        tiletype = 1; 
                    }
                    else if (seed > 0.9f)
                    {
                        //damaging tile
                        tiletype = 2; 
                    }
                    dungeonfloor[x, y] = tiletype;
                }
            }
        }

        public int[,] GetDungeonFloor()
        {
            return dungeonfloor; 
        }


        public void SpendTile(int x, int y)
        {
            dungeonfloor[x, y] = 0;
        }
    }
}
