using DesignPatternsPlayground.FactoryMethod.Interfaces;
using System;

namespace DesignPatternsPlayground.FactoryMethod.Abstract
{
    public abstract class Percussion : IInstrument
    {
        private readonly string model;
        private readonly int numberOfBodies;

        public Percussion(string model, int numberOfBodies)
        {
            this.model = model;
            this.numberOfBodies = numberOfBodies;
        }

        public void Play()
        {
            Console.WriteLine("Im playing the Drum ${0}", model);
        }

        public void PrintBodies()
        {
            Console.WriteLine("the ${0} has ${1} parts", model, numberOfBodies);
        }
    }
}
