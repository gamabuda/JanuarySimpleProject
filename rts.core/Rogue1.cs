using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Rogue : Unit
    {
        public Rogue()
        {
            this.Strength = 20;
            this.Dexterity = 30;
            this.Intelligence = 15;
            this.Vitality = 20;

            Health = (int)(Vitality * 1.5 + Strength * 0.5);
            Mana = (int)(Intelligence * 1.2);
            PDamage = (int)(0.5 * Strength + 0.5 * Dexterity);
            Armor = (int)(1.5 * Dexterity);
            MagicalDefense = (int)(Intelligence * 0.5);
            MagicalDamage = (int)(Intelligence * 0.2);
            CriticalChanse = (int)(Dexterity * 0.2);
            CriticalDamage = (int)(Dexterity * 0.1);
        }
    }
}
