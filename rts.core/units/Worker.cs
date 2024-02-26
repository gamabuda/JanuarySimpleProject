using rts.core.interfaces;
namespace rts.core.units
{
    public class Worker : IHealthHandler
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
    }
}
