namespace DecoratorPatternImplementation
{
    public class BMW : ICar
    {
        public string Color { get; set; }
        public string Drive() => "BMW is being driven.";
    }
}
