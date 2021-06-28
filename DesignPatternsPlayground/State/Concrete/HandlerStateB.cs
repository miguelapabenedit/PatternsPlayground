namespace DesignPatternsPlayground.State.Concrete
{
    public class HandlerStateB : Abstract.State
    {
        public override string HandleA()
        {
            return "StateHandler B -HandlerA ";
        }

        public override string HandleB()
        {
            this._context.TransitionTo(new HandlerStateA());
            return "StateHandler B -HandlerB ";
        }
    }
}
