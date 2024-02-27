using RTS.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Catapult : IHPHandler, IAttackHandler
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int PDamage { get; set; }
        public void Attack(Unit unit)
        {

        }
        public int MDamage { get; set; }
        public int CrtChance { get; set; }
        public int CrtDamage { get; set; }
    }
}
