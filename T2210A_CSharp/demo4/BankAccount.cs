using System;
namespace T2210A_CSharp.demo4
{
    public delegate void NotifyChangeBalance(string msg);
    public class BankAccount
    {

        private decimal balance;

        private event NotifyChangeBalance msgChangeBalance;
        public BankAccount()
        {
            msgChangeBalance += NotifyEmail;
            msgChangeBalance += NotifySMS;
            msgChangeBalance += NotifyEBanking;
        }

        private void NotifyEmail(string msg)
        {

        }

        private void NotifySMS(string msg)
        {

        }

        private void NotifyEBanking(string msg)
        {

        }

        public Decimal Balance
        {
            get => balance;
            set
            {
                if (balance != value)
                    msgChangeBalance("Balance was changed: " + (value - balance));
                balance = value;
            }
        }

        public void Withdraw(int amount)
        {
            Balance = Balance > amount && amount > 0 ? Balance - amount : Balance;
        }

        public void Deposit(int amount)
        {
            Balance = amount > 0 ? Balance + amount : Balance;
        }
    }
}