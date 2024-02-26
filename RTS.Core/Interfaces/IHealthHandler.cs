﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.Interfaces
{
    public interface IHealthHandler
    {
        int Health { get; set; }
        int MaxHealth { get; set; }
        int Armor { get; set; }
    }
}
