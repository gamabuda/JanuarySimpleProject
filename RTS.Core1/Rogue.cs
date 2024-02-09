using RTS.Core1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core1
{
    public class Rogue : Unit
    {
        public Rogue(int strength, int dexterity, int intelligence, int vitality) : base(strength, dexterity, intelligence, vitality)
        {
            Health = (int)(vitality / 1.5 + strength / 0 / 5);
            Mana = (int)(intelligence / 1.2);
            PDamage = (int)(strength / 0.5 + dexterity / 0.5);
            Armor = (int)(dexterity / 1.5);
            MDefence = (int)(intelligence / 0.5);
            MDamage = (int)(intelligence / 0.2);
            CrtChance = (int)(dexterity / 0.2);
            CrtDamage = (int)(dexterity / 0.1);
        }
    }
}