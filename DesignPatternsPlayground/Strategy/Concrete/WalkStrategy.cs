using DesignPatternsPlayground.Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Strategy.Concrete
{
    public class WalkStrategy : IRoutStrategy
    {
        public string MapRoute()
        {
            return "Walking";
        }
    }
}
