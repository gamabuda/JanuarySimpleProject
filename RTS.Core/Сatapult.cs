using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Сatapult : Unit
    {
        public Сatapult()
        {
            this.Armor = Dexterity / 2;

            this.HP = (Vitality / 2) + (Strength /4);
            this.Mana = Inteligence / 1.5;

            this.Vitality = 10;
            this.Strength = 40;
            this.Inteligence = 0;
            this.Dexterity = 5;

            this.Damage = (Strength * 0.8);
            this.MagicalDamage = Inteligence / 1;
            this.MagicalDefense = Inteligence / 1;
            this.CriticalChanse = Dexterity * 0.2;
            this.MaxHealth = this.HP;
            this.MaxMana = this.Mana;
        }
    }
}
