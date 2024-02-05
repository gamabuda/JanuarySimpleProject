using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Warrior : Unit
    {
        public Warrior(int Strenght, int Dexterity, int Inteligense, int Vitality) : base(Strenght, Dexterity, Inteligense, Vitality)
        {
            Health = 2 / Vitality + Strenght;
            Mana = Inteligense;
        }

    }
}
