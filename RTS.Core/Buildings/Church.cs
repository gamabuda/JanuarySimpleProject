using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTS.Core;

namespace RTS.Core
{
    public class Church : Buildings
    {
        public int HealMana { get; set; } = 15;
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
