using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.Core
{
    public class DynamicArray<T>
    {
        private int ArrayLength { get; set; }

        private T[] MyArray;
        public DynamicArray(int arraylength) 
        {
            MyArray = new T[arraylength];
            ArrayLength = arraylength + arraylength / 2;
        }

        public void AddValue<TValue>(T item)
        {
            //Проверка на индекс за пределами массива, если места нет ресайз эррей
            if(MyArray.Last() == null)
            {
                MyArray[ArrayLength] = item;
                ArrayLength++;
            }
            else
            {
                var NewDynamicArray = new DynamicArray<TValue>(MyArray.Length + 10);

                for(int i = 0; i < MyArray.Length; i++)
                {
                
                    NewDynamicArray.AddValue<T>(MyArray[i]);
                }
            }
            
        }
        public void Print()
        {
            foreach(var item in MyArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
