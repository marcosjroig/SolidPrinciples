namespace SolidPrinciplesPrototype.DependencyInversionPrinciple
{
    public interface IReport { }

    public class ReportNew : IReport
    {

    }

    public interface IReportWriter
    {
        void WriteReport(IReport report);
    }

    public class HtmlReportWriterNew: IReportWriter
    {
        public void WriteReport(IReport report)
        {
            // Generate Html file containing report data
        }
    }

    public class CsvReportWriter: IReportWriter
    {
        public void WriteReport(IReport report)
        {
            // Generate CSV file containing report data
        }
    }

    public class ReportGeneratorNew
    {
        private readonly IReportWriter _reportWriter;

        public ReportGeneratorNew(IReportWriter reportWriter)
        {
            _reportWriter = reportWriter;
        }

        public void GenerateReport(string reportName)
        {
            //Create and populate report object
            _reportWriter.WriteReport(null);
        }
    }
}
