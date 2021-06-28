using DesignPatternsPlayground.Builder.Concrete;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlaygroundTest
{
    public class BuilderTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Builder_RequestCountryAndCityBike_ReturnsBikes()
        {
            var montainBuilder = new MontainBikeBuilder();
            var playeraBuilder = new PlayeraBikeBuilder();
            var director = new Director(montainBuilder);

            var cityMontainBike = director.MakeCityBike();
            director.ChangeBuilder(playeraBuilder);
            var cityPlayeraBike = director.MakeCountryBike();

            Assert.True(cityMontainBike.Frame.GetTypeOfFrame() == "The type of frame is CityFrame");
            Assert.True(cityPlayeraBike.Frame.GetTypeOfFrame() == "The type of frame is CountryFrame");
        }
    }
}
