using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Wizard : Hero
    {
        public Wizard()
        {
            Strength = 15;
            BaseStrength = 15;
            MaxStrength = 45;

            Dexterity = 20;
            BaseDexterity = 20;
            MaxDexterity = 80;

            Intelligence = 35;
            BaseIntelligence = 35;
            MaxIntelligence = 250;

            Vitality = 15;
            BaseVitality = 15;
            MaxVitality = 70;

            UpdateStats();
        }

        public void UpdateStats()
        {
            Health = (int)(1.4 * Vitality + 0.2 * Strength);
            MaxHealth = Health;
            Mana = (int)(Intelligence * 1.5);
            MaxMana = Mana;
            PDamage = Strength / 2;
            Armor = Dexterity;
            MDamage = Intelligence;
            MDefense = Intelligence;
            CriticalChance = Dexterity / 5;
            CriticalDamage = Dexterity / 10;
        }
    }
}
