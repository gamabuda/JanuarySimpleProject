using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Wizard : Unit
    {
        public int HealPoint { get; set; }
        public Wizard(int strength, int dexterity, int intelligence, int vitality) : base(strength, dexterity, intelligence, vitality)
        {
            Health = (int)(vitality * 1.4 + Strength * 0.2);
            Mana = (int)(1.5 * intelligence);
            PDamage = (int)(0.5 * strength);
            Armor = 1 * dexterity;
            MDamage = (int)(1 * intelligence);
            MDefense = (int)(1 * intelligence);
            CrtChance = (int)(0.2 * dexterity);
            CrtDamage = (int)(0.1 * dexterity);
            HealPoint = 10;
        }

        public void Heal(Unit unit)
        {
            if (unit.Health == unit.MaxHealth)
                return;

            if (Mana < 10)
                return;
            
            if (unit is Wizard)
                unit.Health += HealPoint * 2;
            else if (unit is Rogue)
                unit.Health += HealPoint / 2;
            else
                unit.Health += HealPoint;

            Mana -= HealPoint;
        }
    }
}
