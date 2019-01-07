namespace SolidPrinciplesPrototype.OpenClosedPrinciple
{
    /// <summary>
    /// If we want to add a new type of account to calculate the interest, we have to change the Account Class.
    /// This violates the Open/Closed principle becase we have to modify the core class account, to add this new feature.
    /// What we want is, to extend this class without changing the core class.
    /// </summary>

    public class Account
    {
        private readonly string _accountNumber;
        private readonly decimal _balance;

        public Account(string accountNumber, decimal balance)
        {
            _accountNumber = accountNumber;
            _balance = balance;
        }

        // More fields & accessor methods

        public decimal CalculateInterest()
        {
            if (_accountNumber.StartsWith("000")) // Savings account
            {
                return _balance * (decimal)0.05;
            } else if (_accountNumber.StartsWith("001")) // Current account
            {
                return _balance * (decimal)0.01;
            }
            else
            {
                return 0;
            }
        }
    }
}
