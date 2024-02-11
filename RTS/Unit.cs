
using System.ComponentModel.Design;

namespace RTS
{
    public class Unit
    {
        //Attributes
        protected int Strength { get => _strength; set { _strength = value; } }
        protected int Dexterity { get => _dexterity; set { _dexterity = value; } }
        protected int Inteligence { get => _inteligence; set { _inteligence = value; } }
        protected int Vitality { get => _vitality; set { _vitality = value; } }

        private int _strength;
        private int _dexterity;
        private int _inteligence;
        private int _vitality;

        //MaxAtributes
        protected int MaxStrength { get => _maxStrength; set { _maxStrength = value; } }
        protected int MaxDexterity { get => _maxDexterity; set { _maxDexterity = value; } }
        protected int MaxInteligence { get => _maxInteligence; set { _maxInteligence = value; } }
        protected int MaxVitality { get => _maxVitality; set { _maxVitality = value; } }

        private int _maxStrength;
        private int _maxDexterity;
        private int _maxInteligence;
        private int _maxVitality;

        // HP and MP
        public int Health { get; set; }
        public int Mana { get; set; }
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

        protected void CheckingAttributes()
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
    }

    
}
