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
        public int MaxMana { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Vitality { get; set; }
        public int PDamage { get; set; }
        public int MDamage { get; set; }
        public int Armor { get; set; }
        public int MDefence { get; set; }
        public int CrtChance { get; set; }
        public int CrtDamage { get; set; }

        public Unit(int strength, int dexterity, int intelligence, int vitality)
        {
            this.Strength = strength;
            this.Dexterity = dexterity;
            this.Intelligence = intelligence;
            this.Vitality = vitality;
            this.MaxHealth = this.Health;
            this.MaxMana = this.Mana;

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
            if (unit.Health - this.PDamage < 1)
            {
                unit.Health = 0;
                return;
            }

            unit.Health -= this.PDamage;

        }
    }
}