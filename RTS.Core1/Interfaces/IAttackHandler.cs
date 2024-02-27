using RTS.Core1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core1.Interfaces
{
    public interface IAttackHandler
    {
        public int PDamage { get; set; }
        public void Attack(Unit unit);
        public int MDamage { get; set; }
        public int CrtChance { get; set; }
        public int CrtDamage { get; set; }
    }
}