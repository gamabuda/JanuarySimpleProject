using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.Units
{
    public class Rogue : Unit
    {
        public string Icon = ".\\RTS.WPF\\img\\Units\\rogue.png";
        public Rogue()
        {
            Strength = 20;
            Dexterity = 30;
            Intelligence = 15;
            Vitality = 20;

            MaxStrength = 65;
            MaxDexterity = 250;
            MaxIntelligence = 70;
            MaxVitality = 80;

            CalculateStats();
        }

        public override void CalculateStats()
        {
            Health = (int)(Vitality * 1.5 + Strength * 0.5);
            Mana = (int)(1.2 * Intelligence);
            PDamage = (int)(0.5 * Strength + 0.5 * Dexterity);
            Armor = (int)(1.5 * Dexterity);
            MDamage = (int)(0.2 * Intelligence);
            MDefense = (int)(0.5 * Intelligence);
            CritChance = (int)(0.2 * Dexterity);
            CritDamage = (int)(0.1 * Dexterity);
            MaxMana = Mana;
            MaxHealth = Health;
        }
    }
}
