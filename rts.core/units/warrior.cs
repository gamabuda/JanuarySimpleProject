using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rts.core.units
{
    public class Warrior : Unit
    {
        public Warrior()
        {
            Strenght = 30;
            Dexterity = 15;
            Intelligence = 10;
            Vitality = 25;

            Health = (Vitality + Strenght) / 2;
            MaxHealth = Health;
            MaxMana = Mana;

            PDamage = 1 * Strenght;
            MDefense = (int)(Strenght * 0.5);
            MDamage = (int)(Intelligence * 0.2);
            CrtChanse = (int)(Dexterity * 0.2);
            CrtDamage = (int)(Dexterity * 0.1);
        }
    }
}