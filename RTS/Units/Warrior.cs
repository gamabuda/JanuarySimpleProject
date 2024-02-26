using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Units
{
    public class Warrior : Unit
    {
        public Warrior()
        {
            Strength = 30;
            Dexterity = 15;
            Inteligence = 10;
            Vitality = 25;

            MaxStrength = 250;
            MaxDexterity = 80;
            MaxInteligence = 50;
            MaxVitality = 100;

            CheckingAttributes();

            Health = MaxHealth;
            Mana = MaxMana;

            Class = "Warrior";
        }

        protected override void CheckStats()
        {
            MaxHealth = (int)(Strength * 15 + Vitality * 5);
            Health = MaxHealth;
            MaxMana = (int)(Inteligence * 10);
            Mana = MaxMana;
            PDamage = (int)(Strength * 2);
            Armor = (int)(Dexterity * 0.5);
            MDamage = (int)(Inteligence * 2);
            MDefense = (int)(Inteligence * 0.3);
            CrtChanse = (int)(Dexterity * 0.5);
            CrtDamage = (int)(Dexterity * 3);
        }
    }
}
