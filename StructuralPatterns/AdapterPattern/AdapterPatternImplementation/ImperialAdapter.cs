using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternImplementation
{
    public class ImperialAdapter
    {
        private readonly Imperial _imperial;

        public ImperialAdapter(Imperial imperial)
        {
            _imperial = imperial;
        }

        public double ConvertToMetric()
        {
            return _imperial.Inches * 2.54;
        } 
    }
}
