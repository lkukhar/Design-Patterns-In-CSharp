using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryImplementation
{
    public class ToyotaCar : Car
    {
        public override string TurnOff() => "Toyota car has been turned off.";
        public override string TurnOn() => "Toyota car has been turned on.";
    }
}
