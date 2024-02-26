using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSClasses
{
    public interface IArmorHandler : IHealthHandler
    {
        int Armor { get; set; }
    }
}