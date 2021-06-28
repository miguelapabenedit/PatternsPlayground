using DesignPatternsPlayground.FactoryMethod.Interfaces;
using System;

namespace DesignPatternsPlayground.FactoryMethod.Concrete
{
    public class StringedFactory : IFactory<StringedForm>
    {
        public IInstrument CreateInstrument(StringedForm instrumentData)
        {
            return instrumentData.StringedType switch
            {
                StringedTypes.Guitar => new Guitar(instrumentData.Model, instrumentData.NumberOfBodies),
                StringedTypes.Ukelele => new Ukelele(instrumentData.Model, instrumentData.NumberOfBodies),
                _ => throw new NotImplementedException()
            };
        }
    }
}
