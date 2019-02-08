using System;

namespace FactoryPatternImplementation
{
    public class VehicleFactory
    {
        public IVehicle CreateVehicle(VehicleType vehicleType)
        {
            switch(vehicleType)
            {
                case VehicleType.Convertible:
                    return new Convertible();
                case VehicleType.Sedan:
                    return new Sedan();
                case VehicleType.SUV:
                    return new SUV();
                default:
                    throw new Exception("Invalid Vehicle Type");
            }
        }
    }
}
