
using System.ComponentModel.Design;

namespace RTS
{
    public class Unit : IAttackHandler, IHealthHandler, IManaHandler, IArmorHandler, IInfoHandler
    {
        //Attributes
        public int Strength { get => _strength; set { _strength = value; CheckingAttributes(); } }
        protected int Dexterity { get => _dexterity; set { _dexterity = value; CheckingAttributes(); } }
        protected int Inteligence { get => _inteligence; set { _inteligence = value; CheckingAttributes(); } }
        protected int Vitality { get => _vitality; set { _vitality = value; CheckingAttributes(); } }

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

        //Level
        public int Level { get; set; }
        public int Experience { get; set; }

        protected event Action onStatChange;

        public Unit() : base()
        {
            onStatChange += CheckingAttributes;
        }



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

        public void LevelUp(Unit target)
        {
            if (target.Level < 50)
            {
                int CurrentLevel = target.Level;
                int CurrentExperience = target.Experience;
                int NeccecaryEXP = (CurrentLevel - 1) * 1000;

                if (CurrentExperience >= CurrentExperience + NeccecaryEXP)
                    target.Level++;
                else
                    return;
            }
            else
                return;
        }
    }

    
}
