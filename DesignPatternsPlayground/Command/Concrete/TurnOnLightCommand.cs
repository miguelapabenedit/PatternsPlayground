using DesignPatternsPlayground.Command.Abstract;
using DesignPatternsPlayground.Command.Interfaces;

namespace DesignPatternsPlayground.Command.Concrete
{
    public class TurnOnLightCommand : ICommand
    {
        Light _light;

        public TurnOnLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }
}
