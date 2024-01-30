﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JanuarySimpleProject.Core
{
    public class DynamicArray<T> where T : IComparable<T>
    {
        private T[] items;
        private int count;
        public T Value { get; set; }
        public int Count { get { return count; } }

        public DynamicArray(int length)
        {
            items = new T[length];
            count = 0;
        }

        private void IncreaseArray()
        {
            int newCount = count + count / 2;
            if (count == 0)
            {
                newCount = 10;
            }

            var newArray = new T[newCount];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = items[i];
            }

            items = newArray;
        }

        public void Add(T item)
        {
            if (count == items.Length)
            {
                IncreaseArray();
            }

            items[count] = item;
            count++;
        }

        public void Remove(T item)
        {
            if (count == 0)
            {
                throw new Exception("Массив пустой!");
            }

            int index = Array.IndexOf(items, item, 0, count);

            if (index != -1)
            {
                for (int i = index; i < count - 1; i++)
                {
                    items[i] = items[i + 1];
                }
                count--;
            }
            else
            {
                throw new Exception("Значение не найдено!");
            }
        }

        public bool Contains(T item)
        {
            if (items.Contains(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Print()
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += items[i] + " ";
            }

            return result;
        }

        public void Clear()
        {
            var newArray = new T[10];
            items = newArray;
            count = 0;
        }

        public T[] GetArray()
        {
            T[] array = new T[count];
            for (int i = 0; i < count; i++)
            {
                if (items[i] != null)
                {
                    array[i] = items[i];
                }
            }

            return array;
        }
    }
}
