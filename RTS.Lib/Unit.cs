using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Lib
{
    public class Unit : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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
            if (unit.Health - this.PDamage < 1)
            {
                unit.Health = 0;
                return;
            }

            unit.Health -= this.PDamage;
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
                    OnPropertyChanged(nameof(Lvl));
                    OnPropertyChanged(nameof(Exp));
                    OnPropertyChanged(nameof(MaxExp));
                    Console.WriteLine($"Вы достигли уровня {Lvl}!\nВаш текущий опыт: {Exp}");
                }
            }
        }
    }
}
