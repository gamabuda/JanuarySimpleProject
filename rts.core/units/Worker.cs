using rts.core.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rts.core.units
{
    public class Worker : IHealthHandler
    {
        public string Icon = ".\\wpf\\img\\Units\\worker.png";
        public int Health { get; set; }
        public int MaxHealth { get; set; }
    }
}
