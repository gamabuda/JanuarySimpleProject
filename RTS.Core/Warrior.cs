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
            this.Armor = Dexterity / 1;


            this.HP = (Vitality / 2) + (Strength / 1);
            this.Mana = Inteligence / 1.2;

            this.Vitality = 25;
            this.Strength = 30;
            this.Inteligence = 10;
            this.Dexterity = 15;

            this.Damage = (Strength / 1);
            this.MagicalDamage = Inteligence * 0.2;
            this.MagicalDefense = Inteligence * 0.5;
            this.CriticalChanse = Dexterity * 0.2;
            this.MaxHealth = this.HP;
            this.MaxMana = this.Mana;
        }

    }
}
