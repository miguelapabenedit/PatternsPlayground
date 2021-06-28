using DesignPatternsPlayground.FactoryMethod.Abstract;

namespace DesignPatternsPlayground.FactoryMethod.Concrete
{
    public class Ukelele : Stringed
    {
        public Ukelele(string model, int numberOfStrings) : base(model, numberOfStrings)
        {
        }
    }
}
