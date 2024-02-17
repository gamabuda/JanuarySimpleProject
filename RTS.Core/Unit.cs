using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Unit
    {
        public int Level { get; set; } = 0;
        public int Points { get; set; } = 0;
        public int LevelUpPoints { get; set; } = 1000;
        public int Health { get; set; }
        public int Mana { get; set; }

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
        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }
        public int Inteligence { get; set; }

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

        public void LevelUp(Unit unit)
        {
            if (this.Level <= 50)
            {
                int index = (Level - 1) * 1000;

                if (Points >= Points + index)
                    Level++;
                else
                    return;
            }
        }

        public void LevelUp()
        {
            throw new NotImplementedException();
        }

        public Unit()
        {
            MaxHealth = Health;
            MaxMana = Mana;
        }

    }

    namespace RTS.Core
    {
        public class Unit : INotifyPropertyChanged
        {
            public int Level { get; set; } = 0;
            public int Points { get; set; } = 0;
            public int LevelUpPoints { get; set; } = 1000;
            public int Health { get; set; }
            public int Mana { get; set; }

            private int strength;
            public int Strength
            {
                get { return strength; }
                set { strength = value; OnPropertyChanged("Strength"); }
            }

            private int dexterity;
            public int Dexterity
            {
                get { return dexterity; }
                set { dexterity = value; OnPropertyChanged("Dexterity"); }
            }

            private int intelligence;
            public int Intelligence
            {
                get { return intelligence; }
                set { intelligence = value; OnPropertyChanged("Intelligence"); }
            }

            private int vitality;
            public int Vitality
            {
                get { return vitality; }
                set { vitality = value; OnPropertyChanged("Vitality"); }
            }

            // ... (other existing properties and methods)

            public event PropertyChangedEventHandler PropertyChanged;

            protected void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

            public void LevelUp()
            {
                if (this.Level <= 50)
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
}