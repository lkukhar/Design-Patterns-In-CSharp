using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternImplementation
{
    public class Imperial
    {
        public Imperial(double inches)
        {
            Inches = inches;
        }

        public double Inches { get; }
    }
}
