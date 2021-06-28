
using DesignPatternsPlayground.State.Concrete;

namespace DesignPatternsPlayground.State.Abstract
{
    public abstract class State
    {
        protected Context _context;
        internal void SetContext(Context context)
        {
            _context = context;
        }

        public abstract string HandleA();

        public abstract string HandleB();
    }
}
