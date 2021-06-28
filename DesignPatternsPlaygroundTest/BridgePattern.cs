using DesignPatternsPlayground.Bridge.Concrete;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlaygroundTest
{
    public class BridgePattern
    {
        [Test]
        public void Test_Bridge()
        {
            var elevatorDoor = new ElevatorDoor();
            var trainDoor = new TrainDoor();

            var electorHandlerBride = new HandleDoorBridge(elevatorDoor);
            var trainHandlerBride = new HandleDoorBridge(trainDoor);

            electorHandlerBride.CallOpenDoor();
            electorHandlerBride.CallCloseDoor();

            trainHandlerBride.CallOpenDoor();
            trainHandlerBride.CallCloseDoor();

            Assert.That(1 == 1);
        }
    }
}
