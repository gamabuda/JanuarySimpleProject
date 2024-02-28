using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Wizzard : Unit
    {
        public double HPPoint { get; set; } = 15;
        public Wizzard()
        {
            this.Armor = Dexterity / 1;

            this.HP = (Vitality / 1.4) + (Strength * 0.2);
            this.Mana = Inteligence / 1.5;

            this.Vitality = 15;
            this.Strength = 15;
            this.Inteligence = 35;
            this.Dexterity = 20;
            

            this.Damage = (Strength * 0.5);
            this.MagicalDamage = Inteligence / 1;
            this.MagicalDefense = Inteligence / 1;
            this.CriticalChanse = Dexterity * 0.2;
            this.MaxHealth = this.HP;
            this.MaxMana = this.Mana;
        }
        public int Heal(Unit u)
        {
            if (Mana < 15)
            {
                if (u.HP + HPPoint > u.MaxHealth)
                {
                    return 0;
                }
                return 0;
            }
            Mana -= 15;
            u.HP += HPPoint;
            return (int)u.HP;
        }

        public void FireBall(Unit u)
        {
            if (Mana < 15)
            {
                return;
            }
            else
            {
                u.Mana -= 15;
                u.HP = u.HP + u.MagicalDefense  - u.MagicalDamage;
            }
           
        }
    }
}
