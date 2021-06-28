using DesignPatternsPlayground.Composite.Abstract;
using System;

namespace DesignPatternsPlayground.Composite.Concrete
{
    public class Weapond : Component
    {
        public override string Report()
        {
            return "Weapond";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
