using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Wizard : Unit
    {
        

        public int HealPoint { get; set; } = 10;

        public Wizard(int strenght, int dexterity, int intelligence, int vitality) : base(strenght, dexterity, intelligence, vitality)
        {
            BaseStrenght = 15;
            BaseDexterity = 20;
            BaseIntelligence = 35;
            BaseVitality = 15;

            MaxStrenght = 45;
            MaxDexterity = 80;
            MaxIntelligence = 250;
            MaxVitality = 70;

            Calculate();

            Health = MaxHealth;
            Mana = MaxMana;
        }

        public void Heal(Unit unit)
        {
            if (Mana < 15)
                return;

            unit.Health += HealPoint;
            Mana -= 15;
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
