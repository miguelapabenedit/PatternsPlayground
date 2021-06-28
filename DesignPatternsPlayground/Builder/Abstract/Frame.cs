using System;

namespace DesignPatternsPlayground.Builder.Abstract
{
    public abstract class Frame
    {
        private readonly string type;

        public Frame(string type)
        {
            this.type = type;
        }

        public string GetTypeOfFrame() {
            return $"The type of frame is {type}";
        }
    }
}
