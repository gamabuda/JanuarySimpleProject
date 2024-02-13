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
        public int Level { get; set; }
        public int Exp { get; set; }

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

        public void LevelUp(Unit unit)
        {
            if (unit.Level < 50)
            {
                int NecessaryExp = (unit.Level - 1) * 1000;

                while (unit.Exp < NecessaryExp)
                {
                    Console.WriteLine("Недостаточно опыта для повышения уровня");
                    return;
                }

                unit.Level++;
                unit.Exp -= NecessaryExp;
                Console.WriteLine($"Поздравляем, вы достигли уровня {unit.Level}! Текущий опыт: {unit.Exp}");
            }
            else
            {
                Console.WriteLine("Вы достигли максимального уровня! Поздравляем!");
            }
        }

    }
}