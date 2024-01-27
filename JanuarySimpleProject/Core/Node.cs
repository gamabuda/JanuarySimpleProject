﻿using System.Text.Json;
using JanuarySimpleProject.Core.Implementation;

namespace JanuarySimpleProject.Core
{
    public class Node : INode
    {
        //TODO switch list to arrayЗАКРЫТО
        private string[] _values = Array.Empty<string>();
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
                //ОПТИМИЗАЦИЯ ЗАКРЫТА
                _value = value?.Trim() ?? string.Empty;
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

        //TODO switch all returns to throw ExceptionЗАКРЫТО
        public void AddValue<TValue>(TValue value)
        {
            string strValue = value.ToString().Trim();

            if (string.IsNullOrEmpty(strValue))
                throw new ArgumentException("Value is null or empty.");

            if (_values.Contains(strValue))
                throw new ArgumentException("Value already exists in the list.");

            _values = new string[] { strValue };
            _value += strValue;

            OnNodeChange?.Invoke();
        }

        //TODO switch all returns to throw Exception ЗАКРЫТО
        public void AddValue<TValue>(List<TValue> values)
        {
            if (values.Count <= 0)
                throw new ArgumentException("List is empty.");

            foreach (var value in values)
            {
                string strValue = value?.ToString().Trim();

                if (string.IsNullOrEmpty(strValue))
                    throw new ArgumentException("Value is null or empty.");

                if (_values.Contains(strValue))
                    throw new ArgumentException("Value already exists in the list.");

                _values = new string[] { strValue };
                _value += strValue;

                OnNodeChange?.Invoke();
            }
        }

        //TODO switch all returns to throw Exception and add the ability to delete a list of objects
        public void RemoveValue<TValue>(TValue value)
        {
            string strValue = value?.ToString().Trim();

            if (string.IsNullOrEmpty(strValue))
                throw new ArgumentException("Value is null or empty.");

            if (!_values.Contains(strValue))
                throw new ArgumentException("Value does not exist in the list.");

            _values = Array.FindAll(_values, v => v != strValue);
            _value = Value.Replace(strValue, "");

            OnNodeChange?.Invoke();
        }
        public void UpdateValue<TValue>(TValue value)
        {
            string strValue = value?.ToString().Trim();

            if (string.IsNullOrEmpty(strValue))
                throw new ArgumentException("Value is null or empty.");

            _value = strValue;

            OnNodeChange?.Invoke();
        }

        public static Node CreateEmptyNode()
        {
            return new Node();
        }
    }
}

