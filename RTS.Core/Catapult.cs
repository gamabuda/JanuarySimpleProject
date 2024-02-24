using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Catapult : Building, IAttackHandler
    {
        public int PDamage { get; set; }
        public int CriticalDamage { get; set; }
        public int CriticalChance { get; set; }
        public Catapult()
        {
            PDamage = 20;
            Health = 200;
            MaxHealth = 200;
        }

        public void Attack(IHealthHandler unit)
        {
            if(unit.Health < PDamage)
            {
                unit.Health = 0;
                return;
            }

            unit.Health -= PDamage;
        }

        public void Attack(IArmorHandler unit)
        {
            int damage = PDamage - unit.Armor / 2;
            if (damage < 0) damage = 1;
            if(unit.Health < damage)
            {
                unit.Health = 0;
                return;
            }

            unit.Health -= damage;
        }
    }
}
