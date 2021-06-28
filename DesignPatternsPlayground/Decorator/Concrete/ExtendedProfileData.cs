using DesignPatternsPlayground.Decorator.Interfaces;
using System;

namespace DesignPatternsPlayground.Decorator.Concrete
{
    public class ExtendedProfileData : ProfileDecorator
    {
        private string _email;
        private string _tell;
        private string _address;
        public ExtendedProfileData(IProfileData profileToBeDecorated,string email,string tell,string address) :base(profileToBeDecorated)
        {
            _email = email;
            _tell = tell;
            _address = address;
        }

        public override string GetProfileInfo()
        {
            return String.Format("{0} Email:{1} Tell:{2} Address:{3}", _wrapee.GetProfileInfo(), _email, _tell, _address);
        }
    }
}
