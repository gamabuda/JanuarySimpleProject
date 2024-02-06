using System.Xml.Linq;

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
        public double Damage { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Health: {HP}\nMana: {Mana}\nStrength: {Strength}\nDexterity: {Dexterity}\nVitality: {Vitality}");
        }

        public void TakeDamage(double damage)
        {
            HP -= damage;
            if (HP <= 0)
            {
                Console.WriteLine($"{GetType().Name} has been destroyed.");
            }
        }

        public void DealDamage(Unit target, double damage) => target.TakeDamage(damage);
    }
}