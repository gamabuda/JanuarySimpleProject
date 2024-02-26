using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSClasses
{
    public class Building : IHealthHandler
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
    }
}
