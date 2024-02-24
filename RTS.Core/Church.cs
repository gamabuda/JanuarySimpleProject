using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Church : Building
    {
        public Church()
        {
            Health = 150;
            MaxHealth = 150;
        }

        public void Pray(IManaHandler unit)
        {
            if(unit is Warrior && unit.Mana + 10 <= unit.MaxMana)
            {
                unit.Mana += 10;
            }

            if(unit is Wizard && unit.Mana + 20 <= unit.MaxMana)
            {
                unit.Mana += 20;
            }

            if(unit is Rogue && unit.Mana + 5 <= unit.MaxMana)
            {
                unit.Mana += 5;
            }
        }
    }
}
