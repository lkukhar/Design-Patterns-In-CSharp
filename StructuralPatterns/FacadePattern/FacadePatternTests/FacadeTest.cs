using FacadePatternImplementation;
using Xunit;

namespace FacadePatternTests
{
    public class FacadeTest
    {
        [Fact]
        public void Facade_System_Calls_SubSystems()
        {
            SystemFacade systemFacade = new SystemFacade(new BillingSystem(), new ReportingSystem());
            Assert.Equal("Customer billed. Report generated.", systemFacade.BillAndReportCustomer());
        }
    }
}
