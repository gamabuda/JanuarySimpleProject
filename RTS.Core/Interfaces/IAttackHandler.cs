using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTS.Core.Units;

namespace RTS.Core.Interfaces
{
    internal interface IAttackHandler
    {
        public int PDamage { get; set; }
        public int MDamage { get; set; }
        public void Attack(Unit unit) {}
    }
}
