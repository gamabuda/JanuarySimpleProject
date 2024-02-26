using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    internal class Rogue : Unit
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

            PDamage = (int)(0.5 * Strength + 0.5 * Dexterity);
            Armor = (int)(1.5 * Dexterity);
            MDamage = (int)(0.2 * Intelligence);
            MDefense = (int)(0.5 * Intelligence);
            CrtChance = (int)(0.2 * Dexterity);
            CrtDamage = (int)(0.1 * Dexterity);
        }
    }
}
