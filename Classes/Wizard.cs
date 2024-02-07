//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Classes
//{
//    public class Wizard : Unit
//    {
//        BaseStrenght = 15;
//        BaseDexterity = 20;
//        BaseIntelligence = 35;
//        BaseVitality = 15;

//        MaxStrenght = 45;
//        MaxDexterity = 80;
//        MaxIntelligence = 250;
//        MaxVitality = 70;

//        public int HealPoint { get; set; } = 10;

//        public Wizard(int strenght, int dexterity, int intelligence, int vitality) : base(strenght, dexterity, intelligence, vitality)
//        {
//            Health = (int)(Vitality * 1.4 + 0.2 * Strenght);
//            Mana = (int)(Intelligence * 1.5);
//        }

//        public void Heal(Unit unit)
//        {
//            if (Mana < 15)
//                return;
            
//            unit.Health += HealPoint;
//            Mana -= 15;            
//        }
//    }
//}
