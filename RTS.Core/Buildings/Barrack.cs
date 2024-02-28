using RTS.Core.Interfaces;
using RTS.Core.Units;
using System;
using System.Threading;

namespace RTS.Core.Buildings
{
    public class Barrack : IHealthHandler
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

