using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.interfaces
{
    internal interface IAttackHandler
    {
        public double Damage { get; set; }
        public double MagicalDamage { get; set; }
        public double MagicalDefense { get; set; }
        public double CriticalChanse { get; set; }
        public double CriticalDamage { get; set; }
        public void Attack(Unit u);
    }
}
