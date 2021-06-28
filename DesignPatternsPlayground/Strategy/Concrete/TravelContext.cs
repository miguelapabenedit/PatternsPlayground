using DesignPatternsPlayground.Strategy.Interface;

namespace DesignPatternsPlayground.Strategy.Concrete
{
    public class TravelContext
    {
        private IRoutStrategy _strategy;

        public TravelContext(IRoutStrategy strategy)
        {
            SetStrategy(strategy);
        }

        public void SetStrategy(IRoutStrategy strategy)
        {
            _strategy = strategy;
        }

        public string ExcecuteMapRout()
        {
            return _strategy.MapRoute();
        }
    }
}
