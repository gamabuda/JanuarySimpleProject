using System;
using System.Text.Json;
using JanuarySimpleProject.Core.Implementation;

namespace JanuarySimpleProject.Core
{
    public class Node : INode
    {
        //TODO switch list to array
        private string[] _values = new string[0];
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
                _values = new string[] { _value };
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
            string strValue = value?.ToString().Trim() ?? throw new ArgumentNullException(nameof(value));


            if (_values.Contains(strValue))
                throw new Exception("Value already exists");


            Array.Resize(ref _values, _values.Length + 1);
            _values[_values.Length - 1] = strValue;
            _value += $"{strValue}";

            OnNodeChange?.Invoke();
        }

        //TODO switch all returns to throw Exception
        public void AddValue<TValue>(List<TValue> values)
        {
            if (values.Count <= 0)
                throw new Exception("List of valuew isempty");

            foreach (var value in values)
            {
                string strValue = value?.ToString().Trim() ?? throw new ArgumentNullException(nameof(value));

                if (_values.Contains(strValue));
                throw new Exception("Value already exists");


                Array.Resize(ref _values, _values.Length + 1);
                _values[_values.Length - 1] = strValue;
                _value += $"{strValue}";

                OnNodeChange?.Invoke();
            }
        }

        //TODO switch all returns to throw Exception and add the ability to delete a list of objects
        public void RemoveValue<TValue>(TValue value)
        {
            string strValue = value.ToString().Trim();

            if (strValue == null)
                throw new ArgumentException("Value cannot be null");

            int index = Array.IndexOf(_values, strValue);
            if (index < 0)
                throw new Exception("Value does not exist");

            for (int i = index + 1; i < _values.Length; i++)
            {
                _values[i - 1] = _values[i];
            }
            Array.Resize(ref _values, _values.Length - 1);
            _value = Value.Replace(strValue, "");

            OnNodeChange?.Invoke();
        }

        public static Node CreateEmptyNode()
        {
            return new Node();
        }

        public void UpdateValue<TValue>(TValue value)
        {
            throw new NotImplementedException();
        }
    }
}

