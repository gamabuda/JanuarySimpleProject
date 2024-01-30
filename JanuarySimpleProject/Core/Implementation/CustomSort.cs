using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.Core.Implementation
{
    public class CustomSorting<TItem> : IComparer<TItem>
    {
        private readonly Comparison<TItem> _comparison;

        public CustomSorting(Comparison<TItem> comparison)
        {
            _comparison = comparison;
        }

        public int Compare(TItem x, TItem y)
        {
            return _comparison(x, y);
        }
    }
}
