using RTS.Core;
using System.Reflection.Metadata;

namespace RTS.Core
{
    public class Rogue : Unit
    {
        public Rogue()
        {
            this.Strength = 20;
            this.Dexterity = 30;
            this.Inteligence = 15;
            this.Vitality = 20;

            this.HP = (int)(Vitality / 1.5 + Strength / 0.5);
            this.Mana = (int)(Inteligence / 1.2);
            this.Damage = (int)(Dexterity / 0.5 - Strength / 0.5);
            this.MagicalDamage = (int)(Inteligence / 0.2);
            this.MagicalDefense = (int)(Inteligence / 0.5);

            this.MaxHealth = this.HP;
            this.MaxMana = this.Mana;
            this.Armor = (int)(Dexterity / 1.5);

            this.CriticalChanse = (int)(Dexterity / 0.2);
            this.CriticalDamage = (int)(Dexterity / 0.1);
        }
    }
}
