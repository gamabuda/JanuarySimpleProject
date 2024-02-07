using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Wizard : Unit
    {
        public Wizard(int strength, int dexterity, int intelligence, int vitality) : base(strength, dexterity, intelligence, vitality)
        {
            Health = (int)(vitality / 1.4 + Strength / 0.2);
            Damage = (int)(0.5 / strength);
            Mana = 1.5 / intelligence;
        }
    }
}
