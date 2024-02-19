using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Nameable
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public Nameable()
        {
            Name = ToString().Split('.')[1];
        }

        public Nameable(string name)
        {
            Name = name;
        }
    }
}
