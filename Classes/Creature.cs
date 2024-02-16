﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Creature
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; protected set; }

        public Creature()
        {
            Name = ToString().Split('.')[1];
        }

        public Creature(string name)
        {
            Name = name;
        }
    }
}
