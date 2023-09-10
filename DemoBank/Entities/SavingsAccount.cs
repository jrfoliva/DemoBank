namespace DemoBank.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; private set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance *= (1 + InterestRate / 100);
        }
    }
}
