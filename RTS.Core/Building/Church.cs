using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RTS.Core.Characters;

namespace RTS.Core.Building
{
    public class Church
    {
        public void Pray(Unit unit)
        {
            if (unit is Wizard)
            {
                Wizard wizard = (Wizard)unit;
                wizard.Mana *= 2;
                Console.WriteLine($"Wizard prayed in the Church. Mana: {wizard.Mana}");
            }
            else if (unit is Rogue)
            {
                Rogue rogue = (Rogue)unit;
                rogue.Mana /= 2;
                Console.WriteLine($"Rogue prayed in the Church. Mana: {rogue.Mana}");
            }
            else if (unit is Warrior)
            {
                Warrior warrior = (Warrior)unit;
                warrior.Mana *= 1;
                Console.WriteLine($"Warrior prayed in the Church. Mana: {warrior.Mana}");
            }
        }
    }
}