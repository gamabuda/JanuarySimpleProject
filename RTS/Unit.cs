
using System.ComponentModel;
using System.ComponentModel.Design;

namespace RTS
{
    public class Unit : IAttackHandler, IHealthHandler, IManaHandler, IArmorHandler, IInfoHandler, INotifyPropertyChanged
    {
        //Attributes
        public int Strength { get => _strength; set { _strength = value; OnPropertyChanged("Strength"); } }
        public int Dexterity { get => _dexterity; set { _dexterity = value;OnPropertyChanged("Dexterity"); } }
        public int Inteligence { get => _inteligence; set { _inteligence = value; OnPropertyChanged("Inteligence"); } }
        public int Vitality { get => _vitality; set { _vitality = value; OnPropertyChanged("Vitality"); } }

        private int _strength;
        private int _dexterity;
        private int _inteligence;
        private int _vitality;

        //MaxAtributes
        public int MaxStrength { get => _maxStrength; set { _maxStrength = value; } }
        public int MaxDexterity { get => _maxDexterity; set { _maxDexterity = value; } }
        public int MaxInteligence { get => _maxInteligence; set { _maxInteligence = value; } }
        public int MaxVitality { get => _maxVitality; set { _maxVitality = value; } }

        private int _maxStrength;
        private int _maxDexterity;
        private int _maxInteligence;
        private int _maxVitality;

        // HP and MP
        int _health;
        int _mana;
        public int Health { get => _health; set { _health = value; OnPropertyChanged("Health"); } }
        public int Mana { get => _mana; set { _mana = value; OnPropertyChanged("Mana"); } }
        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }

        // Damage
        public int PDamage { get; set; }
        public int MDamage { get; set; }
        public int CrtChanse { get; set; }
        public int CrtDamage { get; set; }

        //Armor
        public int Armor { get; set; }
        public int MDefense { get; set; }

        //Level
        int _lvl = 1;
        public int Level { get => _lvl; set { _lvl = value; OnPropertyChanged("Level"); } } 
        public int MinLvlExperience { get; set; } = 0;

        int _currentExp = 0;
        public int CurrentExperience { get => _currentExp; set { _currentExp = value; OnPropertyChanged("CurrentExperience"); } } 
        public int ExtraExperience { get; set; }

        int _levelingPoints = 5;
        public int LevelingPoints { get => _levelingPoints; set { _levelingPoints = value; OnPropertyChanged("LevelingPoints"); } }
        public int AllLevelingPoints { get; set; } = 5;

        public string Class { get; set; }



        public void CheckingAttributes()
        {
            if (_strength > _maxStrength) 
                Strength = MaxStrength;

            if (_dexterity > _maxDexterity)
                Dexterity = MaxDexterity;

            if (_inteligence > _maxInteligence)
                Inteligence = MaxInteligence;

            if (_vitality > _maxVitality)
                Vitality = MaxVitality;

            CheckStats();
        }

        protected virtual void CheckStats() { }

        public void ShowInfo()
        {
            Console.WriteLine($"HP:{Health}/{MaxHealth}\nMP:{Mana}/{MaxMana}\nSTR:{Strength}\nDEX:{Dexterity}\nINT:{Inteligence}\nVIT:{Vitality}");
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

        public void LevelUp(int gainedExperience)
        {
            if (Level < 50)
            {
                int rightExperience = MinLvlExperience + Level * 1000 - ExtraExperience;

                if (CurrentExperience + gainedExperience >= CurrentExperience + rightExperience)
                {
                    Level++;
                    LevelingPoints++;
                    AllLevelingPoints++;
                    CurrentExperience += gainedExperience;
                    MinLvlExperience += rightExperience;
                    ExtraExperience = 0;
                }
                else
                {
                    CurrentExperience += gainedExperience;
                    ExtraExperience += gainedExperience;
                    return;
                }
            }
            else
                return;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    
}
