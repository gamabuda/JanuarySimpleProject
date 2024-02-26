using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.Interfaces
{
    public interface IAttackHandler
    {
        public int PDamage { get; set; }
        public void PAttack(Unit unit);
        public int MDamage { get; set; }
        public void MAttack(Unit unit);
        public int CrtChance { get; set; }
        public int CrtDamage { get; set; }
    }
}
