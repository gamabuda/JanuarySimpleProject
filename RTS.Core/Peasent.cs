using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Peasent : Unit
    {
        public Peasent()
        {
            this.Strength = 10;
            this.Dexterity = 5;
            this.Intelligence = 6;
            this.Vitality = 8;

            this.HP = (int)(Vitality / 1 + Strength);
            this.Mana = (int)(Intelligence);
            this.Damage = (int)(Strength / 1);
            this.MagicalDamage = (int)(Intelligence / 0.1);
            this.MagicalDefense = (int)(Intelligence / 0.2);

            this.MaxHealth = this.HP;
            this.MaxMana = this.Mana;
            this.Armor = (int)(Dexterity / 1);

            this.CriticalChanse = (int)(Dexterity / 0.2);
            this.CriticalDamage = (int)(Dexterity / 0.1);
        }
    }
}
