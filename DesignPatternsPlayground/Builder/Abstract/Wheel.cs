using System;

namespace DesignPatternsPlayground.Builder.Abstract
{
    public abstract class Wheel
    {
        private readonly string type;

        public Wheel(string type)
        {
            this.type = type;
        }

        public string GetWheelsType()
        {
            return $"The type of wheel is {type}";
        }
    }
}
