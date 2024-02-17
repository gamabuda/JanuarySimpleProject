using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Wizard : Unit
    {
        public int HealPoint { get; set; } = 10;
        public Wizard()
        {
            this.Strength = 15;
            this.Dexterity = 20;
            this.Intelligence = 35;
            this.Vitality = 15;
            this.HealPoint = 10;

            MaxMana = 50;
            MaxHealth = 100;
            MaxStrength = 45;
            MaxDexterity = 80;
            MaxIntelligence = 250;
            MaxVitality = 70;

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

            if (Mana < HealPoint)
                return;

            unit.Health += HealPoint;

            Mana -= HealPoint;
        }
    }
}
