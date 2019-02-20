using System;

namespace AbstractFactoryImplementation
{
    public abstract class AbstractFactory
    {
        public static AbstractFactory CreateFactory(BrandType brandType)
        {
            switch(brandType)
            {
                case BrandType.Lexus:
                    return new LexusFactory();
                case BrandType.Toyota:
                    return new ToyotaFactory();
                default:
                    throw new Exception("Invalid Brand Type");
            }
        }
        public abstract Car CreateCar();
        public abstract SUV CreateSUV();
    }
}
