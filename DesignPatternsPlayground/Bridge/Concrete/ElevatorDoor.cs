using DesignPatternsPlayground.Bridge.Interface;
using System;

namespace DesignPatternsPlayground.Bridge.Concrete
{
    public class ElevatorDoor : IHandleDoor
    {
        public void CloseDoor()
        {
            Console.WriteLine("Closing Elevator Door");
        }

        public void OpenDoor()
        {
            Console.WriteLine("Opening Elevator Door");
        }
    }
}
