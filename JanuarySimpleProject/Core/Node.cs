using System;
using System.Text.Json;
using System.Text.RegularExpressions;
using JanuarySimpleProject.Core.Implementation;

namespace JanuarySimpleProject.Core
{
    public class Node : INode
    {
        //TODO switch list to array
        private DynamicArray<string> _values = new DynamicArray<string>(0);
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
                _values.Clear();
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
            for (var i = 0; i < _values.Count(); i++)
            {
                temp += _values.GetArray()[i];
            }
                
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
                throw new Exception("The value is null");

            if (_values.Contains(strValue))
                throw new Exception("The value is already contained in the Node");

            _values.Add(strValue);
            _value += $"{strValue}";

            OnNodeChange?.Invoke();
        }

        //TODO switch all returns to throw Exception
        public void AddValue<TValue>(List<TValue> values)
        {
            if (values.Count <= 0)
                throw new Exception("The list is empty");

            foreach (var value in values)
            {
                string strValue = value.ToString().Trim();

                if (strValue == null)
                    throw new Exception("The value is null");

                if (_values.Contains(strValue))
                    throw new Exception("The value is already contained in the Node");

                _values.Add(strValue);
                _value += $"{strValue}";

                OnNodeChange?.Invoke();
            }
        }

        //TODO switch all returns to throw Exception and add the ability to delete a list of objects
        public void RemoveValue<TValue>(TValue value)
        {
            string strValue = value.ToString().Trim();

            if (strValue == null)
                throw new Exception("The value is null");

            if (!_values.Contains(strValue))
                throw new Exception("The value is not contained in the node");

            _values.Remove(strValue);
            _value = Value.Replace(strValue, "");

            OnNodeChange?.Invoke();
        }

        public void RemoveValue<TValue>(List<TValue> values)
        {
            if (values.Count <= 0)
                throw new Exception("The list is empty");

            foreach (var value in values)
            {
                string strValue = value.ToString().Trim();

                if (strValue == null)
                    throw new Exception("The value is null");

                if (!_values.Contains(strValue))
                    throw new Exception("The value is not contained in the Node");

                _values.Remove(strValue);
                _value = Value.Replace(strValue, "");

                OnNodeChange?.Invoke();
            }
        }

        public string UpdateValue(string value)
        {
            string oldValue = _value;
            _value = value;
            return oldValue;
        }

        public static Node CreateEmptyNode()
        {
            return new Node();
        }
    }
}

