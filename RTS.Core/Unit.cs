using RTS.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Unit : IHealthHandler, IManaHandler, IAttackHandler
    {
        public int Level { get; set; } = 1;
        private int _maxLevel = 50;
        public int Experience { get; set; } = 0;
        private int _levelUpExperience = 0;
        private int _levelUpMinExperience = 1000;

        public int Health { get; set; }
        public int Mana { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Vitality { get; set; }
        public int PDamage { get; set; }
        public int MDamage { get; set; }
        public int Armor { get; set; }
        public int MDefense { get; set; }
        public int CrtChance { get; set; }
        public int CrtDamage { get; set; }

        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }
        public int MaxStrength { get; set; }
        public int MaxDexterity { get; set; }
        public int MaxIntelligence { get; set; }
        public int MaxVitality { get; set; }

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
            if (unit.Health - this.PDamage < 1)
            {
                unit.Health = 0;
                return;
            }

            unit.Health -= this.PDamage;
        }

        public void LevelUp()
        {
            if (Level <= _maxLevel - 1)
            {
                if (Experience >= _levelUpMinExperience)
                {
                    Level++;
                    _levelUpExperience += 1000;
                    _levelUpMinExperience += _levelUpExperience + 1000;
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (Level == _maxLevel)
                    {
                        Console.WriteLine("Уровень персонажа повышен до 50. Достигнут максимальный уровень!");
                        Console.ResetColor();
                        return;
                    } 
                    Console.WriteLine("Уровень персонажа повышен до " + Level);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Недостаточно опыта для повышения уровня. Необходимо: {_levelUpMinExperience}");
                    Console.ResetColor();
                }
            } else
                return;
        }
    }
}
