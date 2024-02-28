using System;
using System.Text.Json;
using JanuarySimpleProject.Core.Implementation;

namespace JanuarySimpleProject.Core
{
    public class Node : INode
    {
        private DArray _values = new DArray(10);
        private string _value;

        private Node()
        {
            Id = Guid.NewGuid().ToString();

            Name = "NewNode";
            DateTimeCreate = DateTime.Now;
            DateTimeUpdate = DateTimeCreate;

            OnNodeChange += CheckNode;
            OnNodeChange += DateTimeEditChange;
            OnNodeChange += SerializeNode2Json;
        }

        public Node(string name)
        {
            Id = Guid.NewGuid().ToString();

            Name = name;
            DateTimeCreate = DateTime.Now;
            DateTimeUpdate = DateTimeCreate;

            OnNodeChange += CheckNode;
            OnNodeChange += DateTimeEditChange;
            OnNodeChange += SerializeNode2Json;
        }

        public string Id { get; }

        public string Name { get; set; }

        public string Value
        {
            get => _value;
            set
            {
                _value = value.Trim();
                _values = new DArray(10);
                _values.Add(_value);
                OnNodeChange?.Invoke();
            }
        }

        public string JSON { get; set; }

        public DateTime DateTimeCreate { get; }
        public DateTime DateTimeUpdate { get; private set; }

        public event Action OnNodeChange;

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
           var temp = string.Join("", _values = new DArray(10));
            if (_value != temp)
                throw new Exception("Node is not correct or broken");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Node:\tName:{Name} ID:{Id}\n\tDateTime create:{DateTimeCreate}\n\tDateTime last update:{DateTimeUpdate}\n\tValue:{Value}");
        }
        public void AddValue<TValue>(TValue value)
        {
            string strValue = value?.ToString().Trim() ?? throw new ArgumentNullException(nameof(value));

            if (_values.Contains(strValue))
                return;

            _values.Add(strValue);
            _value += strValue;

            OnNodeChange?.Invoke();
        }
        public string[] GetArray()
        {
            string[] result = new string[_values.Count()];
            Array.Copy(_values.GetArray(), result, _values.Count());
            return result;
        }

        public void AddValue<TValue>(List<TValue> values)
        {
            if (values.Count <= 0)
                return;

            foreach (var value in values)
            {
                string strValue = value?.ToString().Trim() ?? throw new ArgumentNullException(nameof(value));

                if (_values.Contains(strValue))
                    return;

                _values.Add(strValue);
                _value += strValue;

                OnNodeChange?.Invoke();
            }
        }

        public void RemoveValue<TValue>(TValue value)
        {
            string strValue = value?.ToString().Trim() ?? throw new ArgumentNullException(nameof(value));

            if (!_values.Contains(strValue))
                return;

            _values.Remove(strValue);
            _value = Value.Replace(strValue, "");

            OnNodeChange?.Invoke();
        }

        public void UpdateValue<TValue>(TValue value)
        {
            string strValue = value?.ToString().Trim() ?? throw new ArgumentNullException(nameof(value));

            int index = Array.IndexOf(_values.GetArray(), strValue);
            if (index >= 0)
            {
                _values.Remove(strValue);
                _values.Add(strValue);
                _value += strValue;

                OnNodeChange?.Invoke();
            }
        }

        public static Node CreateEmptyNode()
        {
            return new Node();
        }
    }
}

