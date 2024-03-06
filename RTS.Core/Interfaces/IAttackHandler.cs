using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.Interfaces
{
    internal interface IAttackHandler
    {
        public int PDamage { get; set; }
        public int MDamage { get; set; }
        public void PAttack(Unit unit) { }
        public void MAttack(Unit unit) { }
    }
}
