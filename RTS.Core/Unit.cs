﻿using System.ComponentModel;
using System.Xml.Linq;

namespace RTS.Core
{
    public class Unit : INotifyPropertyChanged
    {
        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }
        public int Armor { get; set; }
        private int _startspoints;
        public int StartsPoints 
        {
            get => _startspoints;
            set
            {
                _startspoints = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StartsPoints)));
            }
        }

        public int HP { get; set; }
        public int Mana { get; set; }
        private int _level;
        public int MaxLevel { get; set; } = 50;
        public int Level
        {
            get => _level;
            set
            {
                _level = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Level)));
            }
        }
        private int _experience;
        public int Experience 
        {
            get => _experience;
            set
            {
                _experience = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Experience)));
            }
        }

        private int _vitality;
        public int Vitality 
        {
            get => _vitality;
            set
            {
                _vitality = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Vitality)));
            }
        }

        private int _strength;
        public int Strength
        {
            get => _strength;
            set
            {
                _strength = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Strength)));
            }
        }

        private int _inteligence;
        public int Inteligence 
        {
            get => _inteligence;
            set
            {
                _inteligence = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Inteligence)));
            }
        }

        private int _dexterity;
        public int Dexterity 
        {
            get => _dexterity;
            set
            {
                _dexterity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Dexterity)));
            }
        }

        public int Damage { get; set; }
        public int MagicalDamage { get; set; }
        public int MagicalDefense { get; set; }
        public int CriticalChanse { get; set; }
        public int CriticalDamage { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public Unit()
        {
            Level = 1;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"Health: {HP}\nMana: {Mana}\nStrength: {Strength}\nDexterity: {Dexterity}\nVitality: {Vitality}");
        }

        public void DealDamage(Unit target)
        {
            if(target.HP - this.Damage < 1)
            {
                target.HP = 0;
                return;
            }

            target.HP -= this.Damage;
        }
        public void LevelUp()
        {
            if (Level < MaxLevel)
            {
                int currentLevel = Level;
                int currentExperience = Experience;
                int necessaryEXP = currentLevel * 1000;

                if (currentExperience >= necessaryEXP)
                {
                    Level++;
                    Experience = currentExperience - necessaryEXP;
                }
            }
        }
    }
}