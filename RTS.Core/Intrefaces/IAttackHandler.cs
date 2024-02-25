using RTS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.WPF.Intrefaces
{
    interface IAttackHandler
    {
        public int Damage { get; set; }
        public int MagicalDamage { get; set; }
        public int CriticalChanse { get; set; }
        public int CriticalDamage { get; set; }
        public void DealDamage(Unit target)
        {
            CheckForCritical();
            int damage = 0;

            if (CheckForCritical() == true)
                damage = this.CriticalDamage;
            else
                damage = this.Damage;

            if (target.HP - damage < 1)
            {
                target.HP = 0;
                return;
            }

            if (target.Armor > 0)
            {
                if(damage > target.Armor)
                {
                    int RestOfDamage = damage - target.Armor;
                    target.HP -= RestOfDamage;
                }
            }
            else
                target.HP -= damage;
        }

        public bool CheckForCritical()
        {
            Random random = new Random();
            int chance = random.Next(0, 101);
            if (chance < CriticalChanse) 
                return true;
            else 
                return false;
        }
    }
}
