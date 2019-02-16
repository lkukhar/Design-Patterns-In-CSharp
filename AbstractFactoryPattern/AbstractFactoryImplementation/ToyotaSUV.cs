using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryImplementation
{
    public class ToyotaSUV : SUV
    {
        public override string TurnOff() => "Toyota SUV has been turned off.";
        public override string TurnOn() => "Toyota SUV has been turned on.";
    }
}
