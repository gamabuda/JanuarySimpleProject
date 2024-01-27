using System;
using System.Text.Json;
using System.Collections.Generic;
using JanuarySimpleProject.Core.Implementation;
using System.Xml.Linq;

namespace JanuarySimpleProject.Core
{
    public class Node : INode
    {
        private string[] _values = Array.Empty<string>(); 

        private string _value;
        public string Id { get; }
        public string Name { get; }
        public DateTime DateTimeCreate { get; }
        public DateTime DateTimeUpdate { get; }
        string INode.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Node()
        {
            Id = Guid.NewGuid().ToString();
            Name = "NewNode";
            DateTimeCreate = DateTime.Now;
            DateTimeUpdate = DateTimeCreate;
            OnNodeChange += CheckNode;
            OnNodeChange += DateTimeEditChange;
            OnNodeChange += SerializeNode2Json;
        }
        public event Action OnNodeChange;

        public void CheckNode()
        {
          
        }

        public void DateTimeEditChange()
        {
           
        }

        public void SerializeNode2Json()
        {
            
        }

        public void ShowInfo()
        {
            throw new NotImplementedException();
        }

        public void AddValue<TValue>(TValue value)
        {
            throw new NotImplementedException();
        }

        public void RemoveValue<TValue>(TValue value)
        {
            throw new NotImplementedException();
        }
    }
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
                return;

            if (_values.Contains(strValue))
                return;

            _values.Add(strValue);
            _value += $"{strValue}";

            OnNodeChange?.Invoke();
        }

        //TODO switch all returns to throw Exception
        public void AddValue<TValue>(List<TValue> values)
        {
            if (values.Count <= 0)
                return;

            foreach (var value in values)
            {
                string strValue = value.ToString().Trim();

                if (strValue == null)
                    return;

                if (_values.Contains(strValue))
                    return;

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
                return;

            if (!_values.Contains(strValue))
                return;

            _values.Remove(strValue);
            _value = Value.Replace(strValue, "");

            OnNodeChange?.Invoke();
        }

        public static Node CreateEmptyNode()
        {
            return new Node();
        }
    }
}

