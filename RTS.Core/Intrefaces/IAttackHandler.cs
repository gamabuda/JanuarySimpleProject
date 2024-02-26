using RTS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.WPF.Intrefaces
{
    interface IAttackHandler
    {
        public int Damage { get; set; }
        public int MagicalDamage { get; set; }
        public int CriticalChanse { get; set; }
        public int CriticalDamage { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public void DealDamage(Unit target);

        public bool CheckForCritical();
    }
}
