using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Lib
{
    public class Unit : INotifyPropertyChanged, IAttackHadler, IHealthHandler, IManaHandler
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int PDamage { get; set; }
        public int MDamage { get; set; }
        public int Armor { get; set; }
        public int MDefense { get; set; }
        public int CrtChance { get; set; }
        public int CrtDamage { get; set; }
        public int MaxLvl { get; set; } = 50;

        public Unit()
        {
            Lvl = 1; 
            Exp = 0; 
            MaxLvl = 50; 
        }

        public int _lvl;
        public int Lvl
        {
            get { return _lvl; }
            set
            {
                if (_lvl != value)
                {
                    _lvl = value;
                    OnPropertyChanged(nameof(Lvl));
                }
            }
        }

        public int _exp;
        public int _maxExp;
        public int Exp
        {
            get { return _exp; }
            set
            {
                if (_exp != value)
                {
                    _exp = value;
                    OnPropertyChanged(nameof(Exp));
                    LevelUp();
                }
            }
        }

        public int MaxExp
        {
            get { return (Lvl - 1) * 1000; }
            set
            {
                _maxExp = value;
                OnPropertyChanged(nameof(MaxExp));
            }
        }

        public int _health;
        public int _maxHealth;

        public int Health
        {
            get { return _health; }
            set
            {
                _health = value;
                OnPropertyChanged(nameof(Health));
            }
        }

        public int MaxHealth
        {
            get { return _maxHealth; }
            set
            {
                _maxHealth = value;
                OnPropertyChanged(nameof(MaxHealth));
            }
        }

        public int _mana;
        public int _maxMana;

        public int Mana
        {
            get { return _mana; }
            set
            {
                _mana = value;  
                OnPropertyChanged(nameof(Mana));
            }
        }

        public int MaxMana
        {
            get { return _maxMana; }
            set
            {
                _maxMana = value;
                OnPropertyChanged(nameof(MaxMana));
            }
        }

        public int _strength;
        public int Strength
        {
            get { return _strength; }
            set
            {
                _strength = value;
                OnPropertyChanged(nameof(Strength));
            }
        }

        public int _dexterity;
        public int Dexterity
        {
            get { return _dexterity; }
            set
            {
                _dexterity = value;
                OnPropertyChanged(nameof(Dexterity));
            }
        }

        public int _intelligence;
        public int Intelligence
        {
            get { return _intelligence; }
            set
            {
                _intelligence = value;
                OnPropertyChanged(nameof(Intelligence));
            }
        }

        public int _vitality;
        public int Vitality
        {
            get { return _vitality; }
            set
            {
                _vitality = value;
                OnPropertyChanged(nameof(Vitality));
            }
        }

        private int _minStrength; // Минимальное значение для Strength
        public int MinStrength
        {
            get { return _minStrength; }
            set
            {
                _minStrength = value;
                OnPropertyChanged(nameof(MinStrength));
            }
        }

        private int _minDexterity; // Минимальное значение для Dexterity
        public int MinDexterity
        {
            get { return _minDexterity; }
            set
            {
                _minDexterity = value;
                OnPropertyChanged(nameof(MinDexterity));
            }
        }

        private int _minIntelligence; // Минимальное значение для Intelligence
        public int MinIntelligence
        {
            get { return _minIntelligence; }
            set
            {
                _minIntelligence = value;
                OnPropertyChanged(nameof(MinIntelligence));
            }
        }

        private int _minVitality; // Минимальное значение для Vitality
        public int MinVitality
        {
            get { return _minVitality; }
            set
            {
                _minVitality = value;
                OnPropertyChanged(nameof(MinVitality));
            }
        }

        public int _startPoints = 5;
        public int StartPoints
        {
            get { return _startPoints; }
            set
            {
                _startPoints = value;
                OnPropertyChanged(nameof(StartPoints));
            }
        }

        
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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
            if (unit.Health - this.PDamage < 1 && unit.Armor == 0 || unit.Health - (PDamage / 2) < 1 && unit.Armor > 1)
            {
                unit.Health = 0;
                return;
            }

            if (unit.Armor > 1)
            {
                unit.Health -= (int)(this.PDamage * 0.5);
                unit.Armor = (int)(unit.Armor * 0.5);
            }
            else
            {
                unit.Health -= this.PDamage;
            }
        }

        private int _totalExp;
        public int totalExp
        {
            get => _totalExp;
            set
            {
                _totalExp = value;
                OnPropertyChanged(nameof(totalExp));
            }
        }

        public void LevelUp()
        {
            if (Lvl < MaxLvl)
            {
                int expToNextLevel = (Lvl - 1) * 1000;

                if (Exp >= expToNextLevel)
                {
                    Lvl++;
                    Exp -= expToNextLevel;
                    StartPoints++;
                    OnPropertyChanged(nameof(Lvl));
                    OnPropertyChanged(nameof(Exp));
                    OnPropertyChanged(nameof(MaxExp));
                    OnPropertyChanged(nameof(StartPoints));
                    Console.WriteLine($"Вы достигли уровня {Lvl}!\nВаш текущий опыт: {Exp}");
                }
            }
        }
    }
}
