using RTS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Barracks : Unit
    {
        public Barracks(string unitType, int strength, int dexterity, int intelligence, int vitality) : base(strength, dexterity, intelligence, vitality)
        {
            Unit unit = null;

            switch (unitType)
            {
                case "Wizzard":
                    unit = new Wizard(15, 20, 35, 15);
                    break;
                case "Warrior":
                    unit = new Warrior(30, 15, 10, 25);
                    break;
                case "Rogue":
                    unit = new Rogue(20, 30, 15, 20);
                    break;
                default:
                    throw new ArgumentException("Unknown unit type");
            }
            return;
        }
    }
}