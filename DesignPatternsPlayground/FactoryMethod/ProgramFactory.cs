using DesignPatternsPlayground.FactoryMethod.Abstract;
using DesignPatternsPlayground.FactoryMethod.Concrete;
using DesignPatternsPlayground.FactoryMethod.Interfaces;
using System;

namespace DesignPatternsPlayground.FactoryMethod
{
    public class ProgramFactory
    {
        public IInstrument GetInstrument(InstrumentForm instrumentData, InstrumentTypes type)
        {
            var percussionFactory = new PercussionFactory();
            var stringedFactory = new StringedFactory();

            return type switch
            {
                InstrumentTypes.Percussion => percussionFactory.CreateInstrument(ValidateForm<PercussionForm>(instrumentData)),
                InstrumentTypes.Stringed => stringedFactory.CreateInstrument(ValidateForm<StringedForm>(instrumentData)),
                _ => throw new NotImplementedException()
            };
        }

        private T ValidateForm<T>(InstrumentForm form) where T:InstrumentForm
        {
            try
            {
                return (T)form;
            }
            catch
            {
                throw new ArgumentException();
            }
        }
    }
}
