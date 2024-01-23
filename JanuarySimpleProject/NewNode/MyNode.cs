using JanuarySimpleProject.Core.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.NewNode
{
    public class MyNode : INode
    {
        private List<string> _values = new List<string>();
        private string _value;

        public MyNode(string name)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            DateTimeCreate = DateTime.Now;
            DateTimeUpdate = DateTimeCreate;
        }

        public string Id { get; }
        public string Name { get; set; }
        public string Value
        {
            get => _value;
            set
            {
                _value = value.Trim();
                _values = new List<string> { _value };
                OnNodeChange?.Invoke();
            }
        }

        public DateTime DateTimeCreate { get; }
        public DateTime DateTimeUpdate { get; private set; }

        public event Action OnNodeChange;

        public void ShowInfo()
        {
            Console.WriteLine($"Node:\tName:{Name} ID:{Id}\n\tDateTime create:{DateTimeCreate}\n\tDateTime last update:{DateTimeUpdate}\n\tValue:{Value}");
        }

        public void AddValue<TValue>(TValue value)
        {
            string strValue = value?.ToString().Trim() ?? throw new ArgumentNullException(nameof(value));

            if (_values.Contains(strValue))
                throw new Exception("Value already exists");

            _values.Add(strValue);
            _value += strValue;

            OnNodeChange?.Invoke();
        }

        public void RemoveValue<TValue>(TValue value)
        {
            string strValue = value.ToString().Trim();

            if (strValue == null)
                throw new ArgumentException("Value cannot be null");

            if (!_values.Contains(strValue))
                throw new Exception("Value does not exist");

            _values.Remove(strValue);
            _value = Value.Replace(strValue, "");

            OnNodeChange?.Invoke();
        }

        public void UpdateValue<TValue>(TValue oldValue, TValue newValue)
        {
            string strOldValue = oldValue.ToString().Trim();
            string strNewValue = newValue.ToString().Trim();

            if (strOldValue == null || strNewValue == null)
                throw new ArgumentException("Value cannot be null");

            int index = _values.IndexOf(strOldValue);
            if (index < 0)
                throw new Exception("Value does not exist");

            _values[index] = strNewValue;
            _value = Value.Replace(strOldValue, strNewValue);

            OnNodeChange?.Invoke();
        }
    }
}
