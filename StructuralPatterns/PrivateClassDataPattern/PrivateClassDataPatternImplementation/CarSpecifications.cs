namespace PrivateClassDataPatternImplementation
{
    public class CarSpecifications
    {
        public int Cylinders { get; }
        public int Horsepower { get; }
        public int Torque { get; }

        public CarSpecifications(int cyclinders, int horsepower, int torque)
        {
            Cylinders = cyclinders;
            Horsepower = horsepower;
            Torque = torque;
        }
    }
}
