using DesignPatternsPlayground.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Command.Concrete
{
    public class LightManager : IInvoker
    {
        private ICommand _currentCommand;
        public void Invoke()
        {
            _currentCommand.Execute();
        }

        public void SetCommand(ICommand command)
        {
            _currentCommand = command;
        }
    }
}
