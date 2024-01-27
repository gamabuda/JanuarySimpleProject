using System;
using System.Text.Json;
using System.Collections.Generic;
using JanuarySimpleProject.Core.Implementation;

namespace JanuarySimpleProject.Core
{
    public class Node : INode
    {
        private List<string> _values = new List<string>(); // Изменено на список

        private string _value;
        public string Id { get; }
        public string Name { get; set; }
        public string Value
        {
            get => _value;
            set
            {
                _value = value.Trim();
                _values.Clear();
                _values.Add(_value);
                OnNodeChange?.Invoke();
            }
        }
        public string JSON { get; set; }
        public DateTime DateTimeCreate { get; }
        public DateTime DateTimeUpdate { get; private set; }

        public event Action OnNodeChange;

        public Node()
        {
            Id = Guid.NewGuid().ToString();
            Name = "NewNode";
            Value = string.Empty;
            DateTimeCreate = DateTime.Now;
            DateTimeUpdate = DateTimeCreate;
            OnNodeChange += CheckNode;
            OnNodeChange += DateTimeEditChange;
            OnNodeChange += SerializeNode2Json;
        }

        private void SerializeNode2Json()
        {
            JSON = JsonSerializer.Serialize(this);
        }

        private void DateTimeEditChange()
        {
            DateTimeUpdate = DateTime.Now;
        }

        private void CheckNode()
        {
            var temp = String.Empty;
            foreach (var v in _values)
                temp += v;

            if (_value != temp)
                throw new Exception("Node is not correct or broken");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Node:\tName:{Name} ID:{Id}\n\tDateTime create:{DateTimeCreate}\n\tDateTime last update:{DateTimeUpdate}\n\tValue:{Value}");
        }

        public void AddValue<TValue>(TValue value)
        {
            string strValue = value.ToString().Trim();

            if (strValue == null)
                throw new Exception("Value cannot be null");

            if (_values.Contains(strValue))
                throw new Exception("Value already exists");

            _values.Add(strValue);
            _value += $"{strValue}";

            OnNodeChange?.Invoke();
        }

        public void AddValue<TValue>(List<TValue> values)
        {
            if (values.Count <= 0)
                throw new Exception("List of values is empty");

            foreach (var value in values)
            {
                string strValue = value.ToString().Trim();

                if (strValue == null)
                    throw new Exception("Value cannot be null");

                if (_values.Contains(strValue))
                    throw new Exception("Value already exists");

                _values.Add(strValue);
                _value += $"{strValue}";

                OnNodeChange?.Invoke();
            }
        }
    }
}



