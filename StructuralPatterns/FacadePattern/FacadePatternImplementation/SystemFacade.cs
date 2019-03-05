namespace FacadePatternImplementation
{
    public class SystemFacade
    {
        private readonly BillingSystem _billingSystem;
        private readonly ReportingSystem _reportingSystem;

        public SystemFacade(BillingSystem billingSystem, ReportingSystem reportingSystem)
        {
            _billingSystem = billingSystem;
            _reportingSystem = reportingSystem;
        }

        public string BillAndReportCustomer()
        {
            string result = string.Empty;
            result += _billingSystem.BillCustomer() + " " + _reportingSystem.GenerateReport();
            return result;
        }
    }
}
