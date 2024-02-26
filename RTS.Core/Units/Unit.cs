using RTS.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.Units
{
    public class Unit : IHealthHandler, IManaHandler, IAttackHandler
    {
        public int Level { get; set; } = 1;
        public int MaxLevel { get; private set; } = 50;
        public int Experience { get; set; } = 0;
        public int LevelUpExperience { get; private set; } = 0;
        public int LevelUpMinExperience { get; private set; } = 1000;

        public int Health { get; set; }
        public int Mana { get; set; }
        public int Points { get; set; } = 5;
        public string Icon { get; set; }

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

        public void PAttack(Unit unit)
        {
            int damage = (int)(PDamage - 0.3 * unit.Armor - 0.1 * unit.Vitality - 0.1 * unit.Dexterity);

            if (damage < 1)
                damage = 1;

            if (unit.Health - damage < 1)
            {
                unit.Health = 0;
                return;
            }

            unit.Health -= damage;
        }

        public void MAttack(Unit unit)
        {
            int damage = MDamage;

            if (unit is Wizard)
            {
                damage = (int)(MDamage - 0.3 * unit.Armor - 0.1 * unit.Vitality);
            }

            if (damage < 1)
                damage = 1;

            if (unit.Health - damage < 1)
            {
                unit.Health = 0;
                return;
            }

            unit.Health -= damage;
        }

        public void LevelUp()
        {
            if (Level <= MaxLevel - 1)
            {
                if (Experience >= LevelUpMinExperience)
                {
                    Level++;
                    Points++;
                    LevelUpExperience += 1000;
                    LevelUpMinExperience += LevelUpExperience + 1000;
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (Level == MaxLevel)
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
                    Console.WriteLine($"Недостаточно опыта для повышения уровня. Необходимо: {LevelUpMinExperience}");
                    Console.ResetColor();
                }
            }
            else
                return;
        }
    }
}
