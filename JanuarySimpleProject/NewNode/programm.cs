using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.NewNode
{
    class Programm
    {
        static void Main(string[] args)
        {
            MyNode node = new MyNode("MyNode");
            node.Value = "123";
            node.ShowInfo();

            node.AddValue("456");
            node.ShowInfo();

            node.UpdateValue("123", "789");
            node.ShowInfo();

            node.RemoveValue("789");
            node.ShowInfo();

            Console.ReadLine();
        }
    }
}
