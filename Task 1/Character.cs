using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    abstract class Character : Tiles
    {
        protected int HP;
        protected int MaxHP;
        protected int Damage;
        protected int [] TileArray;
        public enum Movement { up,down,left,right, idle}


        public Character(int x, int y /*string H*/) : base (x,y)
        {

        }
        public virtual void Attack()
        {

        }

        public bool IsDead ()
        {
            if (HP <=0)
            {
                IsDead = True;
            }
        }
    }
}
