using RTS.Core.Interfaces;
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
        public int _exp;
        public int Exp
        {
            get => _exp;
            set { _exp = value; LevelUp();}
        }
        public int NecessaryExp { get; set; } = 1000;
        public int Points { get; set; } = 5;
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
        //public void Attack(Unit unit)
        //{
        //    if (unit.Health - this.PDamage < 1)
        //    {
        //        unit.Health = 0;
        //        return;
        //    }

        //    unit.Health -= this.PDamage;

        //}

        public void PAttack(Unit unit)
        {
            if (IsCriticalHit())
            {
                unit.PDamage += CrtDamage;
            }

            if (unit.Health - (this.PDamage - unit.Armor) < 1)
            {
                unit.Health = 0;
                return;
            }

            unit.Health -= (this.PDamage - unit.Armor);
        }

        public void MAttack(Unit unit)
        {
            if (IsCriticalHit())
            {
                unit.MDamage += CrtDamage;
            }

            if (unit.Health - (this.MDamage - unit.MDefence) < 1)
            {
                unit.Health = 0;
                return;
            }

            unit.Health -= (this.MDamage - unit.MDefence);
        }

        private bool IsCriticalHit()
        {
            Random rand = new Random();
            return rand.Next(50) <= CrtChance;
        }

        public void TakeDamage(Unit unit)
        {
            if (unit.PDamage - this.Armor < 1)
            {
                unit.PDamage = 0; 
            }

            if (MDefence > 0)
            {
                unit.PDamage -= MDefence;
                if (unit.PDamage < 0)
                {
                    unit.PDamage = 0; 
                }
            }

            unit.Health -= unit.PDamage;

            if (unit.Health <= 0)
            {
                unit.Health = 0; 
                Console.WriteLine($"{unit} has died >~<!!");
            }
        }

        public void Armorr(Unit unit)
        {
            if (Armor > 0)
            {
                Armor -= unit.Armor;

                if (Armor < 0)
                {
                    unit.Health += Armor;
                    Armor = 0;
                }
            }
            else
            {
                unit.Health -= unit.Armor;
            }

            if (unit.Health <= 0)
            {
                unit.Health = 0;
                Console.WriteLine($"{unit} has died >~<!!");
            }
        }

        public void LevelUp()
        {
            NecessaryExp = (this.Level - 1) * 1000;

            if (this.Level < this.MaxLevel)
            {

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