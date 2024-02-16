using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Wizard : Unit
    {
        public int HealPoint { get; private set; } = 10;
        public int HealManaCost { get; private set; } = 15;

        public Wizard() : base()
        {
            Strenght = 15;
            Dexterity = 20;
            Intelligence = 35;
            Vitality = 15;

            MaxStrenght = 45;
            MaxDexterity = 80;
            MaxIntelligence = 250;
            MaxVitality = 70;

            Calculate();

            Health = MaxHealth;
            Mana = MaxMana;
        }

        public Wizard(string name) : this()
        {
            Name = name;
        }
        public void Heal(Unit unit)
        {
            if (Mana < HealManaCost)
                return;

            if (unit.GainHealth(HealPoint))
                Mana -= HealManaCost;
        }

        protected override void calculateMaxStats()
        {
            _maxHealthFormula = (int)(Vitality * 1.4 + Strenght * 0.2);
            _maxManaFormula = (int)(Intelligence * 1.5);
            _pDamageFormula = (int)(Strenght * 0.5);
            _mDamageFormula = (int)(Intelligence);
            _armorFormula = (int)(Dexterity);
            _mDefenseFormula = (int)(Intelligence);
            _critChanceFormula = (int)(Dexterity * 0.05);
            _critDamageFormula = (int)(Dexterity * 0.1);
        }
    }
}
