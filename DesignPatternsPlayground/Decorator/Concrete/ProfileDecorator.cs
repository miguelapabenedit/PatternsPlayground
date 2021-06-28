using DesignPatternsPlayground.Decorator.Interfaces;

namespace DesignPatternsPlayground.Decorator.Concrete
{
    public abstract class ProfileDecorator : IProfileData
    {
        protected IProfileData _wrapee;

        public ProfileDecorator(IProfileData profileToBeDecorated)
        {
            _wrapee = profileToBeDecorated;
        }

        public abstract string GetProfileInfo();
    }
}
