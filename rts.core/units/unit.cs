
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rts.core.units
{
    public class Unit
    {
        public int Level { get; set; } = 1;
        public int MaxLevel { get; private set; } = 50;
        public int Experience { get; set; } = 0;
        public int Vitality { get; set; }
        public int Mana { get; set; }
        public int Health { get; set; }
        public int Strenght { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Points { get; set; } = 5;
        public string? Icon { get; set; }
        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }
        public int MaxStrength { get; set; }
        public int MaxDexterity { get; set; }
        public int MaxIntelligence { get; set; }
        public int MaxVitality { get; set; }
        public int Armor { get; set; }


        public int PDamage { get; set; }
        public int MDamage { get; set; }
        public int MDefense { get; set; }
        public int CrtChanse { get; set; }
        public int CrtDamage { get; set; }

        public void ShowInfo()
        {

            Console.WriteLine($"Health: {Health}\n" +
                $"Mana: {Mana}\n" +
                $"Strength: {Strenght}\n" +
                $"Dexterity: {Dexterity}\n" +
                $"Intelligence: {Intelligence}\n" +
                $"Vitality: {Vitality}");
        }

        public void Attack(Unit unit)
        {
            if (unit.Health - PDamage < 1)
            {
                unit.Health = 0;
                return;
            }

            unit.Health -= PDamage;
        }
    }
}
