using DesignPatternsPlayground.Bridge.Interface;
using System;

namespace DesignPatternsPlayground.Bridge.Concrete
{
    public class PackageHandlerBridge : IPackageHandlerBridge
    {
        private IPackageHandler _handler;

        public PackageHandlerBridge(IPackageHandler handler)
        {
            _handler = handler;
        }

        public void CallDeliverPackageHandler()
        {
            _handler.DeliverPackage();
        }

        public void CallPickPackageHandler()
        {
            _handler.PickPackage();
        }

        public void CallSendPackageHandler()
        {
            _handler.SendPackage();
        }

        public void SetPackageHandler(IPackageHandler handler)
        {
            _handler = handler;
        }
    }
}
