using System.Xml.Linq;

namespace RTS.Core
{
    public class Unit
    {
        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }
        public int Armor { get; set; }

        public int HP { get; set; }
        public int Mana { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }

        public int Vitality { get; set; }
        public int Strength { get; set; }
        public int Inteligence { get; set; }
        public int Dexterity { get; set; }

        public int Damage { get; set; }
        public int MagicalDamage { get; set; }
        public int MagicalDefense { get; set; }
        public int CriticalChanse { get; set; }
        public int CriticalDamage { get; set; }


        public void ShowInfo()
        {
            Console.WriteLine($"Health: {HP}\nMana: {Mana}\nStrength: {Strength}\nDexterity: {Dexterity}\nVitality: {Vitality}");
        }

        public void DealDamage(Unit target)
        {
            if(target.HP - this.Damage < 1)
            {
                target.HP = 0;
                return;
            }

            target.HP -= this.Damage;
        }

        public void LevelUp(Unit target)
        {
            if(target.Level < 50)
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