using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Catapult : Unit
    {
        public Catapult()
        {
            this.Strength = 40;
            this.Dexterity = 10;
            this.Inteligence = 25;
            this.Vitality = 12;

            this.HP = (int)(Vitality / 1 + Strength);
            this.Mana = (int)(Inteligence / 0.4);
            this.Damage = (int)(Strength / 1);
            this.MagicalDamage = (int)(Inteligence / 0.1);
            this.MagicalDefense = (int)(Inteligence / 2);

            this.MaxHealth = this.HP;
            this.MaxMana = this.Mana;
            this.Armor = (int)(Dexterity / 1);

            this.CriticalChanse = (int)(Dexterity / 0.4);
            this.CriticalDamage = (int)(Dexterity / 0.2);
        }
    }
}
