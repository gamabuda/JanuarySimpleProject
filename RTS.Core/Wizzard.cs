using RTS.Core;

namespace RTS.Core
{
    public class Wizzard : Unit
    {
        public int HealPoint { get; set; }
        public int FireballDamage { get; set; }
        public Wizzard()
        {
            this.Strength = 15;
            this.Dexterity = 20;
            this.Inteligence = 35;
            this.Vitality = 15;

            this.HP = (int)(Vitality / 1.5 + Strength / 0.5);
            this.Mana = (int)(Inteligence / 1.5);
            this.Damage = (int)(0.5 / Strength);
            this.HealPoint = 10;
            this.MagicalDamage = (int)(Inteligence / 1);
            this.MagicalDefense = (int)(Inteligence / 1);

            this.MaxHealth = this.HP;
            this.MaxMana = this.Mana;
            this.Armor = (int)(Dexterity / 1);

            this.CriticalChanse = (int)(Dexterity / 0.2);
            this.CriticalDamage = (int)(Dexterity / 0.1);

            this.FireballDamage = (int)((this.Inteligence / 2) + this.MagicalDamage);
        }

        public void Heal(Unit target)
        {
            if (Mana < 15)
                return;
            else
            {
                Mana -= 15;
                target.HP += HealPoint;
            }
        }

        public void Fireball(Unit target)
        {
            if (Mana < 24)
                return;
            else
            {
                Mana -= 24;
                FireballDamage = this.FireballDamage - target.MagicalDefense / 2;
            }
        }
    }
}
