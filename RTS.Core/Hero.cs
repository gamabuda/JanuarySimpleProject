using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Hero : Unit, IAttackHandler, IManaHandler, IArmorHandler
    {
        public int Strength { get => _str; set { _str = value; UpdateStats(); } }
        public int MaxStrength { get; set; }
        public int Dexterity { get => _dex; set { _dex = value; UpdateStats(); } }
        public int MaxDexterity { get; set; }
        public int Intelligence { get => _int; set { _int = value; UpdateStats(); } }
        public int MaxIntelligence { get; set; }
        public int Vitality { get => _vit ; set { _vit = value; UpdateStats(); } }
        public int MaxVitality { get; set; }

        private int _str;
        private int _dex;
        private int _int;
        private int _vit;
        private int _exp;

        public int PDamage { get; set; }
        public int CriticalDamage { get; set; }
        public int CriticalChance { get; set; }
        public int Mana { get; set; }
        public int MaxMana { get; set; }
        public int Armor { get; set; }
        public int MDamage { get; set; }
        public int MDefense { get; set; }

        public int Level { get; set; } = 1;
        public int Exp { get => _exp; set { _exp = value; UpdateLevel(); } }

        public void Attack(IHealthHandler unit)
        {
            if (unit.Health < PDamage)
            {
                unit.Health = 0;
                return;
            }

            unit.Health -= PDamage;
        }

        public void Attack(IArmorHandler unit)
        {
            int damage = (int)(PDamage - unit.Armor * 0.8);
            if (damage < 0) damage = 1;
            if (unit.Health < damage)
            {
                unit.Health = 0;
                return;
            }

            unit.Health -= damage;
        }

        public void UpdateLevel()
        {
            int nextLevel = Level + 1;
            int requiredExperience = 1000 * nextLevel * (nextLevel - 1) / 2;
            while (Exp >= requiredExperience)
            {
                Level++;
                requiredExperience = 1000 * nextLevel * (nextLevel - 1) / 2;
            }
        }

        public virtual void UpdateStats() { }
    }
}
