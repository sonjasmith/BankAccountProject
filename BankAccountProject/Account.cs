using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class Account
    {
        //variables/fields
        protected int accountNumberVar;
        protected decimal accountBalanceVar;
        protected string accountTypeVar;
            
        //constructor
        public Account()
        {
            this.accountNumberVar = 0;
            this.accountBalanceVar = 0m;
            this.accountTypeVar = "";
        }

        //Properties
        public virtual int AccountNumberProp
        {
            set { this.accountNumberVar = value; }
            get { return this.accountNumberVar; }
        }

        public virtual decimal AccountBalanceProp
        {
            set { this.accountBalanceVar = value; }
            get { return this.accountBalanceVar; }
        }

        public string AccountTypeProp
        {
            set { this.accountTypeVar = value; }
            get { return this.accountTypeVar; }
        }

        //methods
        public virtual void showCurrentBalance()
        {
            Console.Write("Current Balance ");
        }

        public abstract void depositFunds(decimal depositAmount);
        public abstract void withdrawFunds(decimal withdrawalAmount);
    }
}
