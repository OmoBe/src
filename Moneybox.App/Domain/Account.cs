using System;

namespace Moneybox.App
{
    public class Account
    {
        public const decimal PayInLimit = 4000m;
        private decimal _balance;
        private decimal _paidIn;
        public Account()
        {
            _balance = 0m;
            _paidIn = 0m;
        }

        public Guid Id { get; set; }

        public User User { get; set; }

        public decimal Balance 
        {
            get { return _balance; }
            set
            {
                if (value < 0m)
                {
                    throw new InvalidOperationException("Insufficient funds for this transaction");
                }
                _balance = value;
            }
        }

        public decimal Withdrawn { get; set; }

        public decimal PaidIn 
        {
            get { return _paidIn; }
            set
            {
                if ((value + _paidIn) > PayInLimit)
                {
                    throw new InvalidOperationException("Account pay in limit reached");
                }
            }
        }
    }
}
