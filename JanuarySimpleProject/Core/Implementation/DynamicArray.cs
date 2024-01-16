public class DynamicArray<T>
{
    private int ArrayLength { get; set; }
    private T[] MyArray;

    public DynamicArray(int length)
    {
        MyArray = new T[length];
        ArrayLength = 0;
    }

    public void Add(T item)
    {
        if (ArrayLength < MyArray.Length)
        {
            MyArray[ArrayLength] = item;
            ArrayLength++;
        }
        else
        {
            ResizeArray();
            MyArray[ArrayLength] = item;
            ArrayLength++;
        }
    }

    public bool Remove(T item)
    {
        int index = Array.IndexOf(MyArray, item);
        if (index != -1)
        {
            for (int i = index; i < ArrayLength - 1; i++)
            {
                MyArray[i] = MyArray[i + 1];
            }
            MyArray[ArrayLength - 1] = default(T);
            ArrayLength--;
            return true;
        }
        return false;
    }

    public bool Contains(T item)
    {
        return Array.IndexOf(MyArray, item) != -1;
    }

    public int Count
    {
        get { return ArrayLength; }
    }

    public void Print()
    {
        for (int i = 0; i < ArrayLength; i++)
        {
            Console.WriteLine(MyArray[i]);
        }
    }

    private void ResizeArray()
    {
        T[] newArray = new T[MyArray.Length * 2];
        Array.Copy(MyArray, newArray, MyArray.Length);
        MyArray = newArray;
    }
}
}
