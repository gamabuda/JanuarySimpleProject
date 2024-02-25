using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.Units
{
    public class Warrior : Unit
    {
        public string Icon = ".\\RTS.WPF\\img\\Units\\warrior.png";

        public Warrior()
        {
            Strength = 30;
            Dexterity = 15;
            Intelligence = 10;
            Vitality = 25;

            MaxStrength = 250;
            MaxDexterity = 80;
            MaxIntelligence = 50;
            MaxVitality = 100;

            Health = Vitality * 2 + Strength;
            Mana = Intelligence;
            PDamage = Strength;
            Armor = Dexterity;
            MDamage = (int)(0.2 * Intelligence);
            MDefense = (int)(0.5 * Intelligence);
            CrtChance = (int)(0.2 * Dexterity);
            CrtDamage = (int)(0.1 * Dexterity);

            MaxMana = Mana;
            MaxHealth = Health;
        }

        public void CalculateStats()
        {
            Health = Vitality * 2 + Strength;
            Mana = Intelligence;
            PDamage = Strength;
            Armor = Dexterity;
            MDamage = (int)(0.2 * Intelligence);
            MDefense = (int)(0.5 * Intelligence);
            CrtChance = (int)(0.2 * Dexterity);
            CrtDamage = (int)(0.1 * Dexterity);
        }
    }
}
