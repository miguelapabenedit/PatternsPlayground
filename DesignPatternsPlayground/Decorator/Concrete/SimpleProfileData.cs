using DesignPatternsPlayground.Decorator.Interfaces;
using System;

namespace DesignPatternsPlayground.Decorator.Concrete
{
   public class SimpleProfileData : IProfileData
    {
        private string _name;
        private string _lastName;

        public SimpleProfileData(string name, string lastName)
        {
            _lastName = lastName;
            _name = name;
        }
        public string GetProfileInfo()
        {
            return string.Format("Name:{0}, LastName:{1}", _name, _lastName);
        }
    }
}
