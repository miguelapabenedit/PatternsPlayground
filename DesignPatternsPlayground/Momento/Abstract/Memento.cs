namespace DesignPatternsPlayground.Momento.Abstract
{
    public abstract class Memento<T>
    {
        private readonly T _state;

        public Memento(T state)
        {
            _state = state;
        }

        public T Restore() => _state;

    }
}
