namespace DesignPatternsPlayground.State.Concrete
{
    public class HandlerStateA : Abstract.State
    {
        public override string HandleA()
        {
            return "StateHandler A -HandlerA ";
        }

        public override string HandleB()
        {
            this._context.TransitionTo(new HandlerStateA());
            return "StateHandler A -HandlerB ";
        }
    }
}
