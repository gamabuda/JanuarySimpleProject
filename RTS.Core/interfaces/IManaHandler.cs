using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.interfaces
{
    internal interface IManaHandler
    {
        public double Mana {  get; set; }
        public double MaxMana { get; set; }
    }
}
