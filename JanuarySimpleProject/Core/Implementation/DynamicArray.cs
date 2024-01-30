using System;

public class DynamicArray<T>
{
    private T[] _array;
    private int length;
    private int _count;
    public DynamicArray(int _len)
    {
        length = _len;
        _array = new T[length];
        _count = 0;
    }

    public void Add(T str)
    {
        if (_count == _array.Length)
        {
            Array.Resize(ref _array, _array.Length * 2);
        }
        _array[_count] = str;
        _count++;
    }

    public void Remove(string str)
    {
        int index = Array.IndexOf(_array, str, 0, _count);

        if (index != -1)
        {
            for (int i = 0; i < _count - 1; i++)
            {
                _array[i] = _array[i + 1];
            }
            _count--;
        }
    }

    public void Clear()
    {
        _array = new T[length];
    }

    public bool Contains(string str)
    {
        return Array.IndexOf(_array, str, 0, _count) != -1;
    }

    public void Print()
    {
        for (int i = 0; i < _count; i++)
        {
            Console.Write(_array[i] + " ");
        }
        Console.WriteLine();
    }

    public int Count
    {
        get { return _count; }
    }
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            yield return _array[i];
        }
    }
    private int BinarySearch(string[] array, int left, int right, string value)
    {
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            int compareResult = string.Compare(array[mid], value);

            if (compareResult == 0)
            {
                return mid;
            }
            else if (compareResult < 0)
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
        private int CustomCompare(T obj1, T obj2)
        {
            int hashCode1 = obj1.GetHashCode();
            int hashCode2 = obj2.GetHashCode();

            return hashCode1.CompareTo(hashCode2);
        }

        public void CustomSort()
        {
            Array.Sort(_array, 0, _count, new CustomComparer<T>(CustomCompare));
        }
}




