namespace JanuarySimpleProject.Core.Implementation
{
    public class Node1 : INode
    {
        private List<string> _values = new List<string>();
        private string _value;

        public Node1()
        {
            Id = Guid.NewGuid().ToString();
            Name = "NewNode";
            DateTimeCreate = DateTime.Now;
            DateTimeUpdate = DateTimeCreate;

            OnNodeChange += CheckNode;
            OnNodeChange += DateTimeEditChange;
        }

        public Node1(string name)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            DateTimeCreate = DateTime.Now;
            DateTimeUpdate = DateTimeCreate;

            OnNodeChange += CheckNode;
            OnNodeChange += DateTimeEditChange;
        }

        public string Id { get; }

        public string Name { get; set; }

        public string Value
        {
            get => _value;
            set
            {
                _value = value?.Trim() ?? string.Empty;
                _values.Clear();
                _values.Add(_value);
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
            string strValue = value?.ToString().Trim();

            if (string.IsNullOrEmpty(strValue))
                throw new ArgumentException("Value is null or empty.");

            if (_values.Contains(strValue))
                throw new ArgumentException("Value already exists in the list.");

            _values.Add(strValue);
            _value += strValue;

            OnNodeChange?.Invoke();
        }

        public void RemoveValue<TValue>(TValue value)
        {
            string strValue = value?.ToString().Trim();

            if (string.IsNullOrEmpty(strValue))
                throw new ArgumentException("Value is null or empty.");

            if (!_values.Contains(strValue))
                throw new ArgumentException("Value does not exist in the list.");

            _values.Remove(strValue);
            _value = Value.Replace(strValue, "");

            OnNodeChange?.Invoke();
        }

        public void UpdateValue<TValue>(TValue value)
        {
            string strValue = value?.ToString().Trim();

            if (string.IsNullOrEmpty(strValue))
                throw new ArgumentException("Value is null or empty.");

            _value = strValue;
            _values = new List<string> { _value };

            OnNodeChange?.Invoke();
        }

        private void DateTimeEditChange()
        {
            DateTimeUpdate = DateTime.Now;
        }

        private void CheckNode()
        {
            var temp = string.Empty;
            foreach (var v in _values)
                temp += v;

            if (_value != temp)
                throw new Exception("Node is not correct or broken");
        }

    }
}