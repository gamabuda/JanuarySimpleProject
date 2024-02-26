using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rts.core.interfaces
{
    public interface IManaHandler
    {
        public int Mana { get; set; }
        public int MaxMana { get; set; }
    }
}
