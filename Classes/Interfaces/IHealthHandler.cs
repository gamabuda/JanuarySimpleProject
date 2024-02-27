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

        void InflictDamage(int damage)
        {
            if (Health == 0) return;
            else if (damage < 1)
                Health -= 1;
            else if(Health - damage < 0)
                Health = 0;
            else
                Health -= damage;
        }
    }
}
