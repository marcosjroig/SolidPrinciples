namespace SolidPrinciplesPrototype.OpenClosedPrinciple
{
    public interface IInterestCalculation
    {
        decimal CalculateInterest(decimal balance);
    }

    public class SavingInterestCalculation : IInterestCalculation
    {
        public decimal CalculateInterest(decimal balance)
        {
            return balance * (decimal)0.05;
        }
    }

    public class CurrentInterestCalculation : IInterestCalculation
    {
        public decimal CalculateInterest(decimal balance)
        {
            return balance * (decimal)0.01;
        }
    }

    public class AccountNew
    {
        private readonly string _accountNumber;
        private readonly decimal _balance;

        public AccountNew(string accountNumber, decimal balance)
        {
            _accountNumber = accountNumber;
            _balance = balance;
        }

        // More fields & accessor methods

        public decimal CalculateInterest(IInterestCalculation interestCalculation)
        {
            return interestCalculation.CalculateInterest(_balance);
        }
    }
}
