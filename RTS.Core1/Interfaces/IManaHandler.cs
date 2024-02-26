using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core1.Interfaces
{
    public interface IManaHandler
    {
         int MaxMana { get; set; }
         int Mana { get; set; }
    }
}
