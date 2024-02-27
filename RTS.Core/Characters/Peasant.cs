using RTS.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.Characters
{
    public class Peasant : Unit
    {
        public Peasant()
        {
            Image = ".\\RTS.WPF\\images\\peasant.jpg";
            Name = "Peasant";
            Strength = 1;
            Dexterity = 1;
            Intelligence = 1;
            Vitality = 1;
            MaxStrength = 1;
            MaxDexterity = 1;
            MaxIntelegence = 1;
            MaxVitality = 1;

            Health = 100;

            MaxHealth = Health;
        }
    }
}
