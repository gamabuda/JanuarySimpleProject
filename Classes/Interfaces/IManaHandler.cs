using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public interface IManaHandler
    {
        int Mana { get; set; }
        int MaxMana { get; set; }
        bool GainMana(int gain)
        {
            if (MaxMana == Mana)
                return false;

            if (MaxMana - Mana <= gain)
            {
                Mana = gain;
                return true;
            }
            Mana += gain;
            return true;
        }
    }
}
