using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Rogue : Hero
    {
        public Rogue()
        {
            Strength = 20;
            MaxStrength = 65;

            Dexterity = 30;
            MaxDexterity = 250;

            Intelligence = 15;
            MaxIntelligence = 70;

            Vitality = 20;
            MaxVitality = 80;

            UpdateStats();
        }

        public void UpdateStats()
        {
            Health = (int)(1.5 * Vitality + 0.5 * Strength);
            MaxHealth = Health;
            Mana = (int)(1.2 * Intelligence);
            MaxMana = Mana;
            PDamage = (int)(Strength * 0.5 + Dexterity * 0.5);
            Armor = (int)(1.5 * Dexterity);
            MDamage = Intelligence / 5;
            MDefense = Intelligence / 2;
            CriticalChance = Dexterity / 5;
            CriticalDamage = Dexterity / 10;
        }
    }
}
