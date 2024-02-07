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
            Damage = (int)(0.5 / strength);


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
