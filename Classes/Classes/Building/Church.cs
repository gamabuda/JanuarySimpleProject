using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Church : Building
    {
        private const int _regen = 10;
        public Church()
        {
            Health = 100;
            MaxHealth = 100;
        }

        public void Pray(IManaHandler manaHandler)
        {
            if (manaHandler is Warrior)
            {
                manaHandler.GainMana(_regen);
            }
            else if (manaHandler is Rogue)
            {
                manaHandler.GainMana(_regen / 2);
            }
            else if (manaHandler is Wizard)
            {
                manaHandler.GainMana(_regen * 2);
            }
        }
    }
}
