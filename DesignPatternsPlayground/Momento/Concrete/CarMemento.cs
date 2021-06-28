using DesignPatternsPlayground.Momento.Abstract;

namespace DesignPatternsPlayground.Momento.Concrete
{
    public class CarMemento : Memento<Car>
    {

        public CarMemento(Car state):base(state)
        {
        }
    }
}
