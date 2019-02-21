namespace BuilderPatternImplementation
{
    public abstract class CarBuilder
    {
        protected Car car;

        public Car GetCar() => car;

        public void CreateNewCar()
        {
            car = new Car();
        }

        public abstract void BuildSeats();
        public abstract void BuildDoors();
        public abstract void BuildRows();
    }
}
