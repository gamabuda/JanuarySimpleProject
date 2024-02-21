using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Barrack
    {
        public Unit CreateUnit(string type)
        {
            switch (type)
            {
                case "warrior":
                    return new Warrior();
                case "rogue":
                    return new Rogue();
                case "wizard":
                    return new Wizard();
                default: return null;
            }
        }
    }
}
