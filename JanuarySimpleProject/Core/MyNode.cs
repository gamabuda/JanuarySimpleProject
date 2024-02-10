using JanuarySimpleProject.Core.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JanuarySimpleProject.Core
{
    public class MyNode : INode
    {

        private DynamicArray<string> _values = new DynamicArray<string>();
        private string _value;

        private MyNode()
        {
            Id = Guid.NewGuid().ToString();

            Name = "NewNode";
            DateTimeCreate = DateTime.Now;
            DateTimeUpdate = DateTimeCreate;

            OnNodeChange += CheckNode;
            OnNodeChange += DateTimeEditChange;
            OnNodeChange += SerializeNode2Json;
        }

        public MyNode(string name)
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

        public void AddValue<TValue>(TValue value)
        {
            string strValue = value.ToString().Trim();

            if (strValue == null)
                throw new Exception("you cannot add a null value");

            if (_values.Contains(strValue))
                throw new Exception("this value is already in the array"); ;

            _values.Add(strValue);
            _value += $"{strValue}";

            OnNodeChange?.Invoke();
        }

        public void AddValue<TAnswer>(List<TAnswer> values)
        {
            if (values.Count <= 0)
                throw new Exception("you cannot add a list if it is empty");

            foreach (var value in values)
            {
                string strValue = value.ToString().Trim();

                if (strValue == null)
                    throw new Exception("you cannot add a null value");

                if (_values.Contains(strValue))
                    throw new Exception("the list of elements is already in the array");

                _values.Add(strValue);
                _value += $"{strValue}";

                OnNodeChange?.Invoke();
            }
        }

        public void RemoveValue<TAnswer>(TAnswer value)
        {
            string strValue = value.ToString().Trim();

            if (strValue == null)
                throw new Exception("you cannot add a null value");

            if (!_values.Contains(strValue))
                throw new Exception("there is no such value in the array");

            _values.Remove(strValue);
            _value = Value.Replace(strValue, "");

            OnNodeChange?.Invoke();
        }
        public void RemoveValue<TAnswer>(List<TAnswer> values)
        {
            if (values.Count <= 0)
                return;

            foreach (var value in values)
            {
                string strValue = value.ToString().Trim();

                if (strValue == null)
                    throw new Exception("you are trying to delete a null value");

                if (_values.Contains(strValue))
                    throw new Exception("this element is not in the array");

                _values.Remove(strValue);
                _value = Value.Replace(strValue, "");

                OnNodeChange?.Invoke();
            }
        }

        public string Update(string strValue)
        {
            string oldValue = _value;
            _value = strValue;
            return oldValue;
        }

        public static MyNode CreateEmptyNode()
        {
            return new MyNode();
        }

        public string UpdateValue(string s)
        {
            throw new NotImplementedException();
        }
        public void ClearValues()
        {
            _values.Clear();
            _value = string.Empty;
            OnNodeChange?.Invoke();
        }
    }
}