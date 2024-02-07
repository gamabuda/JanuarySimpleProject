namespace RTS.Core
{
    public class Wizzard : Unit
    {
        public int HealPoint { get; set; }

        public Wizzard()
        {
            this.Strength = 15;
            this.Dexterity = 20;
            this.Inteligence = 35;
            this.Vitality = 15;

            HP = (int)(Vitality / 1.5 + Strength / 0.5);
            Mana = (int)(Inteligence / 1.5);
            Damage = (int)(0.5 / Strength);

            MaxHealth = Health;
            MaxMana = Mana;
        }

        public void Heal(Unit unit)
        {
            if (Mana < 15)
                return;
            else
            {
                Mana -= 15;
                unit.Health += HealPoint;
            }
        }
    }
}
