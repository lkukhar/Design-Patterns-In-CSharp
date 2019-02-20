namespace PrototypePatternImplementation
{
    public class Toyota : ICar
    {
        public ICar Clone() => new Toyota();
    }
}
