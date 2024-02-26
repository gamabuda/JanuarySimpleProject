using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rts.core.units;

namespace rts.core.interfaces
{
    public interface IAttackHandler
    {
        public int Damage { get; set; }
        public int MagicalDamage { get; set; }
        public int CriticalDamage { get; set; }
        public void Attack(Unit unit) { }
    }
}
