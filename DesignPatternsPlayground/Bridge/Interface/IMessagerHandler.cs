using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Bridge.Interface
{
    public interface IPackageHandler
    {
        void PickPackage();
        void SendPackage();
        void DeliverPackage();
    }
}
