using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryImplementation
{
    public class LexusSUV : SUV
    {
        public override string TurnOff() => "Lexus SUV has been turned off.";
        public override string TurnOn() => "Lexus SUV has been turned on.";
    }
}
