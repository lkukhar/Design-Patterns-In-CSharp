using AdapterPatternImplementation;
using Xunit;

namespace AdapterPatternTests
{
    public class AdapterTest
    {
        [Fact]
        public void Imperial_Adapter_Converts_To_Metric()
        {
            ImperialAdapter imperialAdapter = new ImperialAdapter(new Imperial(2));
            Metric metric = new Metric(imperialAdapter.ConvertToMetric());
            Assert.Equal(5.08, metric.Centimeters);
        }
    }
}
