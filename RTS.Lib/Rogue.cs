using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Lib
{
    internal class Rogue : Unit
    {
        public Rogue(int strength, int dexterity, int intelligence, int vitality) : base(strength, dexterity, intelligence, vitality)
        {
            Health = (int)(vitality * 1.5 + Strength * 0.5);
            Mana = (int)(1.2 * intelligence);
            PDamage = (int)(0.5 * strength + 0.5 * dexterity);
            Armor = (int)(1.5 * dexterity);
            MDamage = (int)(0.2 * intelligence);
            MDefense = (int)(0.5 * intelligence);
            CrtChance = (int)(0.2 * dexterity);
            CrtDamage = (int)(0.1 * dexterity);
        }
    }
}
