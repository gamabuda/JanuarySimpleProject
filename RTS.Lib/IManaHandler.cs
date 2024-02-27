using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Lib
{
    public interface IManaHandler
    {
        public int Mana {  get; set; }
        public int MaxMana { get; set; }
    }
}
