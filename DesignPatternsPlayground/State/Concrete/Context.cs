namespace DesignPatternsPlayground.State.Concrete
{
    public class Context
    {
        private Abstract.State _state;

        public Context(Abstract.State state)
        {
            this.TransitionTo(state);
        }

        public void TransitionTo(Abstract.State newState)
        {
            _state = newState;
            _state.SetContext(this);
        }

        public string HandleRequestA()
        {
            return _state.HandleA();
        }

        public string HandleRequestB()
        {
           return _state.HandleB();
        }
    }
}
