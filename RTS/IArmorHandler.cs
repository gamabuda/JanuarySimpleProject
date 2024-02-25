using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS
{
    public interface IArmorHandler
    {
        public int Armor { get; set; }
        public int MDefense { get; set; }
    }
}
