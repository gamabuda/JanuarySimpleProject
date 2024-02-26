using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RTS.Core.Characters
{
    public class Wizard : Unit
    {
        public int HealPoint { get; set; } = 10;
        public Wizard()
        {
            Image = ".\\RTS.Core\\Characters\\img\\wizard.jpg";
            Name = "Wizard";
            Strength = 15;
            Dexterity = 20;
            Intelligence = 35;
            Vitality = 15;
            MaxStrength = 45;
            MaxDexterity = 80;
            MaxIntelegence = 250;
            MaxVitality = 70;

            Health = (int)(Vitality * 1.5 + Strength * 0.2);
            Mana = (int)(Intelligence * 1.5);
            PDamage = (int)(0.5 * Strength);
            MDamage = (int)(1 * Intelligence);
            MDefense = (int)(1 * Intelligence);
            Armor = 1 * Dexterity;
            CrtChance = (int)(0.2 * Dexterity);
            CrtDamage = (int)(0.1 * Dexterity);

            MaxHealth = Health;
            MaxMana = Mana;
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
