using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Units
{
    public class Peasant : Unit
    {
        public Peasant()
        {
            Strength = 10;
            Dexterity = 10;
            Inteligence = 10;
            Vitality = 10;

            MaxStrength = 20;
            MaxDexterity = 20;
            MaxInteligence = 20;
            MaxVitality = 20;

            CheckingAttributes();

            Health = MaxHealth;
            Mana = MaxMana;

            Class = "Peasant";
        }

        protected override void CheckStats()
        {
            MaxHealth = (int)(Strength * 5 + Vitality * 15);
            MaxMana = (int)(Inteligence * 10);
            PDamage = (int)(Strength + Dexterity * 1.75);
            Armor = (int)(Dexterity);
            MDamage = (int)(Inteligence * 2);
            MDefense = (int)(Inteligence * 0.3);
            CrtChanse = (int)(Dexterity * 0.5);
            CrtDamage = (int)(Dexterity * 3);
        }
    }
}
