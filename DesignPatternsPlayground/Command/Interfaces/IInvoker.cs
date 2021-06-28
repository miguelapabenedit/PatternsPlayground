namespace DesignPatternsPlayground.Command.Interfaces
{
    public interface IInvoker
    {
        void SetCommand(ICommand command);

        void Invoke();
    }
}
