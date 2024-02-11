using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RTS.Lib
{
    internal class Wizard : Unit
    {
        public int HealPoint { get; set; } = 10;
        public Wizard(int strength, int dexterity, int intelligence, int vitality) : base(strength, dexterity, intelligence, vitality)
        {
            Health = (int)(vitality * 1.4 + Strength * 0.2);
            Mana = (int)(1.5 * intelligence);
            PDamage = (int)(0.5 * strength);
            Armor = 1 * dexterity;
            MDamage = (int)(1 * intelligence);
            MDefense = (int)(1 * intelligence);
            CrtChance = (int)(0.2 * dexterity);
            CrtDamage = (int)(0.1 * dexterity);
        }

        public void Heal(Unit unit)
        {
            if (Mana < 15)
            Mana -= 15;
            unit.Health += HealPoint;
        }
    }
}
