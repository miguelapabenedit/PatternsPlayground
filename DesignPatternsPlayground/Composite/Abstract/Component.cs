using System;

namespace DesignPatternsPlayground.Composite.Abstract
{
    public abstract class Component
    {
        public abstract string Report();
        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
