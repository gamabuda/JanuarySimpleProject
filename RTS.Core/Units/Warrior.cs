namespace RTS.Core
{
    internal class Warrior : Unit
    {
        public Warrior()
        {
        }

        public Warrior(int Strength, int Dexterity, int Intelligence, int Vitality) : base(Strength, Dexterity, Intelligence, Vitality)
        {
            Health = 2 / Vitality + 1 / Strength;
            Mana = 1 / Intelligence;
            PDamage = 1 / Strength;
        }
    }
}
