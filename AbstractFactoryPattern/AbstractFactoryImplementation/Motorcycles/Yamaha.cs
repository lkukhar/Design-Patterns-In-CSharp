using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryImplementation.Motorcycles
{
    public class Yamaha : Motorcycle
    {
        protected override string DriveMotorcycle()
        {
            return "The Yamaha is being driven.";
        }
    }
}
