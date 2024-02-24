using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public interface IManaHandler
    {
        int Mana { get; set; }
        int MaxMana { get; set; }
    }
}
