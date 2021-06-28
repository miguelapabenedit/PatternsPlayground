using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Prototype.Interfaces
{
    public interface IPlantilla<T> where T: class
    {
        T Clone();
    }
}
