using AbstractFactoryImplementation.Motorcycles;

namespace AbstractFactoryImplementation.Factories
{
    public class MotorcyclesFactory : AbstractFactory
    {
        public Motorcycle CreateMotorcycle(MotorcycleType motorcycleType)
        {
            switch(motorcycleType)
            {
                case MotorcycleType.Ducatti:
                    return new Ducatti();
                case MotorcycleType.Yamaha:
                    return new Yamaha();
                default:
                    throw new System.Exception("Motorcycle type is invalid.");
            }
        }
    }
}