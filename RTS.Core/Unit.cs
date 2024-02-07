using System.Xml.Linq;

namespace RTS.Core
{
    public class Unit
    {
        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }

        public int HP { get; set; }
        public int Mana { get; set; }

        public int Vitality { get; set; }
        public int Strength { get; set; }
        public int Inteligence { get; set; }
        public int Dexterity { get; set; }
        public int Damage { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Health: {HP}\nMana: {Mana}\nStrength: {Strength}\nDexterity: {Dexterity}\nVitality: {Vitality}");
        }

        public void TakeDamage(int damage)
        {
            HP -= damage;
            if (HP <= 0)
            {
                Console.WriteLine($"{GetType().Name} has been destroyed.");
            }
        }

        public void DealDamage(Unit target, int damage) => target.TakeDamage(damage);
    }
}