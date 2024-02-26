using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSClasses
{
    public class Church : Building
    {
        private const int _regen = 15;
        public Church()
        {
            Health = 200;
            MaxHealth = 200;
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