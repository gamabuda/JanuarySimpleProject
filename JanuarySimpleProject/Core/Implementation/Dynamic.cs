namespace JanuarySimpleProject.Core.Implementation
{
    public class Dynamic<TAny>
    {
        private TAny[] _values;

        public Dynamic()
        {
            _values = new TAny[0];
        }

        public Dynamic(TAny value)
        {
            _values = new TAny[1] { value };
        }

        public TAny this[int index]
        {
            get { return _values[index]; }
            set { _values[index] = value; }
        }

        public void Remove(TAny value)
        {
            int index = Array.IndexOf(_values, value);
            if (index != -1)
            {
                _values[index] = default(TAny);
                _values = _values.Where(a => a != null).ToArray();
            }
            else
            {
                throw new Exception("There is no such element in the array");
            }
        }

        public bool Contains(TAny value)
        {
            return _values.Contains(value);
        }

        public void Clear()
        {
            _values = new TAny[0];
        }

        public void Replace(TAny oldValue, TAny newValue)
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
