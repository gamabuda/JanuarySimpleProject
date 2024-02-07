using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    
    public class Wizard : Unit
    {
        public Wizard(int Strenght, int Dexterity, int Inteligense, int Vitality) : base(Strenght, Dexterity, Inteligense, Vitality)
        {
            double Health = 1.4 / Vitality + 0.2 / Strenght;
            double Mana = 1.5 / Inteligense;
        }

    }

}
