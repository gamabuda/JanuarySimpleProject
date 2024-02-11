using RTS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Warrior : Unit
    {
        public Warrior(int strength, int dexterity, int intelligence, int vitality) : base(strength, dexterity, intelligence, vitality)
        {
            Health = (vitality + strength) / 2;
            MaxHealth = Health;
            Mana = 1 * intelligence;
            MaxMana = Mana;
            PDamage = 1 * strength;
            Armor = 1 * dexterity;
            MDefence = (int)(intelligence * 0.5);
            MDamage = (int)(intelligence * 0.2);
            CrtChance = (int)(dexterity * 0.2);
            CrtDamage = (int)(dexterity * 0.1);
        }
    }
}