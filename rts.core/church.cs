using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rts.core.units;

namespace RTS.Core
{
    public class Church
    {
        public int HealMana { get; set; } = 10;
        public void Pray(Unit unit)
        {
            if (unit.Mana == unit.MaxMana)
                return;

            if (unit is Wizard)
                unit.Mana += HealMana * 2;
            else if (unit is Rogue)
                unit.Mana += HealMana / 2;
            else
                unit.Mana += HealMana;
        }
    }
}
