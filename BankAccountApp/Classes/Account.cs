using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountApp.Classes
{
    public class Account
    {
        public string Owner { get; set; }

        public decimal Balance { get; private set; }

        public Account(string owner, decimal balance)
        {
            Owner = owner;
            Balance = balance;
        }

        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
                return false;

            Balance += amount;
            return true;
        }
    }
}
