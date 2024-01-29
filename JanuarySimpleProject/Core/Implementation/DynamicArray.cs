using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using JanuarySimpleProject.Core.Implementation;

namespace JanuarySimpleProject.Core.Implementation
{
    public class DynamicArray<MyCLass, TValue>
    {
        private MyClass<TValue>[] _values;
        private int _count;
        public int Count { get { return _count - 1; } }
        public DynamicArray()
        {
            _values = new MyClass<TValue>[1];
            _count = 0;
        }

        public DynamicArray(TValue value)
        {
            _values = new MyClass<TValue>[1] { new MyClass<TValue>(value) };
            _count = 1;
        }
        public TValue this[int index]
        {
            get { return _values[index].Value; }
            set { _values[index] = new MyClass<TValue>(value); }
        }

        public void Add(TValue value)
        {
            MyClass<TValue> valueToAdd = new MyClass<TValue>(value);
            if (_count != _values.Length)
            {
                _values[_count] = valueToAdd;
            }
            else
            {
                MyClass<TValue>[] temp = new MyClass<TValue>[_values.Length * 2];
                _values.CopyTo(temp, 0);
                _values = temp;
                _values[_count] = valueToAdd;
            }
            _count++;
        }

        public void Remove(TValue value)
        {

            int index = Array.IndexOf(_values, new MyClass<TValue>(value));
            if (index != -1)
            {
                _values[index].Value = default(TValue);
                _values = _values.Where(a => a != null).ToArray();
            }
            else
            {
                throw new Exception("Элемента нет в массиве");
            }
            _count--;
        }

        public bool Contains(TValue value)
        {
            return _values.Contains(new MyClass<TValue>(value));
        }

        public void Clear()
        {
            _values = new MyClass<TValue>[1];
            _count = 0;
        }

        public void Replace(TValue oldValue, TValue newValue)
        {
            int index = Array.IndexOf(_values, new MyClass<TValue>(oldValue));
            _values[index] = new MyClass<TValue>(newValue);
        }

        public IEnumerator<object> GetEnumerator()
        {
            for (int i = 0; i < _values.Length; i++)
            {
                yield return _values[i];
            }
        }

        public void Sort()
        {
            MyClass<TValue> temp;
            for (int write = 0; write < this.Count; write++)
            {
                for (int sort = 0; sort < this.Count - 1; sort++)
                {
                    if (this._values[sort] > this._values[sort + 1])
                    {
                        temp = this._values[sort + 1];
                        this._values[sort + 1] = this._values[sort];
                        this._values[sort] = temp;
                    }
                }
            }
        }

        public int BinnarySearch(TValue value)
        {
            if (!Contains(value))
                return -1;

            if (Count == 0)
                throw new Exception("Массив пуст");

            Sort();

            int middleIndex = _count / 2;

            if (_values[middleIndex] == new MyClass<TValue>(value))
            {
                return middleIndex;
            }
            else if (_values[middleIndex] > new MyClass<TValue>(value))
            {
                return BinnarySearch(value, 0, middleIndex);
            }
            else
            {
                return BinnarySearch(value, middleIndex, _count);
            }
        }

        private int BinnarySearch(TValue value, int startIndex, int endIndex)
        {
            if (endIndex == startIndex)
                return startIndex;

            int middleIndex = (endIndex + startIndex) / 2;
            if (_values[middleIndex] == new MyClass<TValue>(value))
                return middleIndex;
            else if (_values[middleIndex] > new MyClass<TValue>(value))
            {
                return BinnarySearch(value, startIndex, middleIndex);
            }
            else
            {
                return BinnarySearch(value, middleIndex, endIndex);
            }
        }
    }
}