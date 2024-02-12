using RTS.Core;
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
            PDamage = (int)(Strength * 0.5);
            Armor = 1 * Dexterity;
            MDamage = 1 * Intelligence;
            MDefence = 1 * Intelligence;
            CrtChance = (int)(Dexterity * 0.2);
            CrtDamage = (int)(Dexterity * 0.1);

            MaxHealth = Health;
        }

        public void Heal(Unit unit)
        {
            if (Mana < 15)
                return;
            Mana -= 15;
            unit.Health += HealPoint;
        }
    }
}