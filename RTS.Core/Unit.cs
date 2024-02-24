using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Unit: IHealthHandler
    {
        public int Health {  get; set; }
        public int MaxHealth { get; set; }
    }
}
