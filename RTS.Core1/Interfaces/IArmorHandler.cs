using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core1.Interfaces
{
    public interface IArmorHandler
    {
        int Armor { get; set; }
        void Armorr(Unit unit);
        int MDefence { get; set; }
    }
}
