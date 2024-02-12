using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS
{
    public interface IUnit
    {
        // HP and MP
        public int Health { get; set; }
        public int Mana { get; set; }
        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }

        //Armor
        public int Armor { get; set; }
        public int MDefense { get; set; }

        public void ShowInfo();
    }
}
