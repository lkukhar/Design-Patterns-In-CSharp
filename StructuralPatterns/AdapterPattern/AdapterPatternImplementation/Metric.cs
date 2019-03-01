using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternImplementation
{
    public class Metric
    {
        public Metric(double centimeters)
        {
            Centimeters = centimeters;
        }

        public double Centimeters { get; }
    }
}
