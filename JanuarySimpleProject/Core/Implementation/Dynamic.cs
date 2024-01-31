namespace JanuarySimpleProject.Core.Implementation
{
    public class Dynamic<TAny> where TAny : IComparable<TAny>
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

        internal void Add(string strValue)
        {
            throw new NotImplementedException();
        }

        public int BinarySearch(TAny value)
        {
            int left = 0;
            int right = _values.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (NewMethod(value, mid) == 0)
                {
                    return mid;
                }
                else if (_values[mid].CompareTo(value) < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }

        private int NewMethod(TAny value, int mid)
        {
            return _values[mid].CompareTo(value);
        }

        public void Sort()
        {
            Array.Sort(_values);
        }

        public void SortCustom()
        {
            for (int i = 0; i < _values.Length - 1; i++)
            {
                for (int j = i + 1; j < _values.Length; j++)
                {
                    if (_values[i].CompareTo(_values[j]) > 0)
                    {
                        TAny temp = _values[i];
                        _values[i] = _values[j];
                        _values[j] = temp;
                    }
                }
            }
        }
    }
}
