using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core1.Interfaces
{
    public interface IAttackHandler
    {
         int PDamage { get; set; }
         void PAttack(Unit unit);
         int MDamage { get; set; }
         void MAttack(Unit unit);
         int CrtChance { get; set; }
         int CrtDamage { get; set; }
    }
}
