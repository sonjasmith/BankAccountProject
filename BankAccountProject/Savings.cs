using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Savings : Account
    {
        //variables/fields
        private decimal minimumBalanceVar;

        //constructor
        public Savings()
        {
            //using properties inherited from base
            AccountNumberProp = 123456789;
            AccountBalanceProp = 1000m;
            AccountTypeProp = "Savings";
            MinimumBalanceProp = 100m;
        }

        public decimal MinimumBalanceProp
        {
            set { this.minimumBalanceVar = value; }
            get { return this.minimumBalanceVar; }
        }

        //methods
        public override void showCurrentBalance()
        {
            base.showCurrentBalance();
            Console.WriteLine("for Savings: $" + AccountBalanceProp + "\n");
        }

        public override void depositFunds(decimal depositAmount)
        {
            //used setter and getter respectively to update account balance
            AccountBalanceProp = AccountBalanceProp + depositAmount;

            Console.WriteLine("$" + AccountBalanceProp + "\n");
        }

        public override void withdrawFunds(decimal withdrawalAmount)
        {
            //used setter and getter respectively to update account balance
            //AccountBalanceProp = AccountBalanceProp - withdrawalAmount;
            decimal localBalance = AccountBalanceProp;
            localBalance = localBalance - withdrawalAmount;
            if (localBalance >= MinimumBalanceProp)
            {
                AccountBalanceProp = localBalance;
            }
            else
            {
                Console.WriteLine("You cannot withdraw, account balance will fall below minimum balance of $" + MinimumBalanceProp + ".");
            }
            //Console.WriteLine("$" + AccountBalanceProp + "\n");
        }
    }
}

