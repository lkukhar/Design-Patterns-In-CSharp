using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternImplementation
{
    public class BuildDirector
    {
        private CarBuilder _carBuilder;

        public Car GetCar() => _carBuilder.GetCar();
        
        public void SetCarBuilder(CarBuilder carBuilder)
        {
            _carBuilder = carBuilder;
        }

        public void ConstructCar()
        {
            _carBuilder.BuildDoors();
            _carBuilder.BuildRows();
            _carBuilder.BuildSeats();
        }

    }
}
