using DesignPatternsPlayground.Adapter.Concrete;
using DesignPatternsPlayground.Adapter.Interfaces;
using NUnit.Framework;

namespace DesignPatternsPlaygroundTest
{

    public class AdapterTest
    {

        [Test]
        public void MicroUsbToLighting_SetAdapter()
        {
            Android androidPhone = new();
            Iphone iphone = new();
            
            void RechargeAndroid(IMicroUsbPhone android)
            {
                android.UseMicroUsb();
                android.Recharge();
            }

            RechargeAndroid(new MicroUsbToLighting(iphone));
        }
    }
}
