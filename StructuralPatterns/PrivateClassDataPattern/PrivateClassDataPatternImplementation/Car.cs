namespace PrivateClassDataPatternImplementation
{
    public class Car
    {
        private CarSpecifications _carSpecifications;

        public Car(int cylinders, int horsepower, int torque)
        {
            _carSpecifications = new CarSpecifications(cylinders, horsepower, torque);
        }

        public string GetAllSpecifications() => "This car has " + _carSpecifications.Cylinders.ToString() + " cylinders, " + _carSpecifications.Horsepower.ToString() + " horsepower, and " + _carSpecifications.Torque.ToString() + " pounds of torque.";
    }
}
