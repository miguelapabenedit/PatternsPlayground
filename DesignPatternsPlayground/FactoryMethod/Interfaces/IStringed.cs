namespace DesignPatternsPlayground.FactoryMethod.Interfaces
{
    public interface IStringed : IInstrument
    {
        int NumberOfStrings { get; set; }

        void PrintStrings();
    }
}
