using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.interfaces
{
    internal interface IHpHandler
    {
        public double HP {  get; set; }
        public double MaxHealth { get; set; }
    }
}
