using DesignPatternsPlayground.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Adapter.Concrete
{
    public class MicroUsbToLighting : IMicroUsbPhone
    {
        private readonly ILightingPhone lightingPhone;

        public MicroUsbToLighting(ILightingPhone lightingPhone)
        {
            this.lightingPhone = lightingPhone;
        }

        public void Recharge()
        {
            lightingPhone.Recharge();
        }

        public void UseMicroUsb()
        {
            lightingPhone.UseLighting();
        }
    }
}
