using DesignPatternsPlayground.Strategy.Interface;

namespace DesignPatternsPlayground.Strategy.Concrete
{
    public class TransportStrategy : IRoutStrategy
    {
        public string MapRoute()
        {
            return "Driving";
        }
    }
}