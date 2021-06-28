using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Command.Abstract
{
    public abstract class Light
    {
        public abstract string TurnOn();
        public abstract string TurnOff();
    }
}
