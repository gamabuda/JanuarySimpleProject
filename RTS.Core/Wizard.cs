using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    internal class Wizard : Unit
    {
        public int HealPoint { get; set; }
        public Wizard()
        {
            this.Strength = 15;
            this.Dexterity = 20;
            this.Intelligence = 35;
            this.Vitality = 15;
            this.HealPoint = 10;

            Health = (int)(Vitality * 1.4 + Strength * 0.2);
            Mana = (int)(1.5 * Intelligence);
            PDamage = (int)(0.5 * Strength);
            Armor = 1 * Dexterity;
            MDamage = (int)(1 * Intelligence);
            MDefense = (int)(1 * Intelligence);
            CrtChance = (int)(0.2 * Dexterity);
            CrtDamage = (int)(0.1 * Dexterity);
        }

        public void Heal(Unit unit)
        {
            if (unit.Health == unit.MaxHealth)
                return;

            if (Mana < 10)
                return;

            unit.Health += HealPoint;

            Mana -= HealPoint;
        }
    }
}
