﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Warrior : Unit
    {
        public Warrior() : base()
        {
            Strenght = 30;
            Dexterity = 15;
            Intelligence = 10;
            Vitality = 25;

            MaxStrenght = 250;
            MaxDexterity = 80;
            MaxIntelligence = 50;
            MaxVitality = 25;

            Calculate();

            Health = MaxHealth;
            Mana = MaxMana;
        }

        public Warrior(string name): this()
        {
            Name = name;
        }

        protected override void calculateMaxStats()
        {
            _maxHealthFormula = (int)(Vitality * 2 + Strenght);
            _maxManaFormula = (int)(Intelligence);
            _pDamageFormula = (int)(Strenght);
            _mDamageFormula = (int)(Intelligence * 0.2);
            _armorFormula = (int)(Dexterity);
            _mDefenseFormula = (int)(Intelligence * 0.5);
            _critChanceFormula = (int)(Dexterity * 0.05);
            _critDamageFormula = (int)(Dexterity * 0.1);
        }
    }
}
