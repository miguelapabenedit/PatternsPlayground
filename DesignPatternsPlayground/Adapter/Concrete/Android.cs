using DesignPatternsPlayground.Adapter.Interfaces;
using System;

namespace DesignPatternsPlayground.Adapter.Concrete
{
    public class Android:IMicroUsbPhone
    {
        private bool conector = false;
        public void Recharge()
        {
            if (conector)
            {
                Console.WriteLine("Recharge Started");
                Console.WriteLine("Recharge Finished");
            }
            else
            {
                Console.WriteLine("Conect the charger first");
            }
        }

        public void UseMicroUsb()
        {
            conector = true;
            Console.WriteLine("Using Lighting charge");
        }
    }
}
