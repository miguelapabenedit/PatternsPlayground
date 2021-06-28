using DesignPatternsPlayground.FactoryMethod.Abstract;

namespace DesignPatternsPlayground.FactoryMethod.Interfaces
{
    public interface IFactory<T> where T : InstrumentForm
    {
        IInstrument CreateInstrument(T instrumentData);
    }
}
