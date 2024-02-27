using RTS.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.Units
{
    public class Worker : Unit, IHealthHandler
    {
        public string Icon = ".\\RTS.WPF\\img\\Units\\worker.png";
    }
}
