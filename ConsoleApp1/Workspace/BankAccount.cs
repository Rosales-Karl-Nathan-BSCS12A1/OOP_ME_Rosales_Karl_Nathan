
namespace ConsoleApp1.Exam
{
    // Encapsulation Example
    public class BankAccount
    {
        private decimal _balance; 

    
        public decimal Balance
        {
            get { return _balance; }
        }

   
        public BankAccount(decimal initialBalance = 0)
        {
            _balance = initialBalance;
        }

   
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive");

            _balance += amount;
        }


        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
                return "Withdrawal amount must be positive";

            if (amount > _balance)
                return "Insufficient funds.";

            _balance -= amount;
            return "Withdrawal successful";
        }

       
        public void Transfer(BankAccount target, decimal amount)
        {
            if (target == null)
                throw new ArgumentNullException(nameof(target));

            if (this.Balance >= amount)
            {
                var result = Withdraw(amount);
                if (result == "Withdrawal successful")
                {
                    target.Deposit(amount);
                }
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds for transfer");
            }
        }
    }
}