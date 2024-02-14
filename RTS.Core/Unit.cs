namespace RTS.Core
{
    public class Unit
    {
        public int Vitality { get; set; }
        public int Mana { get; set; }
        public int Health { get; set; } //здоровье
        public int Strenght { get; set; } //сила
        public int Dexterity { get; set; } //ловкость
        public int Inteligense { get; set; } //интеллект

        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }

        public int PDamage { get; set; }
        public int Armor { get; set; }
        public int MDamage { get; set; }
        public int MDefense { get; set; }
        public int CrtChance { get; set; }
        public int CrtDamage { get; set; }
      

        public void ShowInfo()
        {
            Console.WriteLine($"Health: {Health}\nMana: {Mana}\nS: {Strenght}\nD: {Dexterity}\nI: {Inteligense}\nV: {Vitality}");
        }

        public void Attack(Unit unit)
        {
            if (unit.Health - this.PDamage < 1)
            {
                Unit.Health = 0;
                return;
            }

            unit.Health -= this.PDamage;
        }

    }
}