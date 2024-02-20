namespace RTS.Core
{
    public class Unit
    {
        public int OldXP { get; set; } = 0;
        int NewXp { get; set; } = 1000;
        int NextXp { get; set; }

        public int Level { get; set; } = 1;
        public double MaxHealth { get; set; }
        public double MaxMana { get; set; }
        public double Armor { get; set; }

        public double HP { get; set; }
        public double Mana { get; set; }

        public double Vitality { get; set; }
        public double Strength { get; set; }
        public double Inteligence { get; set; }
        public double Dexterity { get; set; }

        public double Damage { get; set; }
        public double MagicalDamage { get; set; }
        public double MagicalDefense { get; set; }
        public double CriticalChanse { get; set; }
        public double CriticalDamage { get; set; }

        public void Attack(Unit u)
        {
            if (u.HP - u.Damage < 1)
            {
                u.HP = 0;
                return;
            }
            u.HP -= u.Damage;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Health: {HP}\nMana: {Mana}\nStrength: {Strength}\nDexterity: {Dexterity}\nVitality: {Vitality}\nLevel: {Level}\nXP: {OldXP}" );
        }
        public void LevelUp()
        {

            if (Level == Level++)
            {

                OldXP += NewXp;
            }
            
            NewXp += 1000;
        }
    }

}
