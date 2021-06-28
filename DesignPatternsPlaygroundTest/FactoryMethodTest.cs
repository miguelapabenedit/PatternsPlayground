using DesignPatternsPlayground.FactoryMethod.Concrete;
using DesignPatternsPlayground.FactoryMethod;
using NUnit.Framework;
using System;

namespace DesignPatternsPlaygroundTest
{
    public class FactoryMethodTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ProgramFactoryIntegration_GetPercussionForm_ReturnsDrums()
        {
            var expected = new Drums("brumbrum", 3);
            var form = new PercussionForm(3, PercussionsTypes.Drums, "brumbrum");
            var programFactory = new ProgramFactory();
            
            var instrumentResult = programFactory.GetInstrument(form, InstrumentTypes.Percussion);

           Assert.AreEqual(instrumentResult.GetType(), expected.GetType());
        }

        [Test]
        public void ProgramFactoryIntegration_GetPercussionFormWithInvalidType_ReturnsArgumentException()
        {
            var form = new PercussionForm(3, PercussionsTypes.Drums, "brumbrum");
            var programFactory = new ProgramFactory();

            Assert.That(() => programFactory.GetInstrument(form, InstrumentTypes.Stringed),Throws.TypeOf<ArgumentException>());
        }
    }
}