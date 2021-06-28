using DesignPatternsPlayground.FactoryMethod.Interfaces;
using System;

namespace DesignPatternsPlayground.FactoryMethod.Abstract
{
    public abstract class Stringed : IInstrument
    {
        private readonly string model;
        private readonly int numberOfStrings;
        
        public Stringed(string model, int numberOfStrings)
        {
            this.model = model;
            this.numberOfStrings = numberOfStrings;
        }

        public void Play()
        {
            Console.WriteLine("Im playing the Stringed ${0}", model);
        }

        public void PrintStrings()
        {
            Console.WriteLine("the ${0} has ${1} parts", model, numberOfStrings);
        }
    }
}
