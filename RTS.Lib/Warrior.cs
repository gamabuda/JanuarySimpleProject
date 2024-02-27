namespace RTS.Lib
{
    public class Warrior : Unit
    {
        public Warrior()
        {
            this.Strength = 30;
            MinStrength = 30;
            this.Dexterity = 15;
            MinDexterity = 15;
            this.Intelligence = 10;
            MinIntelligence = 10;
            this.Vitality = 25;
            MinVitality = 25;
            MaxHealth = 80;
            MaxMana = 10;

            this.Health = (int) (Vitality * 2 + Strength);
            this.Mana = (int) (1 * Intelligence);
            this.PDamage = (int) (1 * Strength);
            this.Armor = (int)(1 * Dexterity);
            this.MDamage = (int)(0.2 * Intelligence);
            this.MDefense = (int)(0.5 * Intelligence);
            this.CrtChance = (int)(0.2 * Dexterity);
            this.CrtDamage = (int)(0.1 * Dexterity);
        }
    }
}
