using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace RTS.Core.Characters
{
    public class Rogue : Unit
    {
        public Rogue()
        {
            Image = ".\\RTS.WPF\\images\\rogue.jpg";
            Name = "Rogue";
            Strength = 20;
            Dexterity = 30;
            Intelligence = 15;
            Vitality = 20;
            MaxStrength = 65;
            MaxDexterity = 250;
            MaxIntelegence = 70;
            MaxVitality = 80;

            Health = (int)(1.5 * Vitality + 0.5 * Strength);
            Mana = (int)(1.2 * Intelligence);
            PDamage = (int)(0.5 * Strength + 0.5 * Dexterity);
            Armor = (int)(1.5 * Dexterity);
            MDamage = (int)(0.2 * Intelligence);
            MDefense = (int)(0.5 * Intelligence);
            CrtChance = (int)(0.2 * Dexterity);
            CrtDamage = (int)(0.1 * Dexterity);

            MaxHealth = Health;
            MaxMana = Mana;
        }
    }
}
