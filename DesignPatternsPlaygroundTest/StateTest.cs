using DesignPatternsPlayground.State.Concrete;
using NUnit.Framework;

namespace DesignPatternsPlaygroundTest
{
    public class StateTest
    {
        [Test]
        public void State_ChangeStateToAandB_ReturnsPropperStrings()
        {
            var testContext = new Context(new HandlerStateB());
            var resultA = "StateHandler A -HandlerA ";
            var resultB = "StateHandler B -HandlerB ";
            var resultC = "StateHandler A -HandlerA ";


            testContext.TransitionTo(new HandlerStateA());
            var resultHandlerA = testContext.HandleRequestA();
            testContext.TransitionTo(new HandlerStateB());
            var resultHandlerB = testContext.HandleRequestB();
            var resultHandlerA_2 = testContext.HandleRequestA();

            Assert.AreEqual(resultHandlerA, resultA);
            Assert.AreEqual(resultHandlerB, resultB);
            Assert.AreEqual(resultHandlerA_2, resultC);
        }

    }
}
