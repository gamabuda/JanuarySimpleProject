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
        public int Health { get; protected set; }
        public int Mana { get; protected set; }


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

        protected int _maxHealthFormula;
        protected int _maxManaFormula;
        protected int _pDamageFormula;
        protected int _mDamageFormula;
        protected int _armorFormula;
        protected int _mDefenseFormula;
        protected int _critChanceFormula;
        protected int _critDamageFormula;

        public Unit(int strenght, int dexterity, int intelligence, int vitality)
        {
            Strenght = strenght;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Vitality = vitality;

            onStatChange = checkStat;
            onStatChange += calculateHealth;
            onStatChange += calculateMana;
            onStatChange += calculateDamage;
            onStatChange += calculateDefense;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"HP:{Health}\nMP:{Mana}\nSTR:{Strenght}\nDEX:{Dexterity}\nINT:{Intelligence}\nVIT:{Vitality}");
        }

        protected event Action onStatChange;

        protected void checkStat() 
        {
            if (Strenght > MaxStrenght && MaxStrenght != 0)
            {
                Console.WriteLine($"У данного юнита не может быть больше {MaxStrenght} силы");
                Strenght = MaxStrenght;
            }

            if (Intelligence > MaxIntelligence && MaxIntelligence != 0)
            {
                Console.WriteLine($"У данного юнита не может быть больше {MaxIntelligence} интеллекта");
                Intelligence = MaxIntelligence;
            }

            if (Dexterity > MaxDexterity && MaxDexterity != 0)
            {
                Console.WriteLine($"У данного юнита не может быть больше {MaxDexterity} ловкости");
                Dexterity = MaxDexterity;
            }

            if (Vitality > MaxVitality && MaxVitality != 0)
            {
                Console.WriteLine($"У данного юнита не может быть больше {MaxVitality} выносливости");
                Vitality = MaxVitality;
            }
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

        public void Attack(Unit unit)
        {
            unit.Health -= PhysicalDamage;
        }
    }
}