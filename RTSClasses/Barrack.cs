
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSClasses
{
    public class Barrack : Nameable
    {
        public Unit RecruitUnit(string UnitName)
        {
            switch (UnitName)
            {
                case "Warrior": return new Warrior();
                case "Rogue": return new Rogue();
                case "Wizard": return new Wizard();
                default: throw new Exception("Нет такого класса");
            }
        }
    }
}