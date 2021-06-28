using DesignPatternsPlayground.FactoryMethod.Abstract;

namespace DesignPatternsPlayground.FactoryMethod.Concrete
{
    public class PercussionForm : InstrumentForm
    {
        public readonly int NumberOfBodies;
        public readonly PercussionsTypes PercussionType;
        public PercussionForm(int numberOfBodies, PercussionsTypes percussionTypes, string model) : base(model)
        {
            NumberOfBodies = numberOfBodies;
            PercussionType = percussionTypes;
        }
    }
}
