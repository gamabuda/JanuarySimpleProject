using RTS.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.Building
{
    public class Catapult : IHealthHandler, IAttackHandler
    {
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public int PDamage { get; set; }
        public int MDamage { get; set; }
        public int CrtDamage { get; set; }

        public Catapult()
        {
            MaxHealth = Health;
            Health = 150;
            Armor = 20;
            PDamage = 50;
            MDamage = 0;
            CrtDamage = 100;
        }

        public void Attack(IHealthHandler target)
        {
            int damageDealt = PDamage - target.Armor;
            if (damageDealt < 0)
                damageDealt = 0;

            target.Health -= damageDealt;
        }
    }
}
