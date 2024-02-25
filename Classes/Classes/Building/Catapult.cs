using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Catapult : Building, IAttackHandler
    {
        public int PhysicalDamage { get; set; }
        public int CriticalChance { get; set; }
        public int CriticalDamage { get; set; }

        public Catapult()
        {
            Health = 250;
            MaxHealth = 250;
            PhysicalDamage = 20;
        }

        public void Attack(IArmorHandler armorHandler)
        {
            Random random = new Random();
            int damage;

            if (random.Next(2) == 1)
                damage = PhysicalDamage;
            else
                damage = PhysicalDamage - random.Next(armorHandler.Armor / 2, armorHandler.Armor);

            if (damage <= 0)
                damage = 1;

            if (armorHandler.Health <= damage)
            {
                armorHandler.Health = 0;
                return;
            }

            armorHandler.Health -= damage;
        }
    }
}
