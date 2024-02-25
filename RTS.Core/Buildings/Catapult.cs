using RTS.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.Buildings
{
    public class Catapult : IBuilding, IHealthHandler
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
    }
}
