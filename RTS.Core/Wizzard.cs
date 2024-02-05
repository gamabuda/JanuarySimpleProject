namespace RTS.Core
{
    public class Wizzard : Unit
    {
        public Wizzard(int Strength, int Dexterity, int Inteligence, int Vitality) : base(Strength, Dexterity, Inteligence, Vitality)
        {
            HP = 1.4 / Vitality + 0.2 / Strength;
            Mana = 1.5 / Inteligence;
        }
    }
}
