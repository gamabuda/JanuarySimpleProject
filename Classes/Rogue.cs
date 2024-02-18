using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Rogue : Unit
    {
        public string Icon { get; set; } = "Icons\\Rogue.png";
        public Rogue() : base()
        {
            Strenght = 20;
            Dexterity = 30;
            Intelligence = 15;
            Vitality = 20;

            MaxStrenght = 65;
            MaxDexterity = 250;
            MaxIntelligence = 70;
            MaxVitality = 80;

            Calculate();

            Health = MaxHealth;
            Mana = MaxMana;
        }

        public Rogue(string name) : this()
        {
            Name = name;
        }

        protected override void calculateMaxStats()
        {
            _maxHealthFormula = (int)(Vitality * 1.5 + Strenght * 0.5);
            _maxManaFormula = (int)(Intelligence * 1.2);
            _pDamageFormula = (int)(Strenght * 0.5 + Dexterity * 0.5);
            _mDamageFormula = (int)(Intelligence * 0.2);
            _armorFormula = (int)(Dexterity * 1.5);
            _mDefenseFormula = (int)(Intelligence * 0.5);
            _critChanceFormula = (int)(Dexterity * 0.05);
            _critDamageFormula = (int)(Dexterity * 0.1);
        }
    }
}
