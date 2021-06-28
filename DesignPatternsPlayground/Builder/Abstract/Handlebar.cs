using System;

namespace DesignPatternsPlayground.Builder.Abstract
{
    public abstract class Handlebar 
    {
        private readonly string type;

        public Handlebar(string type)
        {
            this.type = type;
        }

        public string GetTypeOfHandlebar()
        {
            return $"The type of handlebar is {type}";
        }
    }
}
