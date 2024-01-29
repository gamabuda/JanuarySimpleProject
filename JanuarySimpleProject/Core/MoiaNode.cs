using JanuarySimpleProject.Core.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.Core
{
    public class MoiaNode : INode
    {
        private string _value;
        private DinamicArray<string> _values = new DinamicArray<string>();
        string Id { get; }
        string Name { get; set; }
        string Value { get; set; }
        DateTime DateTimeCreate { get; }
        DateTime DateTimeUpdate { get; }
        public event Action OnNodeChange;

        void ShowInfo()
        {
            Console.WriteLine($"Node:\tName:{Name} ID:{Id}\n\tDateTime create:{DateTimeCreate}\n\tDateTime last update:{DateTimeUpdate}\n\tValue:{Value}");
        }
        void AddValue<TValue>(TValue value)
        {
            string strValue = value.ToString().Trim();
            _values.Add(strValue);
            _value += $"{strValue}";
            OnNodeChange?.Invoke();
        }
        void RemoveValue<TValue>(TValue value)
        {
            foreach (TValue value in values)
            {
                string strValue = value.ToString().Trim();

                _values.Remove(strValue);
                _value = Value.Replace(strValue, "");

                OnNodeChange?.Invoke();
            }
        }
        

       
    }
}
