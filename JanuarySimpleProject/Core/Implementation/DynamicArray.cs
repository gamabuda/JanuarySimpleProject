using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.Core.Implementation
{
    public class DynamicArray
    {
        private string[] _values;
        public DynamicArray()
        {
            _values = new string[1];
        }

        public string this[int index]
        {
            get { return _values[index]; }
            set { _values[index] = value; }
        }

        public void Add(string value)
        {
            int lastIndex = _values.Length - 1;
            if (lastIndex == null)
            {
                _values[lastIndex] = value;
            }
            else
            {
                string[] temp = new string[_values.Length + 1];
                _values.CopyTo(temp, 0);
                _values = temp;
                _values[lastIndex+1] = value;
            }
        }

        public void Remove(string value)
        {
            
            int index = Array.IndexOf(_values, value);
            if(index != -1)
            {
                _values[index] = null;
                _values = _values.Where(a => a != null).ToArray();
            }
            else
            {
                throw new Exception("Элемента нет в массиве");       
            }
        }

        public bool Contains(string value)
        {
            return _values.Contains(value);
        }

        public void Clear()
        {
            _values = new string[0];
        }

        public void Replace(string oldValue, string newValue) 
        {
            int index = Array.IndexOf(_values, oldValue);
            _values[index] = newValue;
        }

        public IEnumerator<string> GetEnumerator()
        {
            for(int i = 0;  i < _values.Length; i++)
            {
                yield return _values[i];
            }
        }
    }
}
