using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTS.Core.Units;

namespace RTS.Core.Interfaces
{
    public interface IAttackHandler
    {
        public int PDamage { get; set; }
        public int MDamage { get; set; }
        public int CritDamage { get; set; }
        public int CritChance { get; set; }
        public void Attack(IArmorHandler armorHandler);
    }
}
