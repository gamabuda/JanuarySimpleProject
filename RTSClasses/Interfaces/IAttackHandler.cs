using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSClasses
{
    public interface IAttackHandler
    {
        int PhysicalDamage { get; set; }
        int CriticalChance { get; set; }
        int CriticalDamage { get; set; }

        void Attack(IHealthHandler healthHandler)
        {
            if (healthHandler.Health <= PhysicalDamage)
            {
                healthHandler.Health = 0;
                return;
            }

            healthHandler.Health -= PhysicalDamage;
        }
        void Attack(IArmorHandler armorHandler);
    }
}