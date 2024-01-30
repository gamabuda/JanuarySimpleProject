using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuarySimpleProject.Core
{
    public class CustomComparer<TItem> : IComparer<TItem>
    {
        private readonly Comparison<TItem> _comparison;

        public CustomComparer(Comparison<TItem> comparison)
        {
            _comparison = comparison;
        }

        public int Compare(TItem x, TItem y)
        {
            return _comparison(x, y);
        }
    }
}
