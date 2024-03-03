using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Catapulta : Unit
    {
        public Catapulta()
        {
            this.Strength = 40;
            this.Dexterity = 10;
            this.Intelligence = 25;
            this.Vitality = 12;

            this.HP = (int)(Vitality / 1 + Strength);
            this.Mana = (int)(Intelligence / 0.4);
            this.Damage = (int)(Strength / 1);
            this.MagicalDamage = (int)(Intelligence / 0.1);
            this.MagicalDefense = (int)(Intelligence / 2);

            this.MaxHealth = this.HP;
            this.MaxMana = this.Mana;
            this.Armor = (int)(Dexterity / 1);

            this.CriticalChanse = (int)(Dexterity / 0.4);
            this.CriticalDamage = (int)(Dexterity / 0.2);
        }
    }
}
