using JanuarySimpleProject.Core.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Collections.Immutable;

namespace JanuarySimpleProject.Core
{
    public class MyNode : IMyNode
    {
        private Dictionary<object, int> _values;
        private string _value;
        public string Id { get; }
        public string Name { get; set; }
        public object Value
        {
            get { return _value; }
            set
            {
                _values = new Dictionary<object, int>
                {
                    { value, 1 }
                };
                
                _value = $"{JsonConvert.SerializeObject(value)}||sep||";
                OnNodeChange();
            }
        }
        public DateTime DateTimeCreate { get; }
        public DateTime DateTimeUpdate { get; private set; }

        public MyNode(string name)
        {
            Id = Guid.NewGuid().ToString();
            DateTimeCreate = DateTime.Now;
            DateTimeUpdate = DateTimeCreate;

            _values = new Dictionary<object, int>();

            Name = name;

            OnNodeChange = UpdateTime;
            OnNodeChange += CheckNode;
            OnNodeChange += ShowInfo;
        }

        private void MyNode_OnNodeChange()
        {
            throw new NotImplementedException();
        }

        public void ShowInfo()
        {
            Console.WriteLine($"MyNode: {Name} with Id: {Id}\n" +
                $"Creation Date:{DateTimeCreate}\nLast changes: {DateTimeUpdate}\n" +
                $"Value:{Print()}");
        }
        public void AddValue<TValue>(TValue value)
        {
            if (_values.ContainsKey(value))
            {
                _values[value] += 1;
            }
            else
            {
                _values.Add(value, 1);
            }
            _value += $"{JsonConvert.SerializeObject(value)}||sep||";
            OnNodeChange();
        }
        public void RemoveValue<TValue>(TValue value)
        {
            if (!_values.ContainsKey(value))
                throw new Exception("Элемента нет в массиве!");

            if (_values[value] > 1)
            {
                _values[value] -= 1;
            }
            else
            {
                _values.Remove(value);
            }
            ValueRefresh();
            OnNodeChange();
        }

        public void RemoveAllValue<TValue>(TValue value)
        {
            if (!_values.ContainsKey(value))
                throw new Exception("Элемента нет в массиве!");

            _values.Remove(value);
            ValueRefresh();
            OnNodeChange();
        }

        public void ClearNode()
        {
            _values.Clear();
            _value = "";

            OnNodeChange();
        }

        public TValue UpdateValue<TValue>(TValue oldValue, TValue newValue)
        {
            if(!_values.ContainsKey(oldValue))
                throw new Exception("Элемента нет в массиве!");

            _values.Remove(oldValue);
            _values.Add(newValue, 1);

            ValueRefresh();

            OnNodeChange();
            return oldValue;
        }
        
        private void UpdateTime()
        {
            DateTimeUpdate = DateTime.Now;
        }

        private void CheckNode()
        {
            Dictionary<object, int> temp = new Dictionary<object, int>();
            foreach (string s in _value.Split("||sep||"))
            {
                object deserialized = JsonConvert.DeserializeObject<object>(s);
                if (s != "" && temp.ContainsKey(deserialized))
                    temp[deserialized] += 1;
                else if (s != "")
                {
                    temp.Add(deserialized, 1);
                }
            }
            if (DictionaryCompersion(temp) && !(_value == "" && temp.Count == 0))
            {
                throw new Exception("Node is not correct!");
            }
        }

        private void ValueRefresh()
        {
            _value = "";
            foreach(object obj in _values)
            {
                _value += $"{JsonConvert.SerializeObject(obj)}||sep||";
            }
        }

        private string Print()
        {
            string temp = "";
            for(int i = 0; i < _values.Count; i++)
            {
                temp += $"({_values.ElementAt(i).Key}, Amount: {_values.ElementAt(i).Value}) ";
            }
            if (temp == "")
                return "Empty";
            return temp;
        }

        private bool DictionaryCompersion(Dictionary<object, int> dict)
        {
            for(int i = 0; i < _values.Count; i++)
            {
                if (!(_values.ElementAt(i).Value == dict.ElementAt(i).Value && _values.ElementAt(i).Key == dict.ElementAt(i).Key))
                    return false;
            }
            return true;
        }

        public event Action OnNodeChange;
    }
}
