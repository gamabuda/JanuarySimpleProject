using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS.Core.Interfaces
{
    public interface IMagicHandler : IHealthHandler, IAttackHandler
    {
        public int MDefense { get; set; }

    }
}
