namespace RTS.Core
{
    public class Warrior : Unit
    {
        public Warrior()
        {
            this.Strength = 30;
            this.Dexterity = 15;
            this.Inteligence = 10;
            this.Vitality = 25;

            this.HP = (int)(Vitality / 2 + Strength);
            this.Mana = (int)(Inteligence);
            this.Damage = (int)(Strength / 1);
            this.MagicalDamage = (int)(Inteligence / 0.2);
            this.MagicalDefense = (int)(Inteligence / 0.5);

            this.MaxHealth = this.HP;
            this.MaxMana = this.Mana;
            this.Armor = (int)(Dexterity / 1);

            this.CriticalChanse = (int)(Dexterity / 0.2);
            this.CriticalDamage = (int)(Dexterity / 0.1);
        }
    }
}
