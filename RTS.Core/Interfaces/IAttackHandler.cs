using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.Interfaces
{
    internal interface IAttackHandler
    {
        public void Attack(Unit unit);
        public int MDamage { get; set; }
        public int PDamage { get; set; }
    }
}
