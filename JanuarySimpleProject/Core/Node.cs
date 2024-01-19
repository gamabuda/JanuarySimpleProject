using System;
using System.Text.Json;
using JanuarySimpleProject.Core.Implementation;

namespace JanuarySimpleProject.Core
{
    public class Node : INode
    {
        //TODO switch list to array
        DynamicArray<string> _values = new DynamicArray<string>(100);
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
                //TODO need optimize
                _values = new DynamicArray<string>(100);
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

        //TODO switch all returns to throw Exception
        public void AddValue<TValue>(TValue value)
        {
            string strValue = value.ToString().Trim();

            if (strValue == null)
                throw new Exception("An empty line has been entered");

            if (_values.Contains(strValue))
                throw new Exception("Such a record is already available");

            _values.Add(strValue);
            _value += $"{strValue}";

            OnNodeChange?.Invoke();
        }

        //TODO switch all returns to throw Exception
        public void AddValue<TValue>(List<TValue> values)
        {
            if (values.Count <= 0)
                throw new Exception("An empty list has been entered");

            foreach (var value in values)
            {
                string strValue = value.ToString().Trim();

                if (strValue == null)
                    throw new Exception("An empty line has been entered");

                if (_values.Contains(strValue))
                    throw new Exception("Such a record is already available");

                _values.Add(strValue);
                _value += $"{strValue}";

                OnNodeChange?.Invoke();
            }
        }

        //TODO switch all returns to throw Exception and add the ability to delete a list of objects
        public void RemoveValue<TValue>(TValue value)
        {
            string strValue = value?.ToString()?.Trim();

            if (string.IsNullOrEmpty(strValue))
                throw new ArgumentException("An empty or null value has been entered");

            if (!_values.Contains(strValue))
                throw new ArgumentException("There is no such value");

            _values.Remove(strValue);
            _value = string.Empty;  
            foreach(var v in _values)
            {
                _value += v;
            }
            OnNodeChange?.Invoke();
        }

        public void RemoveValues<TValue>(List<TValue> values)
        {
            if (values == null || values.Count == 0)
                throw new ArgumentException("An empty or null list has been entered");

            foreach (var value in values)
            {
                string strValue = value?.ToString()?.Trim();

                if (string.IsNullOrEmpty(strValue))
                    throw new ArgumentException("An empty or null value has been entered");

                if (!_values.Contains(strValue))
                    throw new ArgumentException("There is no such value in the list");

                _values.Remove(strValue);
            }

            _value = string.Empty;
            foreach (var v in _values)
            {
                _value += v;
            }
            OnNodeChange?.Invoke();
        }

        public TValue UpdateValue<TValue>(TValue oldValue, TValue newValue)
        {
            string strOldValue = oldValue.ToString().Trim();
            string strNewValue = newValue.ToString().Trim();

            if (!_values.Contains(strOldValue))
                throw new Exception("Old value not found");

            if (strNewValue == null)
                throw new ArgumentNullException("New value cannot be null");

            if (_values.Contains(strNewValue))
                throw new Exception("New value already exists");

            _values.Replace(strOldValue, strNewValue);

            _value = string.Empty;
            foreach (var v in _values)
            {
                _value += v;
            }

            OnNodeChange?.Invoke();

            return oldValue;
        }


        public static Node CreateEmptyNode()
        {
            return new Node();
        }
    }
}

