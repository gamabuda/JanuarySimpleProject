using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Barrack: Building
    {
        public Barrack()
        {
            Health = 100;
            MaxHealth = 100;
        }

        public Hero CreateHero(int type)
        {
            switch(type)
            {
                case 1: return new Warrior();
                case 2: return new Wizard();
                case 3: return new Rogue();
                default: throw new Exception("Несуществующий тип героя");
            }
        }
    }
}
