using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JanuarySimpleProject.Core.Implementation
{
    public class MyNode : Node
    {
        DArray array = new DArray(1);
        public MyNode(string name) : base(name)
        {
        }

        public void AddValues<TValue>(params TValue[] values)
        {
            foreach (var value in values)
            {
                AddValue(value);
            }
        }

        public void ShowValues()
        {
            Console.WriteLine("Values in MyNode:");
            foreach (var value in array.GetArray())
            {
                Console.WriteLine(value);
            }
        }

        public bool ContainsValue(string value) { 
            return array.Contains(value);
        }

        public void RemoveValues<TValue>(params TValue[] values)
        {
            foreach (var value in values)
            {
                RemoveValue(value);
            }
        }

        public void UpdateValues<TValue>(params TValue[] values)
        {
            foreach (var value in values)
            {
                UpdateValue(value);
            }
        }

    }
}
