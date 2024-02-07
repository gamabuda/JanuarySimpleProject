using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Unit
    {
        public int Health { get; set; }
        public int Mana { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Vitality { get; set; }
        public int Damage { get; set; }

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
                $"Mana: {Mana}\n" +
                $"Strength: {Strength}\n" +
                $"Dexterity: {Dexterity}\n" +
                $"Intelligence: {Intelligence}\n" +
                $"Vitality: {Vitality}");
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
