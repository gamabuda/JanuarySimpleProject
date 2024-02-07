using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Unit
    {
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Vitality { get; set; }
        public int Damage { get; set; } = 50;

        public Unit(int strength, int dexterity, int intelligence, int vitality)
        {
            this.Strength = strength;
            this.Dexterity = dexterity;
            this.Intelligence = intelligence;
            this.Vitality = vitality;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Health: {Health}\n" +
                $"Mana: {Mana}\n\t" +
                $"Strength: {Strength}\n\t" +
                $"Dexterity: {Dexterity}\n\t" +
                $"Intelligence: {Intelligence}\n\t" +
                $"Virality: {Vitality}");
        }

        public void Attack(Unit unit)
        {
            if (unit.Health - this.Damage < 1)
            {
                unit.Health = 0;
                return;
            }

            unit.Health -= this.Damage;

        }
    }
}
