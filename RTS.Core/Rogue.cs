using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    internal class Rogue : Unit
    {
        public Rogue(int Strenght, int Dexterity, int Inteligense, int Vitality) : base (Strenght, Dexterity, Inteligense, Vitality)
        {
            double Health = 1.5 / Vitality +  0/5 / Strenght;
            double  Mana = 1.2 / Inteligense;
        }

    }
}
