using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Barrack : Creature
    {
        public Unit RecruitUnit(string UnitName)
        {
            switch(UnitName)
            {
                case "Warrior": return new Warrior();
                case "Rogue": return new Rogue();
                case "Wizard": return new Wizard();
                default: throw new Exception("Нет такого класса");
            }
        }
    }
}
