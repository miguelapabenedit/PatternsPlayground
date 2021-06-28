using DesignPatternsPlayground.Command.Abstract;
using System;

namespace DesignPatternsPlayground.Command.Concrete
{
    public class TinyLight : Light
    {
        public override string TurnOff()
        {
            return "The Tiny light is turned off";
        }

        public override string TurnOn()
        {
            return "The Tiny light is turned on";
        }
    }
}
