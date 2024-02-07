using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    internal class Rogue : Unit
    {
        public Rogue(int strength, int dexterity, int intelligence, int vitality) : base(strength, dexterity, intelligence, vitality)
        {
            Health = (int)(vitality / 1.5 + Strength / 0.5);
            Damage = (int)( 0.5 / strength + 0.5 / dexterity);
            Mana = 1.2 / intelligence;
        }
    }
}
