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
            Strength = 15;
            Dexterity = 20;
            Intelligence = 35;
            Vitality = 15;

            Health = (int)(Vitality * 1.5 + Strength * 0.2);
            MaxHealth = Health;
            Mana = (int)(Intelligence * 1.5);
            MaxMana = Mana;

            PDamage = (int)(0.5 * Strength);
            Armor = 1 * Dexterity;
            MDamage = 1 * Intelligence;
            MDefense = 1 * Intelligence;
            CrtChance = (int)(0.2 * Dexterity);
            CrtDamage = (int)(0.1 * Dexterity);
        }

        public void Heal(Unit unit)
        {
            if (unit.Health == unit.MaxHealth)
                return;

            if (Mana < 15)
                return;
            Mana -= 15;
            unit.Health += HealPoint;
        }
    }
}