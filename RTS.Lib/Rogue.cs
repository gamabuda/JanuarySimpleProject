using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Lib
{
    public class Rogue : Unit
    {
        public Rogue()
        {
            this.Strength = 20;
            this.MinStrength = 20;
            this.Dexterity = 30;
            this.MinDexterity = 30;
            this.Intelligence = 15;
            this.MinIntelligence = 15;
            this.Vitality = 20;
            this.MinVitality = 20;
            this.MaxHealth = 60;
            this.MaxMana = 15;

            this.Health = (int)(Vitality * 2 + Strength);
            this.Mana = (int)(1 * Intelligence);
            this.PDamage = (int)(1 * Strength);
            this.Armor = (int)(1 * Dexterity);
            this.MDamage = (int)(0.2 * Intelligence);
            this.MDefense = (int)(0.5 * Intelligence);
            this.CrtChance = (int)(0.2 * Dexterity);
            this.CrtDamage = (int)(0.1 * Dexterity);
        }
    }
}
