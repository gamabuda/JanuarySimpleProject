using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rts.core.units;

namespace rts.core
{
    public class Church
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int HealPoint { get; set; } = 10;
        public void Pray(Unit unit)
        {
            if (unit.Mana == unit.MaxMana)
                return;

            if (unit is Wizard)
                unit.Mana += HealPoint * 2;
            else if (unit is Rogue)
                unit.Mana += HealPoint / 2;
            else
                unit.Mana += HealPoint;
        }
    }
}
