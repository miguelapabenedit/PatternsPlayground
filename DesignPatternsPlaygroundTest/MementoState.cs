using DesignPatternsPlayground.Momento.Concrete;
using NUnit.Framework;

namespace DesignPatternsPlaygroundTest
{
  
    public class MementoState
    {
        [Test]
        public void CarMemento()
        {
            var carOriginator = new CarOriginator();
            var car = new Car("ratata","ratatatata",1230);
            var carCareTaker = new CarCareTaker();

            carOriginator.Set(car);
            carCareTaker.AddMemento(carOriginator.StoreInMemento());
            var car2 = carOriginator.RestoreCar(carCareTaker.GetMemento(0));
            Assert.That(car  == car2 );
        }
    }
}
