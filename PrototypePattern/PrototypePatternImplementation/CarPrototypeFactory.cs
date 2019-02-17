using System.Collections.Generic;

namespace PrototypePatternImplementation
{
    public class CarPrototypeFactory
    {
        private static readonly Dictionary<CarType, ICar> prototypes = new Dictionary<CarType, ICar>()
        {
            { CarType.Lexus, new Lexus()},
            { CarType.Honda, new Honda()},
            { CarType.Toyota, new Toyota()}
        };

        public static ICar GetPrototype(CarType carType) => prototypes[carType].Clone();
    }
}
