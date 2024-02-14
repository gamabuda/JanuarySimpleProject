using RTS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Church : Buildings
    {
        public int RegenerateMana { get; set; }
        public void Pray(Unit target)
        {
            if (target.Mana == target.MaxMana)
                return;
            if (target is Wizzard)
                target.Mana += RegenerateMana * 2;
            else if (target is Rogue)
                target.Mana += RegenerateMana / 2;
            else
                target.Mana += RegenerateMana;
        }
    }
}
