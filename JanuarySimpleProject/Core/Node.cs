﻿using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using JanuarySimpleProject.Core.Implementation;

namespace JanuarySimpleProject.Core
{
    public class Node : INode
    {
        //TODO switch list to array
        private TDinamicArray<string> _values = new TDinamicArray<string>(12);
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
                throw new Exception("Nothing added");

            if (_values.Contains(strValue))
                throw new Exception("these value ​​already exist");

            _values.Add(strValue);
            _value += $"{strValue}";

            OnNodeChange?.Invoke();
        }

        //TODO switch all returns to throw Exception
        public void AddValue<TValue>(List<TValue> values)
        {
            if (values.Count <= 0)
                throw new Exception("List is empty");
            

            foreach (var value in values)
            {
                string strValue = value.ToString().Trim();

                if (strValue == null)
                   throw new Exception("Nothing added");

                if (_values.Contains(strValue))
                    throw new Exception("these values ​​already exist");

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
                throw new Exception("these value ​​is empty");

            if (!_values.Contains(strValue))
                throw new Exception("these value ​​is not exist");

            _values.Remove(strValue);
            _value = Value.Replace(strValue, "");

            OnNodeChange?.Invoke();
        }

        public void RemoveValue<TValue>(List<TValue> values)
        {
            if (values.Count <= 0)
                throw new Exception("There is nothing to delete");

            foreach (var value in values)
            {
                string strValue = value.ToString().Trim();

                if (strValue == null)
                    throw new Exception("Nothing   deleted");

                if (!_values.Contains(strValue))
                    throw new Exception("these values ​​is not exist");

                _values.Remove(strValue);
                _value = Value.Replace(strValue, "");

                OnNodeChange?.Invoke();
            }
        }
        public INode UpadateMethod<TValue>(INode oldValue, INode newValue)
        {
            string StringOldValue = oldValue.ToString().Trim();
            string StringNewValue = newValue.ToString().Trim();
            if (!_values.Contains(StringOldValue)) throw new Exception("this element not exist in array");
            if (_values.Contains(StringNewValue)) throw new Exception( "this element already has existed in array");
            if (StringNewValue == null) throw new Exception("You try add null value");
            _values.ReplaceX(StringOldValue, StringNewValue);
            _value = Value.Replace(StringOldValue, StringNewValue);

            return oldValue;
            

        }
        public static Node CreateEmptyNode()
        {
            return new Node();
        }

        public void UpadateMethod<INode>(INode value1, INode value2)
        {
            throw new NotImplementedException();
        }
    }
}

