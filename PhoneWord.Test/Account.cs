using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneWord.Test
{
    public class Account
    {
        private float balance;

        public float Balance
        {
            get { return balance; }
        }
        public void Deposit(float amount)
        {
            balance += amount;
        }
        public void Withdraw(float amount)
        {
            balance -= amount;
        }

        public void TransferFunds(Account acc, float amount)
        {
            acc.Deposit(amount);
            Withdraw(amount);

        }

        
    }
}
