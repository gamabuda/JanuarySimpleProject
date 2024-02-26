using rts.core.interfaces;
using RTS.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rts.core.units
{
    public class Worker : IHealthHandler
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
    }
}
