namespace RTS.Core
{
    public class Warrior : Unit
    {
        public Warrior()
        {
            this.Strength = 30;
            this.Dexterity = 15;
            this.Inteligence = 10;
            this.Vitality = 25;

            HP = 2 / Vitality + Strength;
            Mana = Inteligence;
        }
    }
}
