namespace Classes
{
    public class Unit
    {
        public int PhysicalDamage { get; protected set; }
        public int Armor { get; protected set; }
        public int CriticalChance { get; protected set; }
        public int CriticalDamage { get; protected set; }
        public int MagicalDamage { get; protected set; }
        public int MagicDefense { get; protected set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Level { get; protected set; }
        public int Experience { get => Experience; set { Experience = value; Level = calculateLevel(); } }

        protected int _str;
        protected int _dex;
        protected int _int;
        protected int _vit;

        public int Strenght { get => _str; protected set { _str = value; onStatChange?.Invoke(); } }
        public int Dexterity { get => _dex; protected set { _dex = value; onStatChange?.Invoke(); } }
        public int Intelligence { get => _int; protected set { _int = value; onStatChange?.Invoke(); } }
        public int Vitality { get => _vit; protected set { _vit = value; onStatChange?.Invoke(); } }

        public int BaseStrenght { get; protected set; }
        public int BaseDexterity { get; protected set; }
        public int BaseIntelligence { get; protected set; }
        public int BaseVitality { get; protected set; }

        public int MaxStrenght { get; protected set; }
        public int MaxDexterity { get; protected set; }
        public int MaxIntelligence { get; protected set; }
        public int MaxVitality { get; protected set; }

        public int MaxHealth { get; protected set; }
        public int MaxMana { get; protected set; }

        protected int _maxHealthFormula = 0;
        protected int _maxManaFormula = 0;
        protected int _pDamageFormula = 0;
        protected int _mDamageFormula = 0;
        protected int _armorFormula = 0;
        protected int _mDefenseFormula = 0;
        protected int _critChanceFormula = 0;
        protected int _critDamageFormula = 0;

        public Unit(int strenght, int dexterity, int intelligence, int vitality)
        {
            Strenght = strenght;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Vitality = vitality;

            onStatChange = Calculate;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"HP:{Health}/{MaxHealth}\nMP:{Mana}/{MaxMana}\nSTR:{Strenght}\nDEX:{Dexterity}\nINT:{Intelligence}\nVIT:{Vitality}");
        }

        protected event Action onStatChange;

        protected void checkStat() 
        { 
            if (Strenght > MaxStrenght && MaxStrenght != 0)
            {
                Console.WriteLine($"У данного юнита не может быть больше {MaxStrenght} силы");
                _str = MaxStrenght;
            }

            if (Intelligence > MaxIntelligence && MaxIntelligence != 0)
            {
                Console.WriteLine($"У данного юнита не может быть больше {MaxIntelligence} интеллекта");
                _int = MaxIntelligence;
            }

            if (Dexterity > MaxDexterity && MaxDexterity != 0)
            {
                Console.WriteLine($"У данного юнита не может быть больше {MaxDexterity} ловкости");
                _dex = MaxDexterity;
            }

            if (Vitality > MaxVitality && MaxVitality != 0)
            {
                Console.WriteLine($"У данного юнита не может быть больше {MaxVitality} выносливости");
                _vit = MaxVitality;
            }
        }

        public void Attack(Unit unit)
        {
            unit.Health -= PhysicalDamage;
        }

        protected void calculateHealth()
        {
            MaxHealth = _maxHealthFormula;
        }

        protected void calculateMana()
        {
            MaxMana = _maxManaFormula;
        }

        protected void calculateDamage()
        {
            PhysicalDamage = _pDamageFormula;
            MagicalDamage = _mDamageFormula;
            CriticalChance = _critChanceFormula;
            CriticalDamage = _critDamageFormula;
        }

        protected void calculateDefense()
        {
            Armor = _armorFormula;
            MagicDefense = _mDefenseFormula;
        }

        protected virtual void calculateMaxStats() { }

        protected void Calculate()
        {
            checkStat();
            calculateMaxStats();
            calculateHealth();
            calculateMana();
            calculateDamage();
            calculateDefense();
        }

        protected int calculateLevel()
        {
            

            return 0;
        }
    }
}