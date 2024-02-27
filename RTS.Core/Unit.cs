using RTS.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Unit : IHPHandler, IManaHandler, IAttackHandler
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
        public int _exp;
        public int Exp
        {
            get => _exp;
            set { _exp = value; LevelUp();}
        }
        public int NecessaryExp { get; set; }
        public int NecessaryExpLevelUp { get; set; } = 1000;
        public int Points { get; set; } = 5;
        public int MaxLevel { get; set; } = 50;

        public int MaxStrenght { get;  set; } 
        public int MaxDexterity { get;  set; } 
        public int MaxIntelligence { get;  set; } 
        public int MaxVitality { get;  set; }

        public void Control(Unit unit)
        {
            if (unit.Strength > unit.MaxStrenght)
            {
                unit.Strength = unit.MaxStrenght;
            }

            if (unit.Intelligence > unit.MaxIntelligence)
            {
                unit.Intelligence = unit.MaxIntelligence;
            }

            if (unit.Dexterity > unit.MaxDexterity)
            {
                unit.Dexterity = unit.MaxDexterity;
            }

            if (unit.Vitality > unit.MaxVitality)
            {
                unit.Vitality = unit.MaxVitality;
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
        //public void Attack(Unit unit)
        //{
        //    if (unit.Health - this.PDamage < 1)
        //    {
        //        unit.Health = 0;
        //        return;
        //    }

        //    unit.Health -= this.PDamage;

        //}

        public void Attack(Unit unit)
        {
            if (unit.Health <= 0)
            {
                Console.WriteLine($"{unit} cannot be attacked");
                return;
            }

            Random rand = new Random();
            int randomNumber = rand.Next(0, 21);
            bool isCriticalHit = randomNumber <= CrtChance;

            int damage = CalculateArmor(this.PDamage, unit.Armor);

            if (isCriticalHit)
            {
                damage += CrtDamage;
                Console.WriteLine("Critical hit!");
            }

            unit.TakeDamage(damage);
            Console.WriteLine($"{this} attacks {unit} with a physical attack on {damage} damage");

            if (unit.Health <= 0)
            {
                Console.WriteLine($"{unit} has died >~<!!");
            }
        }

        private int CalculateArmor(int damage, int armor)
        {
            // Броня снижает урон атаки на 30%
            return (int)(damage * (1 - Math.Min(armor / 100.0, 0.3)));
        }

        public void TakeDamage(int damage)
        {
            this.Health -= damage;

            if (this.Health <= 0)
            {
                this.Health = 0;
                Console.WriteLine($"{this} has died >~<!!");
            }
        }


        public void LevelUp()
        {
            if (this.Level < this.MaxLevel)
            {
                if (this.Exp >= NecessaryExpLevelUp)
                {
                    this.Level++;
                    this.Points++;
                    NecessaryExp += 1000;
                    NecessaryExpLevelUp += NecessaryExp + 1000;

                    Console.WriteLine($"Поздравляем, вы достигли уровня {this.Level}! Текущий опыт: {this.Exp}");
                }
                else
                {
                    Console.WriteLine("Недостаточно опыта для повышения уровня");
                }

            }
            else
            {
                Console.WriteLine("Вы достигли максимального уровня! Поздравляем!");
            }
        }

    }
}