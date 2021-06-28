using DesignPatternsPlayground.FactoryMethod.Interfaces;
using System;

namespace DesignPatternsPlayground.FactoryMethod.Concrete
{
    public class PercussionFactory : IFactory<PercussionForm>
    {
        public IInstrument CreateInstrument(PercussionForm instrumentData)
        {
            return instrumentData.PercussionType switch
            {
                PercussionsTypes.Bongos => new Bongos(instrumentData.Model, instrumentData.NumberOfBodies),
                PercussionsTypes.Drums => new Drums(instrumentData.Model, instrumentData.NumberOfBodies),
                _ => throw new NotImplementedException()
            };
        }
    }
}
