using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.NewNode
{
    class Programm
    {
        static void Main(string[] args)
        {
            MyNode node = new MyNode("MyNode");
            node.Value = "123";
            node.ShowInfo();

            node.AddValue("456");
            node.ShowInfo();

            node.UpdateValue("123", "789");
            node.ShowInfo();

            node.RemoveValue("789");
            node.ShowInfo();
            List<int> numbers = new List<int> { 5, 2, 8, 1, 4 };
            BubbleSort(numbers);
            Console.WriteLine(string.Join(" ", numbers));

            Console.ReadLine();

            Console.ReadLine();
        }
        static void BubbleSort(List<int> numbers)
        {
            int n = numbers.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
        }
    }
}
  