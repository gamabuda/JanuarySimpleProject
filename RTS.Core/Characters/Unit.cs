using System.ComponentModel;

uusing System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTS.Core.Interfaces;

namespace RTS.Core.Characters
{
    public class Unit : INotifyPropertyChanged, IHealthHandler, IManaHandler, IAttackHandler

    {
        private int strength;
        public int Strength
        {
            get { return strength; }
            set
            {
                if (strength != value)
                {
                    strength = value;
                    OnPropertyChanged(nameof(Strength));
                }
            }
        }
        private int dexterity;
        public int Dexterity
        {
            get { return dexterity; }
            set
            {
                if (dexterity != value)
                {
                    dexterity = value;
                    OnPropertyChanged(nameof(Dexterity));
                }
            }
        }
        private int intelligence;
        public int Intelligence
        {
            get { return intelligence; }
            set
            {
                if (intelligence != value)
                {
                    intelligence = value;
                    OnPropertyChanged(nameof(Intelligence));
                }
            }
        }
        private int vitality;
        public int Vitality
        {
            get { return vitality; }
            set
            {
                if (vitality != value)
                {
                    vitality = value;
                    OnPropertyChanged(nameof(Vitality));
                }
            }
        }
        public string Image { get; set; }
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int MaxMana { get; set; }
        public int Mana { get; set; }
        public int PDamage { get; set; }
        public int Armor { get; set; }
        public int MDamage { get; set; }
        public int MDefense { get; set; }
        public int CrtChance { get; set; }
        public int CrtDamage { get; set; }
        public int MaxStrength { get; set; }
        public int MaxDexterity { get; set; }
        public int MaxIntelegence { get; set; }
        public int MaxVitality { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Health: {Health}\n" +
                $"Mana: {Mana}\n\t" +
                $"Strength: {Strength}\n\t" +
                $"Dexterity: {Dexterity}\n\t" +
                $"Intelligence: {Intelligence}\n\t" +
                $"Virality: {Vitality}");
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


        private int experience;
        public int Experience
        {
            get { return experience; }
            set
            {
                if (experience != value)
                {
                    experience = value;
                    OnPropertyChanged(nameof(Experience));
                    CalculateLevel();
                }
            }
        }

        private int level;
        public int Level
        {
            get { return level; }
            set
            {
                if (level != value)
                {
                    level = value;
                    OnPropertyChanged(nameof(Level));
                }
            }
        }
        public void GetExperience(int amount)
        {
            Experience += amount;
        }
        private void CalculateLevel()
        {
            if (Level < 50)
            {
                int requiredExperience = Level * 1000 - 1000;
                if (Experience >= requiredExperience)
                {
                    Level++;
                    Console.WriteLine($"Level {Level}!");
                }
            }
        }
        public void Attack(IHealthHandler target)
        {
            int damage = CalculateDamage(target);
            ApplyDamage(target, damage);
        }

        private int CalculateDamage(IHealthHandler target)
        {
            int damage = PDamage - target.Armor;
            return damage < 0 ? 0 : damage;
        }

        private void ApplyDamage(IHealthHandler target, int damage)
        {
            target.Health -= damage;
            if (target.Health < 0)
            {
                target.Health = 0;
            }
        }
    }
}