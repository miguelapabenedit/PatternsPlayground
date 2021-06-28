using DesignPatternsPlayground.FactoryMethod.Abstract;

namespace DesignPatternsPlayground.FactoryMethod.Concrete
{
    public class Guitar : Stringed
    {
        public Guitar(string model, int numberOfStrings) : base(model, numberOfStrings)
        {

        }
    }
}
