using System.Collections.Generic;

namespace DesignPatternsPlayground.Momento.Abstract
{
    public abstract class CareTaker<T>
    {
        List<Memento<T>> _savedStates = new();

        public void AddMemento(Memento<T> m) {
            _savedStates.Add(m);
        }

        public Memento<T> GetMemento(int index)
        {
            return _savedStates[index];
        }
    }
}
