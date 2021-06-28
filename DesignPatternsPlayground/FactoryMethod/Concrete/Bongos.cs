using DesignPatternsPlayground.FactoryMethod.Abstract;

namespace DesignPatternsPlayground.FactoryMethod.Concrete
{
    public class Bongos : Percussion
    {
        public Bongos(string model, int numberOfBodies) : base(model, numberOfBodies)
        {
        }
    }
}
