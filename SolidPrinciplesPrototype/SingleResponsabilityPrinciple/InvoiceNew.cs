namespace SolidPrinciplesPrototype.SingleResponsabilityPrinciple
{
    public interface IInvoice
    {
        decimal CalculateTotal();
    }

    public class InvoiceNew: IInvoice
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
        void StoreInvoiceDetails(IInvoice invoice);
    }

    public interface IInvoicePrinter // Deals with printing invoices in whichever format our users want
    {
        void PrintInvoice(IInvoice invoice);
    }
}
