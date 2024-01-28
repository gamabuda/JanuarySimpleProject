using System;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.RegularExpressions;
using JanuarySimpleProject.Core.Implementation;

namespace JanuarySimpleProject.Core
{
    public class Node : INode
    {
        //TODO switch list to array (accomplished)
        DynamicArray<MyClass<string>, string> _values = new DynamicArray<MyClass<string>, string>();
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
                //TODO need optimize (accomplished)
                _values = new DynamicArray<MyClass<string>, string>(value);
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

        //TODO switch all returns to throw Exception (accomplished)
        public void AddValue<TValue>(TValue value)
        {
            string strValue = value.ToString().Trim();

            if (strValue == null)
                throw new Exception("Вы не можете добавить null-значение");

            if (_values.Contains(strValue))
                throw new Exception("Такое значение уже есть в массиве");

            _values.Add(strValue);
            _value += $"{strValue}";

            OnNodeChange?.Invoke();
        }

        //TODO switch all returns to throw Exception (accomplished)
        public void AddValue<TValue>(List<TValue> values)
        {
            if (values.Count <= 0)
                throw new Exception("Вы не можете добавить пустой список");

            foreach (var value in values)
            {
                string strValue = value.ToString().Trim();

                if (strValue == null)
                    throw new Exception("Вы не можете добавить null-значение");

                if (_values.Contains(strValue))
                    throw new Exception("Список элементов уже есть в массиве");

                _values.Add(strValue);
                _value += $"{strValue}";

                OnNodeChange?.Invoke();
            }
        }

        //TODO switch all returns to throw Exception and add the ability to delete a list of objects (accomplished)
        public void RemoveValue<TValue>(TValue value) 
        {
            string strValue = value.ToString().Trim();

            if (strValue == null)
                throw new Exception("Вы не можете удалить null-значение");

            if (!_values.Contains(strValue))
                throw new Exception("Такого значения нет в массиве");

            _values.Remove(strValue);
            _value = Value.Replace(strValue, "");

            OnNodeChange?.Invoke();
        }

        public void RemoveValue<TValue>(List<TValue> values)
        {

            if (values.Count <= 0)
                throw new Exception("Список элементов пустой");

            foreach (var value in values)
            {
                string strValue = value.ToString().Trim();

                if (strValue == null)
                    throw new Exception("Вы пытаетесь удалить null значение");

                if (!_values.Contains(strValue))
                    throw new Exception("Данного элемента нет в массиве");

                Regex reg = new Regex(strValue);

                _values.Remove(strValue);
                _value = reg.Replace(Value, "", 1);

                OnNodeChange?.Invoke();
            }
        }

        public TValue UpdateValue<TValue>(TValue oldValue, TValue newValue)
        {
            string strOldValue = oldValue.ToString().Trim();
            string strNewValue = newValue.ToString().Trim();
            if (!_values.Contains(strOldValue))
                throw new Exception("Элемента нет в массиве");

            if (_values.Contains(strNewValue))
                throw new Exception("Элемент уже есть в массиве");

            if (strNewValue == null)
                throw new Exception("Вы пытаетесь добавить null значение");

            _values.Replace(strOldValue, strNewValue);
            _value = Value.Replace(strOldValue, strNewValue);
            return oldValue;
        }

        public static Node CreateEmptyNode()
        {
            return new Node();
        }
    }
}

