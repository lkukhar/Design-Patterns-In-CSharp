namespace DecoratorPatternImplementation
{
    public class RedCarDecorator : CarDecorator
    {
        public RedCarDecorator(ICar car) : base(car) { }

        public override string Drive()
        {
            SetRedColor();
            return _car.Drive();
        }

        private void SetRedColor()
        {
            _car.Color = "Red";
        }
    }
}
