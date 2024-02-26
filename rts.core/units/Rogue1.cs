using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rts.core.units
{
    public class Rogue : Unit
    {
        public Rogue()
        {
            Strenght = 20;
            Dexterity = 30;
            Intelligence = 15;
            Vitality = 20;

            Health = (int)(Vitality * 1.5 + Strenght * 0.5);
            MaxHealth = Health;
            Mana = (int)(Intelligence * 1.2);
            MaxMana = Mana;
            PDamage = (int)(0.5 * Strenght + 0.5 * Dexterity);
            MDefense = (int)(Strenght * 0.5);
            MDamage = (int)(Intelligence * 0.2);
            CrtChanse = (int)(Dexterity * 0.2);
            CrtDamage = (int)(Dexterity * 0.1);
        }
    }
}
