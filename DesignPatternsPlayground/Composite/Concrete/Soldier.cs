using DesignPatternsPlayground.Composite.Abstract;
using System;
using System.Collections.Generic;

namespace DesignPatternsPlayground.Composite.Concrete
{
    public class Soldier : Component
    {
        public List<Component> _tools = new();

        public override string Report()
        {
            var soldierReport = "Soldier(Tools: {0})";
            var soldierTools = "";

            foreach (var tool in _tools)
            {
                soldierTools += string.Format(", {0} ",tool.Report());    
            }

            return string.Format(soldierReport, soldierTools);
        }

        public override void Add(Component component)
        {
            _tools.Add(component);
        }

        public override void Remove(Component component)
        {
            _tools.Remove(component);
        }
    }
}
