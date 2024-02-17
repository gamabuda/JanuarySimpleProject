using RTS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Church : Buildings
    {
        public int RegenMana { get; set; } = 15;

        public void Pray(Unit unit)
        {
            if (unit.Mana == unit.MaxMana)
                return;

            if (unit is Wizard)
            {
                unit.Mana += RegenMana * 2;
                if (unit.Mana > unit.MaxMana)
                {
                    unit.Mana = unit.MaxMana;
                }
            }

            else if (unit is Rogue)
            {
                unit.Mana += RegenMana / 2;
                if (unit.Mana > unit.MaxMana)
                {
                    unit.Mana = unit.MaxMana;
                }
            }
            else
                unit.Mana += RegenMana;


        }
    }
}