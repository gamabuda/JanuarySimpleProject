using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    internal class Warrior : Unit
    {
        public Warrior(int strength, int dexterity, int intelligence, int vitality) : base(strength, dexterity, intelligence, vitality)
        {
            Health = vitality / 2 + strength;
            Damage = 1 / strength;
            Mana = 1 / intelligence;
        }
    }
}
