using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public interface IMagicHandler: IHealthHandler, IAttackHandler
    {
        public int MagicDamage { get; set; }
        public int MagicDefense { get; set; }

        int CalculateMagicDamage(int magicDefense)
        {
            return MagicDamage - MagicDefense / 2;
        }
    }
}
