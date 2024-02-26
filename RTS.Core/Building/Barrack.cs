using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTS.Core.Characters;
using System.Threading;

namespace RTS.Core.Building
{
    public class Barrack
    {
        public Unit CreateCharacter(string characterType)
        {
            switch (characterType.ToLower())
            {
                case "warrior":
                    return new Warrior();
                case "rogue":
                    return new Rogue();
                case "wizard":
                    return new Wizard();
                default:
                    Console.WriteLine("Wrong character type. Warrior is selected by default.");
                    return new Warrior();
            }
        }
    }
}
