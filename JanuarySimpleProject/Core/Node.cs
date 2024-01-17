using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using JanuarySimpleProject.Core.Implementation;

namespace JanuarySimpleProject.Core
{
    public class Node : INode
    {
        //TODO switch list to array
        private List<string> _values = new List<string>();
        private string _value;
        public class TDinamicArray<TValue>
        {
            private string[] _array;
            private int _count;
            public TDinamicArray(int len)
            {
                _array = new string[len + len];
                _count = 0;
            }
            void Add(string s)
            {
                if(_count == _array.Length)
                {
                    publ9c
                    Array.Resize(ref _array, _count);
                }
                _array[_count] = s;
                _count++;
            }
            void Remove(string s)
            {
                int index = Array.IndexOf(_array, s, 0,_count);
                if(index != -1)
                {
                    for(int i = 0; i < _count-1; i++)
                    {
                        _array[i] = _array[i + 1];
                    }
                }
              
                _count--;
            }
            
            public int Count
            {
                get { return _count; }
            }
            public bool Contains(string s)
            {
                return Array.IndexOf(_array,s, 0,_count) != -1;
            }

            void Print()
            {
                foreach (var s in _array)
                    Console.WriteLine(s);
                for(int i = 0; i < _count; i++)
                {
                    Console.WriteLine(_array[i]+ " ");
                }
            }
            

        }


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

        public void AddValRemoveValueue<TValue>(List<TValue> values)
        {
            if (values.Count <= 0)
                throw new Exception("There is nothing to delete");

            foreach (var value in values)
            {
                string strValue = value.ToString().Trim();

                if (strValue == null)
                    throw new Exception("Nothing deleted");

                if (!_values.Contains(strValue))
                    throw new Exception("these values ​​is not exist");

                _values.Remove(strValue);
                _value = Value.Replace(strValue, "");

                OnNodeChange?.Invoke();
            }
        }

        public static Node CreateEmptyNode()
        {
            return new Node();
        }
    }
}

