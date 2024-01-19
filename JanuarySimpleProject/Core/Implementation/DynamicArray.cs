﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.Core.Implementation
{
    class DynamicArray<T>
    {
        private T[] items;
        private int count;

        public DynamicArray()
        {
            items = new T[0];
            count = 0;
        }

        public void Add(T item)
        {
            T[] newArray = new T[count + 1];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = items[i];
            }
            newArray[count] = item;
            items = newArray;
            count++;
        }

        public void Remove(T item)
        {
            int itemIndex = Array.IndexOf(items, item);
            if (itemIndex >= 0)
            {
                T[] newArray = new T[count - 1];
                for (int i = 0, j = 0; i < count; i++)
                {
                    if (i != itemIndex)
                    {
                        newArray[j] = items[i];
                        j++;
                    }
                }
                items = newArray;
                count--;
            }
        }

        public bool Contains(T item)
        {
            return Array.IndexOf(items, item) >= 0;
        }

        public int Count
        {
            get { return count; }
        }

        public void Print()
        {
            Console.WriteLine(string.Join(", ", items));
        }
    }

}
