using DesignPatternsPlayground.Bridge.Interface;
using System;

namespace DesignPatternsPlayground.Bridge.Concrete
{
    public class AirPackageHandler : IPackageHandler
    {
        public void DeliverPackage()
        {
            Console.WriteLine("The package is been deliver by Air");
        }

        public void PickPackage()
        {
            Console.WriteLine("The package is been picked by Air");
        }

        public void SendPackage()
        {
            Console.WriteLine("The package is been Send by Air");
        }
    }
}
