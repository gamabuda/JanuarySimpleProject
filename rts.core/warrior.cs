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
            Strength = 30;
            Dexterity = 15;
            Inteligence = 10;
            Vitality = 25;

            Health = (Vitality + Strength) / 2;
            MaxHealth = Health;
            Mana = 1 * Inteligence;
            MaxMana = Mana;

            Damage = 1 * Strength;
            Armor = 1 * Dexterity;
            MagicalDefense = (int)(Inteligence * 0.5);
            MagicalDamage = (int)(Inteligence * 0.2);
            CriticalChanse = (int)(Dexterity * 0.2);
            CriticalDamage = (int)(Dexterity * 0.1);
        }
    }
}