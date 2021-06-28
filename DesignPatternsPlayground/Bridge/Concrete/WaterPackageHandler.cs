using DesignPatternsPlayground.Bridge.Interface;
using System;

namespace DesignPatternsPlayground.Bridge.Concrete
{
    public class WaterPackageHandler : IPackageHandler
    {
        public void DeliverPackage()
        {
            Console.WriteLine("The package is been deliver by Water");
        }

        public void PickPackage()
        {
            Console.WriteLine("The package is been picked by Water");
        }

        public void SendPackage()
        {
            Console.WriteLine("The package is been Send by Water");
        }
    }
}
