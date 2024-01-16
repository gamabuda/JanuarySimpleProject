using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JanuarySimpleProject.Core
{
    public class DynamicArray
    {
        private int[] items;
        private int count;

        public DynamicArray(int length)
        {
            items = new int[length];
            count = 0;
        }

        private void IncreaseArray()
        {
            int newCount = count + count / 2;
            if (count == 0)
            {
                newCount = 10;
            }

            var newArray = new int[newCount];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = items[i];
            }

            items = newArray;
        }

        public void Add(int item)
        {
            if (count == items.Length)
            {
                IncreaseArray();
            }

            items[count] = item;
            count++;
        }

        public void Remove(int item)
        {
            if (count == 0)
            {
                throw new Exception("Массив пустой!");
            }

            int index = Array.IndexOf(items, item);

            if (items.Contains(item))
            {
                for (var i = 0; i < count; i++)
                {
                    if (items[i] == items[index])
                    {
                        items[i] = items[i + 1];

                        for(var j = i;  j < count; j++)
                        {
                            items[j] = items[j + 1];
                        }

                        count--;
                        break;
                    }
                }
            }
            else
            {
                throw new Exception("Значение не найдено!");
            }
        }

        public bool Contains(int item)
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

        public int Count()
        {
            return count;
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
    }
}
