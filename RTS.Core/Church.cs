using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Church
    {
        public int GetManaPoint { get; set; } = 10;
        public void GetMana(Unit u)
        {
            if (u.Mana == u.MaxMana)
            {
                return;
            }
            if (u is Rogue)
            {
                u.Mana += GetManaPoint / 2;
            }

            if (u is Warrior)
            {
                u.Mana -= GetManaPoint;
            }

            if (u is Wizzard)
            {
                u.Mana += GetManaPoint * 2;
            }

        }
    }
}
