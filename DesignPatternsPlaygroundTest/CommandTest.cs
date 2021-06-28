using DesignPatternsPlayground.Command.Concrete;
using NUnit.Framework;

namespace DesignPatternsPlaygroundTest
{
    public class CommandTest
    {
        [Test]
        public void TurnOnCommand()
        {
            var commandManager = new LightManager();
            var tinyLight = new TinyLight();
            var turnOnCommand = new TurnOnLightCommand(tinyLight);
            var turnOffCommand = new TurnOffLightCommand(tinyLight);

            commandManager.SetCommand(turnOffCommand);
            commandManager.Invoke();
            commandManager.SetCommand(turnOnCommand);
            commandManager.Invoke();

        }
    }
}
