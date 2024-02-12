using RTS.Core;
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
            Strength = 20;
            Dexterity = 30;
            Intelligence = 15;
            Vitality = 20;
            Health = (int)(Vitality * 1.5 + Strength * 0.5);
            MaxHealth = Health;
            Mana = (int)(Intelligence * 1.2);
            MaxMana = Mana;
            PDamage = (int)(Strength * 0.5 + Dexterity * 0.5);
            Armor = (int)(Dexterity * 1.5);
            MDefence = (int)(Intelligence * 0.5);
            MDamage = (int)(Intelligence * 0.2);
            CrtChance = (int)(Dexterity * 0.2);
            CrtDamage = (int)(Dexterity * 0.1);
        }
    }
}