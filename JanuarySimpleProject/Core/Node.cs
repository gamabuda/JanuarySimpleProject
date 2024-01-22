using System;
using System.Text.Json;
using JanuarySimpleProject.Core.Implementation;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using JanuarySimpleProject.Core;
using System.Linq;

namespace JanuarySimpleProject.Core
{
    public class Node : INode
    {
        //TODO switch list to array
        private List<string> values = new List<string>();
        private DynamicArray<string> _values = new DynamicArray<string>();
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

                _values = new DynamicArray<string>();

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
            foreach (var v in _values._array)
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
                throw new Exception("Node is not can be Null");

            if (_values.Contains(strValue))
                throw new Exception("This value already exist");

            _values.Add(strValue);
            _value += $"{strValue}";

            OnNodeChange?.Invoke();
        }

        //TODO switch all returns to throw Exception
        public void AddValue<TValue>(List<TValue> values)
        {
            if (values.Count <= 0)
                throw new Exception("List is not can be Null");

            foreach (var value in values)
            {
                string strValue = value.ToString().Trim();

                if (strValue == null)
                    throw new Exception("Value is not can be Null");

                if (_values.Contains(strValue))
                    throw new Exception("This value already exist");

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
                throw new Exception("Value is not can be Null");

            if (!_values.Contains(strValue))
                throw new Exception("Value is not exist");

            _values.Remove(strValue);
            _value = Value.Replace(strValue, "");

            OnNodeChange?.Invoke();
        }

        public void RemoveValue<TValue>(List<TValue> value)
        {
            if (value.Count <= 0)
                throw new Exception("List is not can be Null");

            foreach (var values in value)
            {
                string strValue = value.ToString().Trim();

                if (strValue == null)
                    throw new Exception("Value is not can be Null");

                if (!_values.Contains(strValue))
                    throw new Exception("Value is not exist");

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

        public void SortArray()
        {
            string[] sorted = _values._array.OrderBy(x => x).ToArray();
            //int temp = 0;

            //if (typeof(_values) == int)
            //{

            //    for (int write = 0; write < _values.Length; write++)
            //    {
            //        for (int sort = 0; sort < _values.Length - 1; sort++)
            //        {
            //            if (Convert.ChangeType(_values[sort]) > _values[sort + 1])
            //            {
            //                temp = _values[sort + 1];
            //                _values[sort + 1] = _values[sort];
            //                _values[sort] = temp;
            //            }
            //        }
            //    }

            //    for (int i = 0; i < _values.Length; i++)
            //        Console.Write(_values[i] + " ");

            //    Console.ReadKey();
            //}
            //else if (typeof(_values) == string)
            //{

            //    string[] sorted = _values.OrderBy(x => x).ToArray();
            //}
            //else
            //{
            //    Console.WriteLine("Type of T != string or int");
            //}
        }
    }
}

