namespace RTS.Core.Units
{
    public class Rogue : Unit
    {
        public Rogue()
        {
            MinStrength = 20;
            MinDexterity = 30;
            MinIntelligence = 15;
            MinVitality = 20;
            MaxStrength = 65;
            MaxDexterity = 250;
            MaxIntelligence = 70;
            MaxVitality = 80;

            Health = (int)(Vitality / 1.5 + MinStrength / 0.5);
            Mana = (int)(MinIntelligence / 1.2);
            PDamage = (int)(Dexterity / 0.5 - MinStrength / 0.5);
            MDamage = (int)(Intelligence / 0.2);
            MDefense = (int)(Intelligence / 0.5);

            MaxHealth = Health;
            MaxMana = Mana;
            Armor = (int)(Dexterity / 1.5);

            CrtChance = (int)(Dexterity / 0.2);
            CrtDamage = (int)(Dexterity / 0.1);
        }
    }
}
