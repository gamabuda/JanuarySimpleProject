using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Warrior : Unit
    {
        public Warrior(int strenght, int dexterity, int intelligence, int vitality) : base(strenght, dexterity, intelligence, vitality)
        {
            Health = (int)(Vitality * 2 + Strenght);
            Mana = (int)(Intelligence);
        }
    }
}
