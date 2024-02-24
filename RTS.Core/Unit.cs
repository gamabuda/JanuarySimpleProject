using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public int Level { get; set; } = 1;
        public int Exp { get; set; }
        public int MaxLevel { get; set; } = 50;

        public int MaxStrenght { get;  set; } 
        public int MaxDexterity { get;  set; } 
        public int MaxIntelligence { get;  set; } 
        public int MaxVitality { get;  set; }

        public void Control()
        {
            if (Strength > MaxStrenght)
            {
                Strength = MaxStrenght;
            }

            if (Intelligence > MaxIntelligence)
            {
                Intelligence = MaxIntelligence;
            }

            if (Dexterity > MaxDexterity)
            {
                Dexterity = MaxDexterity;
            }

            if (Vitality > MaxVitality)
            {
                Vitality = MaxVitality;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Health: {Health}\n" +
                $"Mana: {Mana}\n\t" +
                $"Strength: {Strength}\n\t" +
                $"Dexterity: {Dexterity}\n\t" +
                $"Intelligence: {Intelligence}\n\t" +
                $"Vitality: {Vitality}");
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

        public void LevelUp()
        {
            if (this.Level < this.MaxLevel)
            {
                int NecessaryExp = (this.Level - 1) * 1000;

                if (this.Exp < NecessaryExp)
                {
                    Console.WriteLine("Недостаточно опыта для повышения уровня");
                    return;
                }

                this.Level++;
                this.Exp -= NecessaryExp;
                Console.WriteLine($"Поздравляем, вы достигли уровня {this.Level}! Текущий опыт: {this.Exp}");
            }
            else
            {
                Console.WriteLine("Вы достигли максимального уровня! Поздравляем!");
            }
        }

    }
}