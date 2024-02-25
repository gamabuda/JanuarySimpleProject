using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.WPF.Intrefaces
{
    interface IHpHandler
    {
        public int HP { get; set; }
        public int MaxHealth { get; set; }
    }
}
