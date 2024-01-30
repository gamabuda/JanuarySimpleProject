using System;
using JanuarySimpleProject.Core.Implementation;
namespace JanuarySimpleProject.Core
{
    public class JustNode : INode
    {
        private string _value;

        public JustNode()
        {
            Id = Guid.NewGuid().ToString();
            Name = "JustNode";
            DateTimeCreate = DateTime.Now;
            DateTimeUpdate = DateTimeCreate;
        }

        public JustNode(string name)
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
                _value = value?.Trim();
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
            Value = value?.ToString();
        }

        public void RemoveValue<TValue>(TValue value)
        {
            Value = string.Empty;
        }

        public static Node CreateEmptyNode()
        {
            return new JustNode();
        }
    }
}