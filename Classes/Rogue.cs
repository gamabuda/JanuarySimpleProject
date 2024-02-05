using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Rogue : Unit
    {
        public Rogue(int strenght, int dexterity, int intelligence, int vitality) : base(strenght, dexterity, intelligence, vitality)
        {
            Health = (int)(1.5 * Vitality + Strenght / 2);
            Mana = (int)(Intelligence * 1.2);
        }
    }
}
