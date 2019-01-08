using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace SolidPrinciplesPrototype.DependencyInversionPrinciple
{
    public interface IReportWriter
    {
        void WriteReport(Report report);
    }

    public class HtmlReportWriterNew: IReportWriter
    {
        public void WriteReport(Report report)
        {
            // Generate Html file containing report data
        }
    }

    public class CsvReportWriter: IReportWriter
    {
        public void WriteReport(Report report)
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
