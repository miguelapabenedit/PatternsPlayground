namespace DesignPatternsPlayground.FactoryMethod.Abstract
{
    public abstract class InstrumentForm
    {
        public readonly string Model;
                                         
        public InstrumentForm(string model)
        {
            Model = model;
        }
    }
}
