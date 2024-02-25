using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public interface IAttackHandler
    {
        public int Damage { get; set; }
        public int MagicalDamage { get; set; }
        public int CriticalDamage { get; set; }
        public void Attack(Unit unit) { }
    }
}
