using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayground.Momento.Concrete
{
    public class Car
    {
        private string _model;
        private string _Owner;
        private int _price;

        public Car(string model, string owner, int price)
        {
            _model = model;
            _Owner = owner;
            _price = price;
        }

        public void Details()
        {
            Console.WriteLine("Model:{0}, Owner:{1}, Price{2}", _model, _Owner, _price);
        }
    }
}
