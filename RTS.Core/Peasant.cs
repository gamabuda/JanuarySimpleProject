namespace RTS.Core
{
    public class Peasant : Unit
    {
        public Peasant() 
        {
            this.Strength = 10;
            this.Dexterity = 5;
            this.Inteligence = 6;
            this.Vitality = 8;

            this.HP = (int)(Vitality / 1 + Strength);
            this.Mana = (int)(Inteligence);
            this.Damage = (int)(Strength / 1);
            this.MagicalDamage = (int)(Inteligence / 0.1);
            this.MagicalDefense = (int)(Inteligence / 0.2);

            this.MaxHealth = this.HP;
            this.MaxMana = this.Mana;
            this.Armor = (int)(Dexterity / 1);

            this.CriticalChanse = (int)(Dexterity / 0.2);
            this.CriticalDamage = (int)(Dexterity / 0.1);
        }
    }
}
