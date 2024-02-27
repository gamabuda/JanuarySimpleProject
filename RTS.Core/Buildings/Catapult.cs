using RTS.Core.Interfaces;
using RTS.Core.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.Buildings
{
    public class Catapult : IBuilding, IAttackHandler
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int PDamage { get; set; }
        public int MDamage { get; set; }
        public int CritDamage { get; set; }
        public int CritChance { get; set; }

        public void Attack(IArmorHandler armorHandler)
        {
            Random random = new Random();
            int damage = random.Next((int)(PDamage - 0.05 * PDamage), (int)(PDamage + 0.05 * PDamage));
            int totalDamage = damage - armorHandler.Armor;

            if (totalDamage < 1)
                totalDamage = 1;

            if (armorHandler.Health - (int)0.5 * totalDamage < 1)
            {
                armorHandler.Health = 0;
                return;
            }

            armorHandler.Health -= (int)0.5 * totalDamage;
            armorHandler.Armor -= (int)0.5 * totalDamage;

            if (armorHandler.Armor < 1)
                armorHandler.Armor = 0;
        }

    }
}
