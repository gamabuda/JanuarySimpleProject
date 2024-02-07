using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Warrior : Unit
    {
        public Warrior(int strenght, int dexterity, int intelligence, int vitality) : base(strenght, dexterity, intelligence, vitality)
        {
            BaseStrenght = 30;
            BaseDexterity = 15;
            BaseIntelligence = 10;
            BaseVitality = 25;

            MaxStrenght = 250;
            MaxDexterity = 80;
            MaxIntelligence = 50;
            MaxVitality = 25;

            _maxHealthFormula = (int)(Vitality * 2 + Strenght);
            _maxManaFormula = (int)(Intelligence);
            _pDamageFormula = (int)(Strenght);
            _mDamageFormula = (int)(Intelligence * 0.2);
            _armorFormula = (int)(Dexterity);
            _mDefenseFormula = (int)(Intelligence * 0.5);
            _critChanceFormula = (int)(Dexterity * 0.05);
            _critDamageFormula = (int)(Dexterity * 0.1);
        }

        public void UpgradeStrenght(int strenght)
        {
            Strenght += strenght;
        }
    }
}
