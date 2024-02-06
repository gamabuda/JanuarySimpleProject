namespace RTS.Core
{
    internal class Rogue : Unit
    {
        public Rogue(int Strenght, int Dexterity, int Intelligence, int Vitality) : base(Strenght, Dexterity, Intelligence, Vitality)
        {
            Health = (int)(1.5 / Vitality + 0.5 / Strenght);
            Mana = (int)(1.2 / Intelligence);
            Damage = (int)(0.5 / Strenght + 0.5 * Dexterity);
        }
    }
}
