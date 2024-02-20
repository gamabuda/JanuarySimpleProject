using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSClasses
{
    public interface IHealthHandler
    {
        int Health { get; set; }
        int MaxHealth { get; set; }
        protected int _maxHealthFormula { get; set; }
    }
}