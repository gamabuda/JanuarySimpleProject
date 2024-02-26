using System.ComponentModel;
using System.Runtime.InteropServices;

namespace RTSClasses
{
    public class Hero : Unit, IHealthHandler, IManaHandler, IAttackHandler, IArmorHandler
    {
        public int PhysicalDamage { get; set; }
        public int Armor { get; set; }
        public int CriticalChance { get; set; }
        public int CriticalDamage { get; set; }
        public int MagicalDamage { get; set; }
        public int MagicDefense { get; set; }
        public int Mana { get; set; }

        public int Level { get => _level; set { _level = value; } }
        public long Experience { get => _exp; set { _exp = value; calculateLevel(); } }
        public int ExpToNextLvl { get; set; } = 1000;
        public int SkillPoints { get; set; } = 5;
        public int MaxLevel { get; set; } = 50;

        protected long _exp;
        protected int _level = 1;
        protected int _str;
        protected int _dex;
        protected int _int;
        protected int _vit;

        public int Strenght { get => _str; set { _str = value; onStatChange?.Invoke(); UpdateStats(); } }
        public int Dexterity { get => _dex; set { _dex = value; onStatChange?.Invoke(); UpdateStats(); } }
        public int Intelligence { get => _int; set { _int = value; onStatChange?.Invoke(); UpdateStats(); } }
        public int Vitality { get => _vit; set { _vit = value; onStatChange?.Invoke(); UpdateStats(); } }

        public int MaxStrenght { get; set; }
        public int MaxDexterity { get; set; }
        public int MaxIntelligence { get; set; }
        public int MaxVitality { get; set; }

        public int MaxMana { get; set; }

        public event Action ?onStatChange;

        public void Attack(IArmorHandler armorHandler)
        {
            Random random = new Random();
            int damage = PhysicalDamage - random.Next(armorHandler.Armor / 2, armorHandler.Armor);

            if (damage <= 0)
                damage = 1;

            if (armorHandler.Health <= damage)
            {
                armorHandler.Health = 0;
                return;
            }

            armorHandler.Health -= damage;
        }

        protected void calculateLevel()
        {
            int temp = 0;
            int templvl = 0;
            for (int i = 1; Experience >= temp && i < MaxLevel + 1; i++)
            {
                temp += i * 1000;
                templvl = i;
            }

            if (templvl != Level)
            {
                SkillPoints += (templvl - Level);
                Level = templvl;
            }

            ExpToNextLvl = temp;
        }

        protected virtual void UpdateStats() { }
    }
}