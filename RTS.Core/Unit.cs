namespace RTS.Core
{
    public class Unit
    {
        public double HP { get; set; }
        public double Mana { get; set; }

        public int Vitality { get; set; }
        public int Strength { get; set; }
        public int Inteligence { get; set; }
        public int Dexterity { get; set; }

        public Unit(int Strength, int Dexterity, int Inteligence, int Vitality)
        {
            this.Strength = Strength;
            this.Dexterity = Dexterity;
            this.Inteligence = Inteligence;
            this.Vitality = Vitality;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Health: {HP}\nMana: {Mana}\nStrength: {Strength}\nDexterity: {Dexterity}\nVitality: {Vitality}");
        }
    }
}