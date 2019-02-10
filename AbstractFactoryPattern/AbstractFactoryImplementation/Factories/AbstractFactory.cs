using System;

namespace AbstractFactoryImplementation.Factories
{
    public abstract class AbstractFactory
    {
        public static AbstractFactory GetFactory(VehicleType vehicleType)
        {
            switch(vehicleType)
            {
                case VehicleType.Motorcycle:
                    return new MotorcyclesFactory();
                case VehicleType.Car:
                    return new CarFactory();
                default:
                    throw new Exception("The vehicle type is invalid.");
            }
        }
    }
}
