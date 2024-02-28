using RTS.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Bildings
{
    public class Barracks : Bilding
    {
        public static Unit CreateNewUnit(string name)
        {
            switch (name)
            {
                case "Warrior":
                    return new Warrior();
                case "Wizard":
                    return new Wizard();
                case "Rogue":
                    return new Rogue();
                case "Peasant":
                    return new Peasant();
                default:
                    throw new Exception("This unit doesn`t exist");
            }
        }
    }
}
