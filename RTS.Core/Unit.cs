using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Unit : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public int Level { get; set; } = 1;
        public int Points { get; set; } = 5;
        public int LevelUpPoints { get; set; } = 1000;
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Experience { get; set; } = 0;


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
        
        private int _intelligence;
        public int Intelligence
        {
            get => _intelligence;
            set
            {
                _intelligence = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Intelligence)));
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
        public int MaxStrength { get; set; }
        public int MaxDexterity { get; set; }
        public int MaxIntelligence { get; set; }
        public int MaxVitality { get; set; }
        public int PDamage { get; set; }
        public int MDamage { get; set; }
        public int Armor { get; set; }
        public int MDefense { get; set; }
        public int CrtChance { get; set; }
        public int CrtDamage { get; set; }
        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }


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
            if (unit.Health - PDamage < 1)
            {
                unit.Health = 0;
                return;
            }

            unit.Health -= PDamage;
        }

        public void LevelUp()
        {
            if (Level <= 50)
            {
                int index = (Level - 1) * 1000;

                if (Points >= Points + index)
                    Level++;
                else
                    return;
            }
        }
    }
}
