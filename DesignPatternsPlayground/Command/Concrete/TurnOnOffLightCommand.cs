using DesignPatternsPlayground.Command.Abstract;
using DesignPatternsPlayground.Command.Interfaces;

namespace DesignPatternsPlayground.Command.Concrete
{
    public class TurnOffLightCommand : ICommand
    {
        Light _light;

        public TurnOffLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }
}
