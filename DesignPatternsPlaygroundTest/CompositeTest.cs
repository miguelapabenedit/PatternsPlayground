using DesignPatternsPlayground.Composite.Concrete;
using NUnit.Framework;

namespace DesignPatternsPlaygroundTest
{
    public class CompositeTest
    {
        [Test]
        public void Composite_Soldier_HierarchieTest()
        {
            var generalComponent = new General();
            var soldierComponent = new Soldier();
            var soldierComponent2 = new Soldier();
            var soldierComponent3 = new Soldier();
            var weapondLeaf = new Weapond();

            soldierComponent.Add(weapondLeaf);
            soldierComponent2.Add(weapondLeaf);
            soldierComponent3.Add(weapondLeaf);

            generalComponent.Add(soldierComponent);
            generalComponent.Add(soldierComponent2);
            generalComponent.Add(soldierComponent3);

            var reportResult = generalComponent.Report();

            Assert.That(reportResult.Contains("Weapond"));
        }
    }
}
