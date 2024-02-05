using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    internal class Warrior : Unit
    {
        public Warrior(int strength, int dexterity, int intelligence, int virality) : base(strength, dexterity, intelligence, virality)
        {
            Health = 2/virality + Strength;
        }
    }
}
