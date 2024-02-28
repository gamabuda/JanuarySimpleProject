using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Lib
{
    public class Peasant : Unit
    {
        public Peasant()
        {
            this.Strength = 10;
            this.Dexterity = 10;
            this.Intelligence = 10;
            this.Vitality = 10;
            this.Health = 10;
            this.Mana = 5;
            this.PDamage = 2;

            this.Health = (int)(Vitality * 0.1 + Strength);
            this.Mana = (int)(0.1 * Intelligence);
            this.PDamage = (int)(0.1 * Strength);
            this.Armor = (int)(0.1 * Dexterity);
            this.MDamage = (int)(0.1 * Intelligence);
            this.MDefense = (int)(0.1 * Intelligence);
            this.CrtChance = (int)(0.1 * Dexterity);
            this.CrtDamage = (int)(0.1 * Dexterity);
        }
    }
}
