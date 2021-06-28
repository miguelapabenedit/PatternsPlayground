using DesignPatternsPlayground.Decorator.Concrete;
using NUnit.Framework;

namespace DesignPatternsPlaygroundTest
{
    public class DecoratorTest
    {
        [Test]
        public void Decorator_AddExtendedDecrotaro_ReturnsDecoratedProfile()
        {
            var simpleProfile = new SimpleProfileData("Miguel","Benedit");
            var extendedProfile = new ExtendedProfileData(simpleProfile, "mbenedit@gmail.com", "1162051451", "NicolasAvellaneda393");

            var result = extendedProfile.GetProfileInfo();

            Assert.IsTrue(result.Contains("1162051451"));
        }
    }
}
