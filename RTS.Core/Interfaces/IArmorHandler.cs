using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.Interfaces
{
    public interface IArmorHandler
    {
        public int Armor { get; set; }
        public void Armorr(Unit unit);
        public int MDefence { get; set; }
    }
}
