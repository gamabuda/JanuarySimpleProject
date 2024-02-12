using RTS.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Bildings
{
    public class Church
    {
        public int RegenerateMana { get; set; }
        public void Pray(Unit target)
        {
            if (target.Mana == target.MaxMana)
                return;
            if (target is Wizard)
                target.Mana += RegenerateMana * 2;
            else if (target is Rogue)
                target.Mana += RegenerateMana / 2;
            else
                target.Mana += RegenerateMana;
        }
    }
}
