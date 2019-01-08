namespace SolidPrinciplesPrototype.InterfaceSegregationPrinciple
{
    public interface IBankService
    {
        void MakeDeposit(string accountNumber, decimal amount);
        void MakeWithDrawal(string accountNumber, decimal amount);

        void OpenAccount(decimal customerId, string accountType);
        void CloseAccount(string accountNumber);

        void CreateCustomer(string name, string address);
        void DisableCustomer(decimal customerId);

        // Many more methods...
    }

    /// <summary>
    /// The Atm class has access to metods that should never have to be concerned with.
    /// </summary>
    public class Atm
    {
        private readonly IBankService _bankService;

        public Atm(IBankService bankService)
        {
            _bankService = bankService;
        }

        public void MakeDeposit(string accountNumber, decimal amount)
        {
            _bankService.MakeDeposit(accountNumber, amount);
        }

        public void MakeWithDrawal(string accountNumber, decimal amount)
        {
            _bankService.MakeWithDrawal(accountNumber, amount);
        }
    }
}
