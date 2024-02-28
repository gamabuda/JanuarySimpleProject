using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Peasant : Unit
    {
        public Peasant()
        {
            this.Armor = Dexterity / 1;

            this.HP = (Vitality / 1.4) + (Strength * 0.2);
            this.Mana = Inteligence / 1.5;

            this.Vitality = 5;
            this.Strength = 5;
            this.Inteligence = 10;
            this.Dexterity = 15;

            this.Damage = (Strength * 0.5);
            this.MagicalDamage = Inteligence / 1;
            this.MagicalDefense = Inteligence / 1;
            this.CriticalChanse = Dexterity * 0.2;
            this.MaxHealth = this.HP;
            this.MaxMana = this.Mana;
        }
    }
}
