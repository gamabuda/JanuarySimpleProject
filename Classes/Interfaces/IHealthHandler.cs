using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public interface IHealthHandler
    {
        int Health { get; set; }
        int MaxHealth { get; set; }
        bool GainHealth(int gain)
        {
            if (MaxHealth == Health)
                return false;

            if (MaxHealth - Health <= gain)
            {
                Health = MaxHealth;
                return true;
            }
            Health += gain;
            return true;
        }
    }
}
