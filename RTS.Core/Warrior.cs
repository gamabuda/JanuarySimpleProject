using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Warrior: Hero
    {
        public Warrior()
        {
            Strength = 30;
            MaxStrength = 250;

            Dexterity = 15;
            MaxDexterity = 80;

            Intelligence = 10;
            MaxIntelligence = 50;

            Vitality = 25;
            MaxVitality = 100;

            UpdateStats();
        }

        public void UpdateStats()
        {
            Health = Vitality * 2 + Strength;
            MaxHealth = Health;
            Mana = Intelligence;
            MaxMana = Mana;
            PDamage = Strength;
            Armor = Dexterity;
            MDamage = Intelligence / 5;
            MDefense = Intelligence / 2;
            CriticalChance = Dexterity / 5;
            CriticalDamage = Dexterity / 10;
        }
    }
}
