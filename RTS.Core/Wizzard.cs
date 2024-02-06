namespace RTS.Core
{
    public class Wizzard : Unit
    {
        public Wizzard()
        {
            this.Strength = 15;
            this.Dexterity = 20;
            this.Inteligence = 35;
            this.Vitality = 15;
            HP = 1.4 / Vitality + 0.2 / Strength;
            Mana = 1.5 / Inteligence;
        }
    }
}
