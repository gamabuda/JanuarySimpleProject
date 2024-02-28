using System.Reflection.Emit;

namespace RTS.Core
{
    public class Unit
    {
        public int Vitality { get; set; } //выносливость
        public int Mana { get; set; }
        public int Health { get; set; } //здоровье
        public int Strenght { get; set; } //сила
        public int Dexterity { get; set; } //ловкость
        public int Intelligence { get; set; } //интеллект

        public int MaxStrenght { get; set; }
        public int MaxDexterity { get; set; }
        public int MaxIntelligence { get; set; }
        public int MaxVitality { get; set; }

        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }

        public int PDamage { get; set; }
        public int Armor { get; set; }
        public int MDamage { get; set; }
        public int MDefense { get; set; }
        public int CrtChance { get; set; }
        public int CrtDamage { get; set; }

        public int Level { get; set; } = 1;
        public int MyExperience = 0;

        public void ShowInfo()
        {
            Console.WriteLine($"Health: {Health}\nMana: {Mana}\nS: {Strenght}\nD: {Dexterity}\nI: {Inteligense}\nV: {Vitality}");
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
            if (Level <= 50)
            {
                int NewExperience = (Level - 1) * 1000;

                if (MyExperience >= MyExperience + NewExperience)
                {
                    Level++;
                    return;
                }
                else
                {
                    Console.WriteLine("У вас мало опыта");
                }
            }

            else
            {
                Console.WriteLine("Вы достигли максимального уровня");
            }
        }
    }
}