using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    internal class Wizard : Unit
    {
        public Wizard(int strength, int dexterity, int intelligence, int virality) : base(strength, dexterity, intelligence, virality)
        {
            Health = (int)(1.4 / virality + 0.2 / Strength);
            Damage = (int)(0.5 / strength);
        }
    }
}
