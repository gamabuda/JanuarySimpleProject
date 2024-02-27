using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Lib
{
    public interface IAttackHadler
    {
        public int PDamage { get; set; }
        public int MDamage { get; set; }
        public int CrtChance { get; set; }
        public int CrtDamage { get; set; }

        public void Attack(Unit unit);
    }
}
