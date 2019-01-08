namespace SolidPrinciplesPrototype.InterfaceSegregationPrinciple
{
    public interface ITransactionService
    {
        void MakeDeposit(string accountNumber, decimal amount);
        void MakeWithDrawal(string accountNumber, decimal amount);
    }

    public interface IAccountService
    {
        void OpenAccount(decimal customerId, string accountType);
        void CloseAccount(string accountNumber);
    }

    public interface ICustomerService
    {
        void CreateCustomer(string name, string address);
        void DisableCustomer(decimal customerId);
    }

    public class Atm2
    {
        private readonly ITransactionService _transactionService;

        public Atm2(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        public void MakeDeposit(string accountNumber, decimal amount)
        {
            _transactionService.MakeDeposit(accountNumber, amount);
        }

        public void MakeWithDrawal(string accountNumber, decimal amount)
        {
            _transactionService.MakeWithDrawal(accountNumber, amount);
        }
    }
}
