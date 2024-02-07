using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Rogue : Unit
    {
        public Rogue(int strength, int dexterity, int intelligence, int vitality) : base(strength, dexterity, intelligence, vitality)
        {
            Health = (int)(1.5 / vitality + 0.5 / Strength);
            Damage = (int)(0.5 / strength + 0.5 / dexterity);
        }
    }
}
