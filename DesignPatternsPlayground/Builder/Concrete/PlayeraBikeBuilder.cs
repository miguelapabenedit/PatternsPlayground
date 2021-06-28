using DesignPatternsPlayground.Builder.Abstract;
using DesignPatternsPlayground.Builder.BikeType;
using DesignPatternsPlayground.Builder.Interfaces;

namespace DesignPatternsPlayground.Builder.Concrete
{
    public class PlayeraBikeBuilder : IBikeBuilder
    {
        private PlayeraBike bike = new();

        public Bike GetBike()
        {
            return bike;
        }

        public void Reset()
        {
            bike = new();
        }

        public void SetFrame(Frame frame)
        {
            bike.Frame = frame;
        }

        public void SetHandlebar(Abstract.Handlebar handle)
        {
            bike.Handlebar = handle;
        }

        public void SetWheels(Wheel wheel)
        {
            bike.Wheel = wheel;
        }
    }
}
