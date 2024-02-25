using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Barrack 
    {
        public static Unit CreateUnit(string type)
        {
            switch (type)
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
                    throw new Exception("нету героя");
            }
        }
    }
}