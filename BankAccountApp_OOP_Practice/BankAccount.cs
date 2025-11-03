using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp_OOP_Practice
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; protected set; }
            //set is private to encapsulate the balance
            //set has been changed to protected. protected means that it can still only be accessed in this
            //class, but also in this classes child classes.

        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }
        //constructor

        public virtual string Deposit(decimal amount)
            //virtual allows this method to be overriden
        {
            if (amount <= 0)
            {
                return "You Cannot Deposit " + amount + ".";
            }
            if (amount > 1000000000) 
            {
                return "AML Deposit Limit Reached.";
            }

            Balance += amount;
            return "Deposit Completed Successfully. You Have Deposited: " + amount;
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                return "You Cannot Withdraw " + amount + ".";
            }
            if (amount > Balance)
            {
                return "Isufficient Funds. You Only Have: " + Balance;
            }

            Balance -= amount;
            return "Withdrawal Completed Successfully. You Have Withdrawn: " + amount;
        }
    }
}
