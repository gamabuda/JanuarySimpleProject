namespace RTS.Core
{
    public class Unit
    {
        public int Level { get; set; } = 1;
        public int MaxLevel { get; set; } = 50;
        public int Experience { get; set; } = 0;
        public int ExpForLevelUp { get; set; } = 3000;
        public int Points { get; set; } = 5;

        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int MaxMana { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Vitality { get; set; }
        public int PDamage { get; set; }
        public int Armor { get; set; }
        public int MDamage { get; set; }
        public int MDefense { get; set; }
        public int CrtChance { get; set; }
        public int CrtDamage { get; set; }

        public int MaxStrength { get; set; }
        public int MinStrength { get; set; }
        public int MaxDexterity { get; set; }
        public int MinDexterity { get; set; }
        public int MaxIntelligence { get; set; }
        public int MinIntelligence { set; get; }
        public int MaxVitality { get; set; }
        public int MinVitality { get; set; }


        public Unit()
        {
            this.Strength = Strength;
            this.Dexterity = Dexterity;
            this.Intelligence = Intelligence;
            this.Vitality = Vitality;
        }
        public static void Main(string[] args)
        {
            Unit unit = new Unit();
            unit.ShowInfo();
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Health: {Health}\n Mana: {Mana}\n Strength:{Strength}\n Dexterity: {Dexterity}\n Intelligence: {Intelligence}\n Vitality: {Vitality}");
        }

        public void Attack(Unit unit)
        {
            if (unit.Health < 1)
                return;
            unit.Health -= this.PDamage;

        }

        public void LevelUp()
        {
            if (Level < MaxLevel)
            {
                if (Experience >= ExpForLevelUp)
                {
                    Experience = 0;
                    Level++;
                    Points++;
                    ExpForLevelUp += 1000;
                    if (Level == MaxLevel)
                    {
                        Console.WriteLine("Уровень персонажа повышен до 50. Вы достигли максимального уровня!");
                        return;
                    }
                    Console.WriteLine($"Уровень персонажа повышен до {Level}");
                }
                else
                {
                    Console.WriteLine($"Недостаточно опыта для повышения уровня. Необходимо: {ExpForLevelUp}");
                }
            }
            else
            {
                Console.WriteLine("Уровень персонажа уже достиг максимального значения.");
            }
        }



    }
}