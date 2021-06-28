using DesignPatternsPlayground.Builder.Abstract;
using DesignPatternsPlayground.Builder.Concrete.FrameType;
using DesignPatternsPlayground.Builder.Concrete.Handlebar;
using DesignPatternsPlayground.Builder.Concrete.WheelTypes;
using DesignPatternsPlayground.Builder.Interfaces;

namespace DesignPatternsPlayground.Builder.Concrete
{
    public class Director
    {
        IBikeBuilder builder;

        public Director(IBikeBuilder builder)
        {
            this.builder = builder;
        }

        public void ChangeBuilder(IBikeBuilder builder)
        {
            this.builder = builder;
        }

        public Bike MakeCityBike()
        {
            this.builder.Reset();
            this.builder.SetFrame(new CityFrame());
            this.builder.SetHandlebar(new CityHandlebar());
            this.builder.SetWheels(new CityWheel());
            return this.builder.GetBike();
        }

        public Bike MakeCountryBike()
        {
            this.builder.Reset();
            this.builder.SetFrame(new CountryFrame());
            this.builder.SetHandlebar(new CountryHandlebar());
            this.builder.SetWheels(new CountryWheel());
            return this.builder.GetBike();
        }
    }
}
