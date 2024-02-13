using RTS.Core1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core1
{
    public class Warrior : Unit
    {
        public Warrior()
        {
            Strength = 30;
            Dexterity = 15;
            Intelligence = 10;
            Vitality = 25;
            Health = (Vitality + Strength) / 2;
            MaxHealth = Health;
            Mana = 1 * Intelligence;
            MaxMana = Mana;
            PDamage = 1 * Strength;
            Armor = 1 * Dexterity;
            MDefence = (int)(Intelligence * 0.5);
            MDamage = (int)(Intelligence * 0.2);
            CrtChance = (int)(Dexterity * 0.2);
            CrtDamage = (int)(Dexterity * 0.1);
        }
    }
}