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
        public Wizard()
        {
            this.Strength = 15;
            this.Dexterity = 20;
            this.Intelligence = 35;
            this.Vitality = 15;

            this.Health = (int)(Vitality * 2 + Strength);
            this.Mana = (int)(1 * Intelligence);
            this.PDamage = (int)(1 * Strength);
            this.Armor = (int)(1 * Dexterity);
            this.MDamage = (int)(0.2 * Intelligence);
            this.MDefense = (int)(0.5 * Intelligence);
            this.CrtChance = (int)(0.2 * Dexterity);
            this.CrtDamage = (int)(0.1 * Dexterity);
        }

        public void Heal(Unit unit)
        {
            if (Mana < 15)
            Mana -= 15;
            unit.Health += HealPoint;
        }
    }
}
