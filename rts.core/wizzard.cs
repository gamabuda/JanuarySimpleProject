using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Wizard : Unit
    {
        public int HealPoint { get; set; }

        public Wizard()
        {
            Strength = 15;
            Dexterity = 20;
            Intelligence = 35;
            Vitality = 15;

            Health = (int)(Vitality * 1.4 + Strength * 0.2);
            MaxHealth = Health;
            MaxMana = (int)(Intelligence * 1.5);
            MaxMana = Mana;

            Damage = (int)(Strength * 0.5);
            Armor = 1 * Dexterity;
            MagicalDamage = (int)(1 * Inteligence);
            MagicalDefense = (int)(1 * Inteligence);
            CriticalChanse = (int)(Dexterity * 0.2);
            CriticalDamage = (int)(Dexterity * 0.1);
        }

        public void Heal(Unit unit)
        {
            if (unit.Health == unit.MaxHealth)
                return;

            if (Mana < 15)
                return;
            Mana -= 15;
            unit.HealPoint += HealPoint;
        }
    }
}