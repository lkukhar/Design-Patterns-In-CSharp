namespace DecoratorPatternImplementation
{
    public class Lexus : ICar
    {
        public string Color { get; set; }
        public string Drive() => "Lexus is being driven.";
    }
}
