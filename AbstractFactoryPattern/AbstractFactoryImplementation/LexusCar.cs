using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryImplementation
{
    public class LexusCar : Car
    {
        public override string TurnOff() => "Lexus car has been turned off.";
        public override string TurnOn() => "Lexus car has been turned on.";
    }
}
