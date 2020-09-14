using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    abstract class Tiles
    {
        protected int x;
        protected int y;
        public enum TileType { Hero, enemy, gold, weapon };

        public Tiles (int x, int y)
        {
            this.x = x;
            this.y = y; 
        }
    }
}
