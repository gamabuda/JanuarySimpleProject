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
            Health = 2 / vitality + strength;
            Damage = 1 / strength;
        }
    }
}
