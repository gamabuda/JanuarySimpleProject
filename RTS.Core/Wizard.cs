namespace RTS.Core
{
    internal class Wizard : Unit
    {
        public Wizard(int Strenght, int Dexterity, int Intelligence, int Vitality) : base(Strenght, Dexterity, Intelligence, Vitality)
        {
            Health = (int)(1.4 / Vitality + 0.2 / Strenght);
            Mana = (int)(1.5 / Intelligence);
            Damage = (int)(0.5 / Strenght);
        }
    }
}
