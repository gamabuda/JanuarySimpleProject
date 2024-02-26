using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.Interfaces
{
    public interface IAttackHandler
    {
        int PDamage { get; set; }
        int MDamage { get; set; }
        int CrtDamage { get; set; }

        void Attack(IHealthHandler target);
    }
}
