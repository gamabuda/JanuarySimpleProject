using RTS.Core.Interfaces;
using RTS.Core.Сharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.Buildings
{
    public class Barracks : IHPHandler
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }

        public Unit CreateUnit(string unitType)
        {
            switch (unitType)
            {
                case "Wizard":
                    return new Wizard();
                case "Warrior":
                    return new Warrior();
                case "Rogue":
                    return new Rogue();
                default:
                    throw new ArgumentException("Unknown unit type");
            }
        }
    }
}