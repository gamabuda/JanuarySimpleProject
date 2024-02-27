using JanuarySimpleProject.Core.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JanuarySimpleProject.Core
{
    public delegate void TransactionOperation(string msg);

    public class MyNode : INode
    {
        public MyNode(string name)
        {
            Id = Guid.NewGuid().ToString();

            Name = name;
            DateTimeCreate = DateTime.Now;
            DateTimeUpdate = DateTimeCreate;

            OnNodeChange += CheckNode;
            OnNodeChange += DateTimeEditChange;
            TransactionOperationHandler(PrintMessage);
        }

        private DynamicArray<string> _items = new DynamicArray<string>(0);
        private string _item;

        public string Id { get; }
        public string Name { get; set; }
        public string Value { get; set; }

        private decimal _balance = 0;
        private string _password;

        public decimal Balance
        {
            get => _balance;
            set
            {
                _balance = value;
            }
        }

        public DateTime DateTimeCreate { get; }
        public DateTime DateTimeUpdate { get; private set; }

        public event Action OnNodeChange;

        public TransactionOperation? Operation;
        public void TransactionOperationHandler(TransactionOperation del) => Operation += del;
        private static void PrintMessage(string msg) => Console.WriteLine(msg);

        private void DateTimeEditChange()
        {
            DateTimeUpdate = DateTime.Now;
        }

        private void CheckNode()
        {
            var temp = String.Empty;
            for (var i = 0; i < _items.Count; i++)
            {
                temp += _item.Sort()[i];
            }
        }

        public void AddValue<TValue>(TValue value)
        {
            string strValue = value.ToString().Trim();

            if (strValue == null)
                throw new Exception("The value is null");

            if (_items.Contains(strValue))
                throw new Exception("The value is already contained in the Node");

            _items.Add(strValue);
            _item += $"{strValue}";

            OnNodeChange?.Invoke();
        }

        public void RemoveValue<TValue>(TValue value)
        {
            string strValue = value.ToString().Trim();

            if (strValue == null)
                throw new Exception("The value is null");

            if (!_items.Contains(strValue))
                throw new Exception("The value is not contained in the node");

            _items.Remove(strValue);
            _item = Value.Replace(strValue, "");

            OnNodeChange?.Invoke();
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Node:" +
                 $"\tName: {Name} ID:{Id}\n" +
                 $"\tDateTime create: {DateTimeCreate}\n" +
                 $"\tDateTime last update: {DateTimeUpdate}\n" +
                 $"\tValue: {Value}");
            Operation?.Invoke($"\tBalance: {_balance}₽");
        }

        public string UpdateValue(string value)
        {
            string oldValue = _item;
            _item = value;
            return oldValue;
        }

        public void Sort()
        {
            string[] array = _item.GetArray();

            for (int i = 0; i < _items.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < _items.Count; j++)
                {
                    if (array[j].CompareTo(array[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    string temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }

            _items.Clear();
            foreach (string value in array)
            {
                _items.Add(value);
            }
        }
        public string PrintArray() => _item.Print();

        public int BinarySearch(string item)
        {
            Sort();

            string[] array = _item.GetArray();
            int left = 0;
            int right = _items.Count - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (array[middle].CompareTo(item) == 0)
                    return middle;

                if (array[middle].CompareTo(item) < 0)
                    left = middle + 1;
                else
                    right = middle - 1;
            }

            return -1;
        }

        public void Transaction(int total)
        {
            Balance += total;
            Console.ForegroundColor = ConsoleColor.Green;
            Operation?.Invoke($"Операция выполнена успешно! Счет пополнен на сумму {total}₽. Ваш текущий баланс: {_balance}₽");
            Console.ResetColor();
            OnNodeChange?.Invoke();
        }

        public void UpdateValue<TValue>(TValue oldValue, TValue newValue)
        {
            throw new NotImplementedException();
        }
    }
}
