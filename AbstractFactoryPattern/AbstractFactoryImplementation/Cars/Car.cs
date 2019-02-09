namespace AbstractFactoryImplementation.Cars
{
    public abstract class Car
    {
        protected const int NumberOfWheels = 4;

        protected abstract string DriveCar();
    }
}
