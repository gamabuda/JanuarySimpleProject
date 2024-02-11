using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Lib
{
    public class Church : Unit
    {
        public int RegenMana { get; set; } = 15;
        public Church(int strength, int dexterity, int intelligence, int vitality) : base(strength, dexterity, intelligence, vitality)
        {
            this.Strength = strength;
            this.Dexterity = dexterity;
            this.Intelligence = intelligence;
            this.Vitality = vitality;
            this.MaxHealth = this.Health;
            this.MaxMana = this.Mana;
        }

        public void Pray(Unit unit)
        {
            if (unit.Mana == unit.MaxMana)
                return;
            if (Health < 15)
                return;
            if (unit is Wizard)
                unit.Mana += RegenMana * 2;
            else if (unit is Rogue)
                unit.Mana += RegenMana / 2;
            else
                unit.Mana += RegenMana;

            Health -= RegenMana;
        }
    }
}
