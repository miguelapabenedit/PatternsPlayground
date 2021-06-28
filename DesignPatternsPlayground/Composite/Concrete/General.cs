using DesignPatternsPlayground.Composite.Abstract;
using System;
using System.Collections.Generic;

namespace DesignPatternsPlayground.Composite.Concrete
{
    public class General : Component
    {
        readonly List<Component> _children = new();
        
        public override string Report()
        {
            var generalReport = "General(Soldiers:{0})";
            var soldiersReport = "";

            foreach (var child in _children)
            {
                soldiersReport += string.Format(", {0}", child.Report());
            }

            return string.Format(generalReport, soldiersReport);

        }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }
    }
}
