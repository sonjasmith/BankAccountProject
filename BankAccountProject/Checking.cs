using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Checking : Account
    {
        //varialbes inherited from the base class account
        //constructor
        public Checking()
        {
            //using properties inherited from base
            AccountNumberProp = 987654321;
            AccountBalanceProp = 500m;
            AccountTypeProp = "Checking";
        }

        //methods
        public override void showCurrentBalance()
        {
            base.showCurrentBalance();
            Console.WriteLine("for Checking: $" + AccountBalanceProp + "\n");     
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
            AccountBalanceProp = AccountBalanceProp - withdrawalAmount;
            Console.WriteLine("$" + AccountBalanceProp + "\n");
        }
    }
}
