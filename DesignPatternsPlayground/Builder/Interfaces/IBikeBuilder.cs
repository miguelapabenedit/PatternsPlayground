using DesignPatternsPlayground.Builder.Abstract;

namespace DesignPatternsPlayground.Builder.Interfaces
{
    public interface IBikeBuilder
    {
        void Reset();
        void SetHandlebar(Handlebar handle);
        void SetWheels(Wheel wheel);
        void SetFrame(Frame frame);
        Bike GetBike();
    }
}
