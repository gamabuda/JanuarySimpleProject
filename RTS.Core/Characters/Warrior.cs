using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RTS.Core.Characters
{
    public class Warrior : Unit
    {
        public Warrior()
        {
            Image = ".\\RTS.Core\\Characters\\img\\warrior.jpg";
            Name = "Warrior";
            Strength = 30;
            Dexterity = 15;
            Intelligence = 10;
            Vitality = 25;
            MaxStrength = 250;
            MaxDexterity = 80;
            MaxIntelegence = 50;
            MaxVitality = 100;

            Health = 2 * Vitality + Strength;
            Mana = 1 * Intelligence;
            PDamage = 1 * Strength;
            Armor = 1 * Dexterity;
            MDamage = (int)(0.2 * Intelligence);
            MDefense = (int)(0.5 * Intelligence);
            CrtChance = (int)(0.2 * Dexterity);
            CrtDamage = (int)(0.1 * Dexterity);

            MaxHealth = Health;
            MaxMana = Mana;
        }
    }
}
