using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Warrior : Hero
    {
        public Warrior()
        {
            Strenght = 30;
            Dexterity = 15;
            Intelligence = 10;
            Vitality = 25;

            MaxStrenght = 250;
            MaxDexterity = 80;
            MaxIntelligence = 50;
            MaxVitality = 100;

            Health = MaxHealth;
            Mana = MaxMana;
        }

        protected override void UpdateStats()
        {
            MaxHealth = Vitality * 2 + Strenght;
            MaxMana = Intelligence;
            PhysicalDamage = Strenght;
            MagicalDamage = (int)(Intelligence * 0.2);
            Armor = Dexterity;
            MagicDefense = (int)(Intelligence * 0.5);
            CriticalChance = (int)(Dexterity * 0.05);
            CriticalDamage = (int)(Dexterity * 0.1);
        }
    }
}
