using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS
{
    public class Bilding : IHealthHandler, IArmorHandler, IInfoHandler
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }

        //Armor
        public int Armor { get; set; }
        public int MDefense { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"HP:{Health}/{MaxHealth}\nArmor:{Armor}\nMDefense{MDefense}");
        }
    }
}
