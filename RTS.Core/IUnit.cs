using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public interface IUnit
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
    }
}
