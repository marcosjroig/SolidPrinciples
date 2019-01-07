namespace SolidPrinciplesPrototype.SingleResponsabilityPrinciple
{
    /// <summary>
    /// This class shows the a Single Reponsability Principle violation.
    /// The class is doing too much. The only method that really belongs to the Invoice is CalculateTotal
    /// 
    /// StoreInvoiceDetails: if we change the database, to Oracle or MySQL, probably we will need to change this method
    /// 
    /// PrintInvoice: printing is not an Invoice concern, it is clearly a Presentation Layer concern. If we decide to change the print format, we will have to change the invoice.
    /// </summary>

    public class Invoice
    {
        public decimal CalculateTotal()
        {
            // Calculate total value of itens in this invoice

            // Fake return value
            return 100;
        }

        public void StoreInvoiceDetails()
        {
            // Persist the invoice to a Database
        }

        public void PrintInvoice()
        {
            // Print the invoice in a specific format
        }
    }
}
