
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

            Console.WriteLine($"Health: {HealPoint}\n" +
                $"Mana: {Mana}\n" +
                $"Strength: {Strength}\n" +
                $"Dexterity: {Dexterity}\n" +
                $"Intelligence: {Inteligence}\n" +
                $"Vitality: {Vitality}");
        }

        public void Attack(Unit unit)
        {
            if (unit.HealPoint - this.Damage < 1)
            {
                unit.HealPoint = 0;
                return;
            }

            unit.HealPoint -= this.Damage;
        }
    }
}
