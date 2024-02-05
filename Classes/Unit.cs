namespace Classes
{
    public class Unit
    {
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }

        public int Strenght { get; set { OnStatChange?.Invoke(); } }
        public int Dexterity { get; set { OnStatChange?.Invoke(); } }
        public int Intelligence { get; set { OnStatChange?.Invoke(); } }
        public int Vitality { get; set { OnStatChange?.Invoke(); } }

        public int MaxStrenght { get; private set; }
        public int MaxDexterity { get; private set; }
        public int MaxIntelligence { get; private set; }
        public int MaxVitality { get; private set; }

        public Unit(int strenght, int dexterity, int intelligence, int vitality)
        {
            OnStatChange = checkStat;
            OnStatChange += calculateDamage;

            Strenght = strenght;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Vitality = vitality;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"HP:{Health}\nMP:{Mana}\nSTR:{Strenght}\nDEX:{Dexterity}\nINT:{Intelligence}\nVIT:{Vitality}");
        }

        public event Action OnStatChange;

        protected void checkStat() 
        {
            if (Strenght > MaxStrenght)
                throw new Exception($"У данного юнита не может быть больше {MaxStrenght} силы");

            if (Intelligence > MaxIntelligence)
                throw new Exception($"У данного юнита не может быть больше {Intelligence} силы");

            if (Dexterity > MaxDexterity)
                throw new Exception($"У данного юнита не может быть больше {Dexterity} силы");

            if (Vitality > MaxVitality)
                throw new Exception($"У данного юнита не может быть больше {Vitality} силы");
        }

        protected abstract void calculateDamage();
    }
}