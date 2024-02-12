using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Units
{
    public class Wizard : Unit
    {
        public int HealPoint { get; set; } = 10;

        public Wizard() 
        {
            Strength = 15;
            Dexterity = 20;
            Inteligence = 35;
            Vitality = 15;

            MaxStrength = 45;
            MaxDexterity = 80;
            MaxInteligence = 250;
            MaxVitality = 70;

            CheckingAttributes();

            Health = MaxHealth;
            Mana = MaxMana;
        }

        protected override void CheckStats()
        {
            MaxHealth = (int)(Strength * 10 + Vitality * 15);
            MaxMana = (int)(Inteligence * 13);
            PDamage = (int)(Strength * 1.8);
            Armor = (int)(Dexterity * 0.7);
            MDamage = (int)(Inteligence * 2);
            MDefense = (int)(Inteligence * 0.7);
            CrtChanse = (int)(Dexterity * 0.5);
            CrtDamage = (int)(Dexterity * 3);
        }

        public void Heal(Unit target)
        {
            if (Mana < 15)
                return;
            else
            {
                Mana -= 15;
                target.Health += HealPoint;
            }
        }
    }
}
