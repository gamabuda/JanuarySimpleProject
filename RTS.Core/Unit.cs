using System.ComponentModel;
using System.Xml.Linq;

namespace RTS.Core
{
    public class Unit
    {
        private int _xp;
        public int OldXP 
        { 
            get => _xp;
            set
            {
                if (_xp != value)
                {
                    _xp = value;
                    OnPropertyChanged("XP");
                }
            }
        } 
        public int NewXp { get; set; } = 1000;

        private int _level = 1;
        public int Level 
        {
            get => _level;
            set
            {
                if (_level != value)
                {
                    _level = value;
                    OnPropertyChanged("Level");
                }

            }
        } 
        public double MaxHealth { get; set; }
        public double MaxMana { get; set; }
        public double Armor { get; set; }
        private double _healthpoint;
        public double HP 
        { 
            get => _healthpoint;
            set
            {
                if (_healthpoint != value)
                {
                    _healthpoint = value;
                    OnPropertyChanged("HP");
                }
            }
        }
        private double _mana;
        public double Mana 
        { 
            get => _mana;
            set
            {
                if (_mana != value)
                {
                    _mana = value;
                    OnPropertyChanged("Mana");
                }
            }
        }
        private int _vitality;
        public int Vitality 
        { 
            get => _vitality;
            set
            {
                if (_vitality != value)
                {
                    _vitality = value;
                    OnPropertyChanged("Vitality");
                }
            }
        }
        private int _strength;
        public int Strength 
        { 
            get => _strength;
            set
            {
                if (_strength != value)
                {
                    _strength = value;
                    OnPropertyChanged("Strength");
                }
            }
        }
        private int _inteligence;
        public int Inteligence 
        { 
            get => _inteligence;
            set
            {
                if (_inteligence != value)
                {
                    _inteligence = value;
                    OnPropertyChanged("Inteligence");
                }
            }
        }
        private int _dexterity;
        public int Dexterity
        {
            get => _dexterity;
            set
            {
                if (_dexterity != value)
                {
                    _dexterity = value;
                    OnPropertyChanged("Dexterity");
                }
            }
        } 

        public double Damage { get; set; }
        public double MagicalDamage { get; set; }
        public double MagicalDefense { get; set; }
        public double CriticalChanse { get; set; }
        public double CriticalDamage { get; set; }
        private int _startPoint = 5;
        public int StartPoint
        { 
            get => _startPoint;
            set
            {
                if (_startPoint != value)
                {
                    _startPoint = value;
                    OnPropertyChanged("StartPoint");
                }
            }
        } 
        public void Attack(Unit u)
        {
            if (u.HP - u.Damage < 1)
            {
                u.HP = 0;
                return;
            }
            u.HP -= u.Damage;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Health: {HP}\nMana: {Mana}\nStrength: {Strength}\nDexterity: {Dexterity}\nVitality: {Vitality}\nLevel: {Level}\nXP: {OldXP}" );
        }
        public void LevelUp()
        {

            if (Level == Level++)
            {

                OldXP += NewXp;
            }
            
            NewXp += 1000;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
