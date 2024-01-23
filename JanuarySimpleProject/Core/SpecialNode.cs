using JanuarySimpleProject.Core.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.Core
{
    public class SpecialNode : INode
    {
        public SpecialNode()
        {
        }

        public string Id { get; }
        public string Name { get; set; }
        public string Value { get; set; }

        public DateTime DateTimeCreate { get; }
        public DateTime DateTimeUpdate { get; private set; }

        public event Action OnNodeChange;

        public void AddValue<TValue>(TValue value)
        {
            throw new NotImplementedException();
        }

        public void RemoveValue<TValue>(TValue value)
        {
            throw new NotImplementedException();
        }

        public void ShowInfo()
        {
            throw new NotImplementedException();
        }

        public string UpdateValue(string value)
        {
            throw new NotImplementedException();
        }
    }
}
