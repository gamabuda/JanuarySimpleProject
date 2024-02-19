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
            this.Strength = 30;
            this.Dexterity = 15;
            this.Intelligence = 10;
            this.Vitality = 25;

            this.Health = Vitality * 2 + Strength;
            this.Mana = 1 * Intelligence;
            this.PDamage = 1 * Strength;
            this.Armor = 1 * Dexterity;
            this.MDamage = (int)(0.2 * Intelligence);
            this.MDefense = (int)(0.5 * Intelligence);
            this.CrtChance = (int)(0.2 * Dexterity);
            this.CrtDamage = (int)(0.1 * Dexterity);
        }
    }
}