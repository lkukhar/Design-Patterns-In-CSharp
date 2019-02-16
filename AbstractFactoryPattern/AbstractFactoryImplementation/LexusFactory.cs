namespace AbstractFactoryImplementation
{
    public class LexusFactory : AbstractFactory
    {
        public override Car CreateCar() => new LexusCar();
        public override SUV CreateSUV() => new LexusSUV();
    }
}
