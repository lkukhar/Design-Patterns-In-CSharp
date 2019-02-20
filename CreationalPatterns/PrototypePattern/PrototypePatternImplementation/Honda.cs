namespace PrototypePatternImplementation
{
    public class Honda : ICar
    {
        public ICar Clone() => new Honda();
    }
}
