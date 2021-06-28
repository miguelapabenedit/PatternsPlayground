using DesignPatternsPlayground.Momento.Abstract;

namespace DesignPatternsPlayground.Momento.Concrete
{
    public class CarOriginator
    {
        private Car state;

        public void Set(Car newState)
        {
            state = newState;
        }

        public CarMemento StoreInMemento()
        {
            return new CarMemento(state);
        }

        public Car RestoreCar(Memento<Car> memento)
        {
            state = memento.Restore();
            return state;
        }
    }
}
