using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTS.Core.Interfaces;
using RTS.Core.Units;

namespace RTS.Core.Buildings
{
    public class Church : IBuilding, IHealthHandler
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int HealPoint { get; set; } = 10;
        public void Pray(Unit unit)
        {
            if (unit.Mana == unit.MaxMana)
                return;

            if (unit is Wizard && unit.Mana + HealPoint * 2 <= unit.MaxMana)
                unit.Mana += HealPoint * 2;
            else if (unit is Rogue && unit.Mana + HealPoint / 2 <= unit.MaxMana)
                unit.Mana += HealPoint / 2;
            else if (unit is Warrior && unit.Mana + HealPoint <= unit.MaxMana)
                unit.Mana += HealPoint;
            else
                throw new Exception("При увеличении мана превысит максимальное значение!");
        }
    }
}
