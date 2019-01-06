namespace SolidPrinciplesPrototype._1SingleResponsabilityPrinciple
{
    public class InvoiceNew
    {
        public decimal CalculateTotal()
        {
            // Calculate total value of itens in this invoice

            // Fake return value
            return 100;
        }
    }

    public interface IInvoiceStore // Deals with persisting invoices, this can know about database structure
    {
        void StoreInvoiceDetails(InvoiceNew invoice);
    }

    public interface IInvoicePrinter // Deals with printing invoices in whichever format our users want
    {
        void PrintInvoice(InvoiceNew invoice);
    }
}
