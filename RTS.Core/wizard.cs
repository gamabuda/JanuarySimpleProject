using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Wizard : Unit
    {
        public int HealPoint { get; set; } = 10;
        public Wizard(int strength, int dexterity, int intelligence, int vitality) : base(strength, dexterity, intelligence, vitality)
        {
            Health = (int)(vitality / 1.5 + strength / 0.2);
            Mana = (int)(intelligence / 1.5);
            PDamage = (int)(strength/0.5);
            Armor = 1/ dexterity;
            MDamage = 1/ intelligence;
            MDefence = 1 / intelligence;
            CrtChance = (int)(dexterity/0.2);
            CrtDamage = (int)(dexterity/0.1);

            MaxHealth = Health;
        }

        public void Heal(Unit unit)
        {
            if (Mana < 15)
                return;

            Mana -= 15;
            unit.Health += HealPoint;
        }
    }
}
