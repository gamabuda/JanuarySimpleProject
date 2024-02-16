using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Lib
{
    public class Barrack
    {
        public Barrack(string unitType)
        {
            Unit unit = null;

            switch (unitType)
            {
                case "Wizzard":
                    unit = new Wizard();
                    break;
                case "Warrior":
                    unit = new Warrior();
                    break;
                case "Rogue":
                    unit = new Rogue();
                    break;
                default:
                    throw new ArgumentException("Некорректное значение");
            }
            return;
        }
    }
}
