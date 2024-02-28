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
            Strenght = 30;
            Dexterity = 15;
            Intelligence = 10;
            Vitality = 25;

            Health = Vitality * 2 + Strenght;
            MaxHealth = Health;
            Mana = 1 * Intelligence;
            MaxMana = Mana;

            PDamage = 1 * Strenght;
            Armor = 1 * Dexterity;
            MDamage = (int)(0.2 * Intelligence);
            MDefense = (int)(0.5 * Intelligence);
            CrtChance = (int)(0.2 * Dexterity);
            CrtDamage = (int)(0.1 * Dexterity);
        }
    }
}