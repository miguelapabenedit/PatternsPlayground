namespace DesignPatternsPlayground.Bridge.Interface
{
    public interface IPackageHandlerBridge
    {
        void SetPackageHandler(IPackageHandler handler);
        void CallPickPackageHandler();
        void CallSendPackageHandler();
        void CallDeliverPackageHandler();
    }
}
