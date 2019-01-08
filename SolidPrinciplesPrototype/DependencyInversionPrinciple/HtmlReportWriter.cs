namespace SolidPrinciplesPrototype.DependencyInversionPrinciple
{
    public class Report {}

    public class HtmlReportWriter
    {
        public void WriteReportToHtml(Report report)
        {
            // Generate Html file containing report data
        }
    }

    /// <summary>
    /// The ReportGenerator has a dependency on a very specific class HtmlReportWriter. What happens if we want to change the report format to CSV?
    /// </summary>
    public class ReportGenerator
    {
        private readonly HtmlReportWriter _htmlReportWriter = new HtmlReportWriter();
        private readonly Report _report = new Report();

        public void GenerateReport(string reportName)
        {
            //Create and populate report object
            _htmlReportWriter.WriteReportToHtml(_report);
        }
    }
}
