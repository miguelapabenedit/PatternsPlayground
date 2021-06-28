using DesignPatternsPlayground.Bridge.Interface;
using System;

namespace DesignPatternsPlayground.Bridge.Concrete
{
    public class EarthPackageHandler : IPackageHandler
    {
        public void DeliverPackage()
        {
            Console.WriteLine("The package is been deliver by Earth");
        }

        public void PickPackage()
        {
            Console.WriteLine("The package is been picked by Earth");
        }

        public void SendPackage()
        {
            Console.WriteLine("The package is been Send by Earth");
        }
    }
}
