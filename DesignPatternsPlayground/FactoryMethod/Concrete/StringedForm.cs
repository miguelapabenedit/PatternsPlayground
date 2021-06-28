using DesignPatternsPlayground.FactoryMethod.Abstract;

namespace DesignPatternsPlayground.FactoryMethod.Concrete
{
    public class StringedForm:InstrumentForm
    {
        public readonly int NumberOfBodies;
        public readonly StringedTypes StringedType;
        public StringedForm(int numberOfBodies, StringedTypes stringedTypes, string model) : base(model)
        {
            NumberOfBodies = numberOfBodies;
            StringedType = stringedTypes;
        }
    }
}
