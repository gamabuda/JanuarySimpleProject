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
                damage = CalculatePhysDamage(armorHandler.Armor);

            armorHandler.InflictDamage(damage);
        }

        int CalculatePhysDamage(int Armor)
        {
            Random random = new Random();
            return PhysicalDamage - random.Next(Armor / 2, Armor);
        }
    }
}
