using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Wizard : Unit
    {
        public Wizard(int strenght, int dexterity, int intelligence, int vitality) : base(strenght, dexterity, intelligence, vitality)
        {
            Health = (int)(Vitality * 1.4 + 0.2 * Strenght);
            Mana = (int)(Intelligence * 1.5);
        }
    }
}
