using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryImplementation
{
    public class LexusFactory : AbstractFactory
    {
        public override Car CreateCar() => new LexusCar();
        public override SUV CreateSUV() => new LexusSUV();
    }
}
