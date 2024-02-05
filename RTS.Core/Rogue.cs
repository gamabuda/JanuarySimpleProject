using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    internal class Rogue : Unit
    {
        public Rogue(int strength, int dexterity, int intelligence, int virality) : base(strength, dexterity, intelligence, virality)
        {
            Health = (int)(1.5 / virality + 0.5 / Strength);
        }
    }
}
