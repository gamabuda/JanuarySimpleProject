namespace RTS.Core
{
    public class Warrior : Unit
    {
        public Warrior(int Strength, int Dexterity, int Inteligence, int Vitality) : base(Strength, Dexterity, Inteligence, Vitality)
        {
            HP = 2 / Vitality + Strength;
            Mana = Inteligence;
        }
    }
}
