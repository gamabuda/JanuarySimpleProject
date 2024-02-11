namespace RTS.Lib
{
    public class Warrior : Unit
    {
        public Warrior(int strength, int dexterity, int intelligence, int vitality) : base(strength, dexterity, intelligence, vitality)
        {
            Health = vitality * 2 + strength;
            Mana = 1 * intelligence;
            PDamage = 1 * strength;
            Armor = 1 * dexterity;
            MDamage = (int)(0.2 * intelligence);
            MDefense = (int)(0.5 * intelligence);
            CrtChance = (int)(0.2 * dexterity);
            CrtDamage = (int)(0.1 * dexterity);
        }
    }
}
