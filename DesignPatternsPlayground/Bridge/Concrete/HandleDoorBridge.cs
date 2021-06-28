using DesignPatternsPlayground.Bridge.Interface;

namespace DesignPatternsPlayground.Bridge.Concrete
{
    public class HandleDoorBridge : IHandleDoorBridge
    {
        private readonly IHandleDoor _handleDoor;
        public HandleDoorBridge(IHandleDoor handler)
        {
            _handleDoor = handler;
        }

        public void CallCloseDoor()
        {
            _handleDoor.CloseDoor();
        }

        public void CallOpenDoor()
        {
            _handleDoor.OpenDoor();
        }
    }
}
