using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Classes
{
    public interface IAttackHandler
    {
        int PhysicalDamage { get; set; }
        int CriticalChance { get; set; }
        int CriticalDamage { get; set; }

        void Attack(IHealthHandler healthHandler)
        {
            healthHandler.InflictDamage(PhysicalDamage);
        }
        void Attack(IArmorHandler armorHandler)
        {
            armorHandler.InflictDamage(CalculatePhysDamage(armorHandler.Armor));
        }

        int CalculatePhysDamage(int Armor)
        {
            Random random = new Random();
            return PhysicalDamage - random.Next(Armor / 2, Armor);
        }
    }
}
