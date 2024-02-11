using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Units
{
    public class Rogue : Unit
    {
        public Rogue()
        {
            Strength = 20;
            Dexterity = 30;
            Inteligence = 15;
            Vitality = 20;

            MaxStrength = 65;
            MaxDexterity = 250;
            MaxInteligence = 70;
            MaxVitality = 80;

            CheckingAttributes();

            Health = MaxHealth;
            Mana = MaxMana;
        }

        protected override void CheckStats()
        {
            MaxHealth = (int)(Strength * 5 + Vitality * 15);
            MaxMana = (int)(Inteligence * 10);
            PDamage = (int)(Strength +  Dexterity * 1.75);
            Armor = (int)(Dexterity);
            MDamage = (int)(Inteligence * 2);
            MDefense = (int)(Inteligence * 0.3);
            CrtChanse = (int)(Dexterity * 0.5);
            CrtDamage = (int)(Dexterity * 3);
        }
    }
}
