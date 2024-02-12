using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS
{
    public class Bilding : IUnit
    {
        public int Health { get; set; }
        public int Mana { get; set; }
        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }

        //Armor
        public int Armor { get; set; }
        public int MDefense { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"HP:{Health}/{MaxHealth}\nMP:{Mana}/{MaxMana}\nArmor:{Armor}\nMDefense{MDefense}");
        }
    }
}
