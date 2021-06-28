using DesignPatternsPlayground.FactoryMethod.Abstract;

namespace DesignPatternsPlayground.FactoryMethod.Concrete
{
    public class Drums : Percussion
    {
        public Drums(string model, int numberOfBodies) : base(model, numberOfBodies)
        {
        }
    }
}
