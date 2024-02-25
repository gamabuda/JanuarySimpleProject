using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.Units
{
    public class Wizard : Unit
    {
        public string Icon = ".\\RTS.WPF\\img\\Units\\wizard.png";
        public int HealPoint { get; set; } = 10;
        public Wizard()
        {
            Strength = 15;
            Dexterity = 20;
            Intelligence = 35;
            Vitality = 15;
            HealPoint = 10;

            MaxStrength = 45;
            MaxDexterity = 80;
            MaxIntelligence = 250;
            MaxVitality = 70;

            Health = (int)(Vitality * 1.4 + Strength * 0.2);
            Mana = (int)(1.5 * Intelligence);
            PDamage = (int)(0.5 * Strength);
            Armor = Dexterity;
            MDamage = Intelligence;
            MDefense = 1 * Intelligence;
            CrtChance = (int)(0.2 * Dexterity);
            CrtDamage = (int)(0.1 * Dexterity);

            MaxMana = Mana;
            MaxHealth = Health;
        }

        public void CalculateStats()
        {
            Health = (int)(Vitality * 1.4 + Strength * 0.2);
            Mana = (int)(1.5 * Intelligence);
            PDamage = (int)(0.5 * Strength);
            Armor = Dexterity;
            MDamage = Intelligence;
            MDefense = Intelligence;
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
