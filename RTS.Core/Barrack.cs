using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.Buildings
{
    public class Barrack
    {
        public int hp { get; set; }

        public static Unit CreateUnit(string type)
        {
            switch (type.ToLower())
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
            }

            return null;
        }
    }
}
