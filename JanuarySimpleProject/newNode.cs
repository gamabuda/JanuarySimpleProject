using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using JanuarySimpleProject.Core.Implementation;

namespace JanuarySimpleProject.Core
{

    public class NewNode : INode
    {

        DArray<string> _values = new DArray<string>(0);
        private string _value;

        private NewNode()
        {
            Id = Guid.NewGuid().ToString();

            Name = "NewNode";
            DateTimeCreate = DateTime.Now;
            DateTimeUpdate = DateTimeCreate;

            OnNodeChange += CheckNode;
            OnNodeChange += DateTimeEditChange;
            OnNodeChange += SerializeNode2Json;
        }

        public NewNode(string name)
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
        public void AddValue<TValue>(TValue value)
        {
            string strValue = value.ToString().Trim();

            if (strValue == null)
                throw new Exception("ноль");

            if (_values.Contains(strValue))
                throw new Exception("уже есть такое значение");

            _values.Add(strValue);
            _value += $"{strValue}";

            OnNodeChange?.Invoke();
        }
        public void AddValue<TValue>(List<TValue> values)
        {
            if (values.Count <= 0)
                throw new Exception("массив пустой");

            foreach (var value in values)
            {
                string strValue = value.ToString().Trim();

                if (strValue == null)
                    throw new Exception("ноль");

                if (_values.Contains(strValue))
                    throw new Exception("уже есть такое значение");

                _values.Add(strValue);
                _value += $"{strValue}";

                OnNodeChange?.Invoke();
            }
        }
        public void RemoveValue<TValue>(TValue value)
        {
            string strValue = value.ToString().Trim();

            if (strValue == null)
                throw new Exception("ноль");

            if (!_values.Contains(strValue))
                throw new Exception("уже есть такое значение");

            _values.Remove(strValue);
            _value = Value.Replace(strValue, "");

            OnNodeChange?.Invoke();
        }
        public void RemoveValue<TValue>(List<TValue> values)
        {
            if (values.Count <= 0)
                throw new Exception("массив пустой");

            foreach (var value in values)
            {
                string strValue = value.ToString().Trim();

                if (strValue == null)
                    throw new Exception("ноль");

                if (_values.Contains(strValue))
                    throw new Exception("уже есть такое значение");

                _values.Remove(strValue);
                _value = Value.Replace(strValue, "");

                OnNodeChange?.Invoke();
            }
        }
        public string UpdateValue(string strValue)
        {
            string oldValue = _value;
            _value = strValue;
            return oldValue;
        }
        public int GetIndex(string value)
        {
            for (int i = 0; i < _values.Count(); i++)
            {
                if (_values.GetArray()[i] == value)
                {
                    return i;
                }
            }

            throw new Exception("значение не найдено");
        }

        public static NewNode CreateEmptyNode()
        {
            return new NewNode();
        }

    }
}