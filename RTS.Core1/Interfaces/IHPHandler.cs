using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core1.Interfaces
{
    public interface IHPHandler
    {
         int Health { get; set; }
         int MaxHealth { get; set; }
    }
}
