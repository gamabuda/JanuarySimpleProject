using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Church
    {
            public void Pray(Unit unit)
            {
                if (unit.Mana == unit.MaxMana)
                    return;

                if (unit is Wizard)
                    unit.Mana += 10 * 2;
                else if (unit is Rogue)
                    unit.Mana += 10 / 2;
                else
                    unit.Mana += 10;
            }
    }
}
