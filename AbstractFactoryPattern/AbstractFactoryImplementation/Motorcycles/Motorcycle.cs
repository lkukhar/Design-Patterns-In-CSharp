namespace AbstractFactoryImplementation.Motorcycles
{
    public abstract class Motorcycle
    {
        protected const int NumberOfWheels = 2;

        protected abstract string DriveMotorcycle();
    }
}
