using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rts.core.units
{
    public class Wizard : Unit
    {
        public int HealPoint { get; set; }

        public Wizard()
        {
            Strenght = 15;
            Dexterity = 20;
            Intelligence = 35;
            Vitality = 15;

            Health = (int)(Vitality * 1.4 + Strenght * 0.2);
            MaxHealth = Health;
            MaxMana = (int)(Intelligence * 1.5);
            MaxMana = Mana;
            Mana = (int)(Intelligence * 1.5);
            PDamage = (int)(Strenght * 0.5);
            MDamage = (int)(1 * Intelligence);
            MDefense = (int)(1 * Intelligence);
            CrtChanse = (int)(Dexterity * 0.2);
            CrtDamage = (int)(Dexterity * 0.1);
        }

        public void Heal(Unit unit)
        {
            if (unit.Health == unit.MaxHealth)
                return;

            if (Mana < 15)
                return;
            Mana -= 15;
            units.HealPoint += HealPoint;
        }
    }
}