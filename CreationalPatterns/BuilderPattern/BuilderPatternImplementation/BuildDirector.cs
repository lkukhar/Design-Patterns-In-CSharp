namespace BuilderPatternImplementation
{
    public class BuildDirector
    {
        private CarBuilder _carBuilder;

        public Car GetCar() => _carBuilder.GetCar();
        
        public void SetCarBuilder(CarBuilder carBuilder)
        {
            _carBuilder = carBuilder;
        }

        public void ConstructCar()
        {
            _carBuilder.CreateNewCar();
            _carBuilder.BuildDoors();
            _carBuilder.BuildRows();
            _carBuilder.BuildSeats();
        }

    }
}
