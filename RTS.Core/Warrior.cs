namespace RTS.Core
{
    internal class Warrior : Unit
    {
        public Warrior(int Strenght, int Dexterity, int Intelligence, int Vitality) : base(Strenght, Dexterity, Intelligence, Vitality)
        {
            Health = 2 / Vitality + 1 / Strenght;
            Mana = 1 / Intelligence;
            Damage = 1 / Strenght;
        }
    }
}
