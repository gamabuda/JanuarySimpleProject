using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rts.core.units
{
    public class Rogue : Unit
    {
        public Rogue()
        {
            Strength = 20;
            Dexterity = 30;
            Intelligence = 15;
            Vitality = 20;

            Health = (int)(Vitality * 1.5 + Strength * 0.5);
            MaxHealth = Health;
            Mana = (int)(Intelligence * 1.2);
            MaxMana = Mana;
            Damage = (int)(0.5 * Strength + 0.5 * Dexterity);
            Armor = (int)(1.5 * Dexterity);
            MagicalDefense = (int)(Intelligence * 0.5);
            MagicalDamage = (int)(Intelligence * 0.2);
            CriticalChanse = (int)(Dexterity * 0.2);
            CriticalDamage = (int)(Dexterity * 0.1);
        }
    }
}
