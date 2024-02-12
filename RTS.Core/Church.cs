using RTS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Church
    {
        public int RegenMana { get; set; } = 15;
        
        public void Pray(Unit unit)
        {
            if (unit.Mana == unit.MaxMana)
                return;

            if (unit is Wizard)
                unit.Mana += RegenMana * 2;
            else if (unit is Rogue)
                unit.Mana += RegenMana / 2;
            else
                unit.Mana += RegenMana;

            
        }
    }
}