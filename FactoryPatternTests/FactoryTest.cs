using FactoryPatternImplementation;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FactoryPatternTests
{
    public class FactoryTest
    {
        private VehicleFactory _vehicleFactory = new VehicleFactory();

        [Fact]
        public void Convertible_Test()
        {
            IVehicle convertible = _vehicleFactory.CreateVehicle(VehicleType.Convertible);

            Assert.IsType<Convertible>(convertible);
            Assert.IsAssignableFrom<IVehicle>(convertible);
            Assert.Equal("Convertible turned on!", convertible.TurnOn());
            Assert.Equal("Convertible turned off!", convertible.TurnOff());
        }

        [Fact]
        public void Sedan_Test()
        {
            IVehicle sedan = _vehicleFactory.CreateVehicle(VehicleType.Sedan);

            Assert.IsType<Sedan>(sedan);
            Assert.IsAssignableFrom<IVehicle>(sedan);
            Assert.Equal("Sedan turned on!", sedan.TurnOn());
            Assert.Equal("Sedan turned off!", sedan.TurnOff());
        }

        [Fact]
        public void SUV_Test()
        {
            IVehicle suv = _vehicleFactory.CreateVehicle(VehicleType.SUV);

            Assert.IsType<SUV>(suv);
            Assert.IsAssignableFrom<IVehicle>(suv);
            Assert.Equal("SUV turned on!", suv.TurnOn());
            Assert.Equal("SUV turned off!", suv.TurnOff());
        }
    }
}
