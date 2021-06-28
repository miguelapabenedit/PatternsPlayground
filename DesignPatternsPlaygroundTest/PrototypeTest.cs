using DesignPatternsPlayground.Prototype.Concrete;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlaygroundTest
{
    public class PrototypeTest
    {
        [Test]
        public void PrototypeIntegration_CloneRectangleAndChangeLenght_ReturnsCloneAndAllIsEqualExcelptLenght()
        {
            var original = new Rectangle(412,222,2,12);

             var copy = (Rectangle)original.Clone();

            copy.Lenght = 12;

            Assert.That(original.Lenght == 412);
            Assert.That(copy.Lenght == 12);
            Assert.That(copy.Width == original.Width);
        }

        [Test]
        public void Program()
        {
            //DICCIONARIO PARA GUARDAR las plantillas
            //funcion guardar una plantilla
            //funcion para obtener una plantilla en base al nombre
            
        }
    }
}
