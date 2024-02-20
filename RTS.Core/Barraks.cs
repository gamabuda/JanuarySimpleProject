using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core
{
    public class Barracks
    {
        public void CreateNewPerson(string s)
        {
            switch (s)
            {
                case "Warrior":
                    new Warrior();
                    break;

                case "Rogue":
                    new Rogue();
                    break;

                case "Wizzard":
                    new Wizzard();
                    break;

                default:
                    Console.WriteLine("You not choose a unit!");
                    break;

            }
        }
    }
}
