namespace RTS.Core.Units
{
    internal class Rogue : Unit
    {
        public Rogue()
        {
        }

        public Rogue(int Strength, int Dexterity, int Intelligence, int Vitality) : base(Strength, Dexterity, Intelligence, Vitality)
        {
            Health = (int)(1.5 / Vitality + 0.5 / Strength);
            Mana = (int)(1.2 / Intelligence);
            PDamage = (int)(0.5 / Strength + 0.5 * Dexterity);
        }
    }
}
