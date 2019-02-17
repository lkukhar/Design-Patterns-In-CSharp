namespace PrototypePatternImplementation
{
    public class Lexus : ICar
    {
        public ICar Clone() => new Lexus();
    }
}
