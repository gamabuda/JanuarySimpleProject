using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.Сharacters
{
    internal class Talgat_Krestyanovich : Unit
    {
        public Talgat_Krestyanovich()
        {
            Strength = 10;
            Dexterity = 11;
            Intelligence = 9;
            Vitality = 20;

            MaxStrenght = 20;
            MaxDexterity = 21;
            MaxIntelligence = 19;
            MaxVitality = 40;

            Health = (int)(Vitality * 0.7 + Strength * 0.3);
            MaxHealth = Health;
            Mana = (int)(Intelligence * 0.8);
            MaxMana = Mana;
            PDamage = (int)(Strength * 0.2 + Dexterity * 0.2);
            Armor = (int)(Dexterity * 0.5);
            CrtChance = (int)(Dexterity * 0.1);
            CrtDamage = (int)(Dexterity * 0.01);
        }
    }
}

