namespace JanuarySimpleProject.Core.Implementation
{
    public class DynamicArray<TType>
    {
        private TType[] _values;

        public DynamicArray()
        {
            _values = new TType[0];
        }

        public DynamicArray(TType value)
        {
            _values = new TType[1] { value };
        }

        public TType this[int index]
        {
            get { return _values[index]; }
            set { _values[index] = value; }
        }

        public void Remove(TType value)
        {
            int index = Array.IndexOf(_values, value);
            if (index != -1)
            {
                _values[index] = default(TType);
                _values = _values.Where(a => a != null).ToArray();
            }
            else
            {
                throw new Exception("Такого элемента нет в массиве")
            }
        }

        public bool Contains(TType value)
        {
            return _values.Contains(value);
        }

        public void Clear()
        {
            _values = new TType[0];
        }

        public void Replace(TType oldValue, TType newValue)
        {
            int index = Array.IndexOf(_values, oldValue);
            _values[index] = newValue;
        }

        public IEnumerator<object> GetEnumerator()
        {
            for (int i = 0; i < _values.Length; i++)
            {
                yield return _values[i];
            }
        }
    }
}