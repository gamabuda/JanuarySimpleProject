using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public interface IAttackHandler
    {
        int PDamage { get; set; }
        int CriticalDamage { get; set; }
        int CriticalChance { get; set; }

        void Attack(IHealthHandler unit);
        void Attack(IArmorHandler unit);
    }
}
