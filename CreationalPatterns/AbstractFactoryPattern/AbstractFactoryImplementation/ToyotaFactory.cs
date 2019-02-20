namespace AbstractFactoryImplementation
{
    public class ToyotaFactory : AbstractFactory
    {
        public override Car CreateCar() => new ToyotaCar();
        public override SUV CreateSUV() => new ToyotaSUV();
    }
}
