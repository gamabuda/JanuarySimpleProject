namespace RTS.Core
{
    public class Wizard : Unit
    {
        public int HealPoint { get; set; }
        public int FireballDamage { get; set; }
        public Wizard()
        {
            MinStrength = 15;
            MinDexterity = 20;
            MinIntelligence = 35;
            MinVitality = 15;
            MaxStrength = 45;
            MaxDexterity = 80;
            MaxIntelligence = 250;
            MaxVitality = 70;

            Health = (int)(Vitality / 1.5 + MinStrength / 0.5);
            Mana = (int)(MinIntelligence / 1.5);
            PDamage = (int)(0.5 / MinStrength);
            HealPoint = 10;
            MDamage = (int)(Intelligence / 1);
            MDefense = (int)(Intelligence / 1);

            MaxHealth = Health;
            MaxMana = Mana;
            Armor = (int)(Dexterity / 1);

            CrtChance = (int)(Dexterity / 0.2);
            CrtDamage = (int)(Dexterity / 0.1);
            FireballDamage = (int)(Intelligence / 2) + MDamage;
        }

        public void Heal(Unit target)
        {
            if (Mana < 15)
                return;
            else
            {
                Mana -= 15;
                target.Health += HealPoint;
            }
        }


        public void Fireball(Unit target)
        {

        }



    }
}
