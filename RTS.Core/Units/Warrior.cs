namespace RTS.Core
{
    public class Warrior : Unit
    {
        public Warrior()
        {
            MinStrength = 30;
            MinDexterity = 15;
            MinIntelligence = 10;
            MinVitality = 25;
            MaxStrength = 250;
            MaxDexterity = 80;
            MaxIntelligence = 50;
            MaxVitality = 100;

            Health = (int)(Vitality / 2 + MinStrength);
            Mana = (int)(MinIntelligence);
            PDamage = (int)(MinStrength / 1);
            MDamage = (int)(Intelligence / 0.2);
            MDefense = (int)(Intelligence / 0.5);

            MaxHealth = Health;
            MaxMana = Mana;
            Armor = (int)(MinDexterity / 1);

            CrtChance = (int)(MinDexterity / 0.2);
            CrtDamage = (int)(MinDexterity / 0.1);
        }
    }
}
