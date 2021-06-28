using DesignPatternsPlayground.Strategy.Concrete;
using NUnit.Framework;

namespace DesignPatternsPlaygroundTest
{
    public class StrategyTest
    {
        [Test]
        public void Strategy_WalkingAndDriving_ReturnMap()
        {
            var walkStrategy = new WalkStrategy();
            var transportStrategy = new TransportStrategy();
            var travelContext = new TravelContext(walkStrategy);

            var result = travelContext.ExcecuteMapRout();
            travelContext.SetStrategy(transportStrategy);
            var result_2 = travelContext.ExcecuteMapRout();

            Assert.AreEqual(result_2, "Driving");
            Assert.AreEqual(result, "Walking");
        }
    }
}
