
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Unit
    {
        public int Vitality { get; set; } 
        public int Mana { get; set; }
        public int Health { get; set; } 
        public int Strenght { get; set; } 
        public int Dexterity { get; set; } 
        public int Intelligense { get; set; }

        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }

        public int Damage { get; set; }
        public int MagicalDamage { get; set; }
        public int MagicalDefense { get; set; }
        public int CriticalChanse { get; set; }
        public int CriticalDamage { get; set; }

        public void ShowInfo()
        {

            Console.WriteLine($"Health: {Health}\n" +
                $"Mana: {Mana}\n" +
                $"Strength: {Strenght}\n" +
                $"Dexterity: {Dexterity}\n" +
                $"Intelligence: {Intelligense}\n" +
                $"Vitality: {Vitality}");
        }

        public void Attack(Unit unit)
        {
            if (unit.Health - Damage < 1)
            {
                unit.Health = 0;
                return;
            }

            unit.Health -= Damage;
        }
    }
}
