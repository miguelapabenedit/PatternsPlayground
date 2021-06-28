using DesignPatternsPlayground.Prototype.Abstract;
using DesignPatternsPlayground.Prototype.Interfaces;
using System;

namespace DesignPatternsPlayground.Prototype.Concrete
{
    public class Factura : IPlantilla<Factura>
    {
        private string receptor;
        private int monto;
        private DateTime date;
        private FacturaType type;

        public Factura(string receptor, int monto, DateTime date, FacturaType type)
        {
            this.receptor = receptor;
            this.monto = monto;
            this.date = date;
            this.type = type;
        }
        public Factura(Factura source)
        {
            this.receptor = source.receptor;
            this.monto = source.monto;
            this.date = source.date;
            this.type = source.type;
        }

        public Factura Clone()
        {
            return new Factura(this);
        }
    }
}
