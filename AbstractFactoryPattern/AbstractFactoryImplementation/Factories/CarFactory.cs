using AbstractFactoryImplementation.Cars;
using System;

namespace AbstractFactoryImplementation.Factories
{
    public class CarFactory : AbstractFactory
    {
        public Car CreateCar(CarType carType)
        {
            switch(carType)
            {
                case CarType.BMW:
                    return new BMW();
                case CarType.Lexus:
                    return new Lexus();
                default:
                    throw new Exception("Car type is invalid.");
            }
        }
    }
}