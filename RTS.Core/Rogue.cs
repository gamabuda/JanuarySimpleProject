using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Rogue : Unit
    {
        public Rogue()
        {

            this.Armor = Dexterity / 1.5;

            this.HP = (Vitality * 1.5) + (Strength * 0.5);
            this.Mana = Inteligence / 1.2;

            this.Vitality = 20;
            this.Strength = 20;
            this.Inteligence = 15;
            this.Dexterity = 30;

            this.Damage = (Strength * 0.5) + (Dexterity * 0.5);
            this.MagicalDamage = Inteligence * 0.2;
            this.MagicalDefense = Inteligence * 0.5;
            this.CriticalChanse = Dexterity * 0.2;
            this.MaxHealth = this.HP;
            this.MaxMana = this.Mana;
        }
    }
}
