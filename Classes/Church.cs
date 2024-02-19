using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Church : Building
    {
        private const int _regen = 10;
        public Church() : base() { }
        public Church(string name) : base(name) { }
        public void Pray(Unit unit)
        {
            if (unit is Warrior)
            {
                unit.GainMana(_regen);
            }
            else if (unit is Rogue)
            {
                unit.GainMana(_regen / 2);
            }
            else if (unit is Wizard)
            {
                unit.GainMana(_regen * 2);
            }
        }
    }
}
