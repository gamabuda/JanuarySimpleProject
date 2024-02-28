using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Bildings
{
    public class Catapult : Bilding, IAttackHandler
    {
        public int PDamage { get; set; }
        public int MDamage { get; set; }
        public void Attack(Unit unit)
        {
            Random rnd = new Random();
            if (unit.Health - this.PDamage < 1)
            {
                unit.Health = 0;
                return;
            }

            unit.Health -= rnd.Next(this.PDamage - 5, this.PDamage + 5) - unit.Armor;
        }
    }
}
