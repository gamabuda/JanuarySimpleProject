namespace RTS.Core
{
    internal class Wizard : Unit
    {
        public int HealPoint { get; set; } = 10;
        public Wizard(int Strenght, int Dexterity, int Intelligence, int Vitality) : base(Strenght, Dexterity, Intelligence, Vitality)
        {
            Health = (int)(Vitality / 1.5 + Strenght / 0.2);
            Mana = (int)(Intelligence / 1.5);
            PDamage = (int)(0.5 / Strenght);
            Armor = 1 / Dexterity;
            MDamage = (int)(Intelligence / 0.2);
            MDefense = (int)(0.5 / Intelligence);


            MaxHealth = Health;
        }

        public Wizard()
        {
        }

        public void Heal(Unit unit)
        {
            if (Mana >= 15)
                return;

            Mana -= 15;
            unit.Health += HealPoint;

        }
    }
}
