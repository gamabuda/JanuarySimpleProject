using RTS.Core1.Interfaces;
using RTS.Core1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core1
{
    public class Church : IHPHandler, IManaHandler
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        int MaxMana { get; set; }
        int Mana { get; set; }

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