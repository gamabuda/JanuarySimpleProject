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
        public MoiaNode()
        {
            Id = Guid.NewGuid().ToString();

            Name = "MoiaNode";
            DateTimeCreate = DateTime.Now;
            DateTimeUpdate = DateTimeCreate;

            OnNodeChange += miay;
            OnNodeChange.Invoke();
        }
        private string _value;
        private DinamicArray<string> _values = new DinamicArray<string>();
        public string Id { get; }
        public string Name { get; set; }
        public string Value { get; set; }
        public DateTime DateTimeCreate { get; }
        public DateTime DateTimeUpdate { get; }
        public event Action OnNodeChange;

        private void miay()
        {
            Console.WriteLine("miay miay miay");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Node:\tName:{Name} ID:{Id}\n\tDateTime create:{DateTimeCreate}\n\tDateTime last update:{DateTimeUpdate}\n\tValue:{Value}");
        }
        public void AddValue<TValue>(TValue value)
        {
            string strValue = value.ToString().Trim();
            _values.Add(strValue);
            _value += $"{strValue}";
            OnNodeChange?.Invoke();
        }
        public void RemoveValue<TValue>(TValue value)
        {
            string strValue = value.ToString().Trim();
            _values.Remove(strValue);
            _value = Value.Replace(strValue, "");

            OnNodeChange?.Invoke();
        }     
    }
}
