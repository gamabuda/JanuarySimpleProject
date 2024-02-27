using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Rogue : Hero, IArmorHandler, IAttackHandler, IMagicHandler
    {
        
        public Rogue()
        {
            Strenght = 20;
            Dexterity = 30;
            Intelligence = 15;
            Vitality = 20;

            MaxStrenght = 65;
            MaxDexterity = 250;
            MaxIntelligence = 70;
            MaxVitality = 80;

            Health = MaxHealth;
            Mana = MaxMana;
        }

        protected override void UpdateStats()
        {
            MaxHealth = (int)(Vitality * 1.5 + Strenght * 0.5);
            MaxMana = (int)(Intelligence * 1.2);
            PhysicalDamage = (int)(Strenght * 0.5 + Dexterity * 0.5);
            MagicDamage = (int)(Intelligence * 0.2);
            Armor = (int)(Dexterity * 1.5);
            MagicDefense = (int)(Intelligence * 0.5);
            CriticalChance = (int)(Dexterity * 0.05);
            CriticalDamage = (int)(Dexterity * 0.1);
        }
    }
}
