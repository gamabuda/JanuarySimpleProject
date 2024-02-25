using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Warrior : Unit
    {
        public Warrior()
        {
            this.Strength = 30;
            this.Dexterity = 15;
            this.Intelligence = 10;
            this.Vitality = 25;

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
