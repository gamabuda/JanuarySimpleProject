using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RTS.Lib
{
    internal class Wizard : Unit
    {
        public Wizard(int strength, int dexterity, int intelligence, int vitality) : base(strength, dexterity, intelligence, vitality)
        {
            Health = (int)(vitality / 1.4 + strength / 0.2);
            Damage = (int)(0.5 / strength);
            Mana = (int) 1.5 / intelligence;
        }
    }
}
