using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp_OOP_Practice
{
    public class SavingsAccount:BankAccount
        //note: you will see an error under the child class SavingsAccount if you do not create a
        //constructor for it
    {
        public decimal InterestRate { get; set; }    

        public SavingsAccount(string owner, decimal interestRate):base(owner + " *s* (" + interestRate + "%)")
            //:base(owner) inherits from the constructor in BankAccounts. base means base constructor,
            //(owner) passes the parameters of the base class
        {
            InterestRate = interestRate;
        }
        //constructor

        public override string Deposit(decimal amount)
            //override allows us to use polymorphism to change the objects created within the child class 
            //slightly from the objects created directly from the parent class
            //parent classes method that we're overriding must be virtual
        {
            if (amount <= 0)
            {
                return "You Cannot Deposit " + amount + ".";
            }
            if (amount > 1000000000)
            {
                return "AML Deposit Limit Reached.";
            }

            decimal interestAmount = (InterestRate / 100) * amount;
            Balance += amount + interestAmount;
            return "Deposit Completed Successfully.";
        }
    }

}
