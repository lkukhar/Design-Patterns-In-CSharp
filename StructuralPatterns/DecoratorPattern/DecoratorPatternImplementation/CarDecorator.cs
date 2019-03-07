namespace DecoratorPatternImplementation
{
    public abstract class CarDecorator : ICar
    {
        protected ICar _car;

        public CarDecorator(ICar car)
        {
            _car = car;
        }

        public string Color { get => _car.Color; set => _car.Color = value; }

        public abstract string Drive();
    }
}
