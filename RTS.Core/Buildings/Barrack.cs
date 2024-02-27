using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTS.Core.Interfaces;
using RTS.Core.Units;

namespace RTS.Core.Buildings
{
    public class Barrack : IBuilding
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }

        public static Unit CreateUnit(string type)
        {
            switch (type.ToLower().Trim())
            {
                case "warrior":
                    return new Warrior();
                    break;
                case "rogue":
                    return new Rogue();
                    break;
                case "wizard":
                    return new Wizard();
                    break;
                default:
                    throw new Exception("This unit doesn`t exist");
            }
        }
    }
}
