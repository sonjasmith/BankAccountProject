using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        //variables/fields
        private string clientNameVar;
        private string clientAddressVar;
        private string clientEmailVar;
        private string clientAcctNumberVar;

        //constructor
        public Client()
        {
            ClientNameProp = "The S Brand";
            ClientAddressProp = "123 Brand Blvd";
            ClientEmailProp = "hello@thesbrand.com";
            ClientAcctNumberProp = "1001";
        }

        //properites
        public string ClientNameProp
        {
            set { this.clientNameVar = value; }
            get { return this.clientNameVar; }
        }

        public string ClientAddressProp
        {
            set { this.clientAddressVar = value; }
            get { return this.clientAddressVar; }
        }

        public string ClientEmailProp
        {
            set { this.clientEmailVar = value; }
            get { return this.clientEmailVar; }
        }

        public string ClientAcctNumberProp
        {
            set { this.clientAcctNumberVar = value; }
            get { return this.clientAcctNumberVar; }
        }


        //method
        public void ShowClientInfo()
        {
            //instantiating instances of checking and savings to show client's account number info.
            Checking checkingInst = new Checking();
            Savings savingsInst = new Savings();
            Console.WriteLine("CLIENT INFORMATION: ");
            Console.WriteLine("Name:\t\t\t" + ClientNameProp);
            Console.WriteLine("Address:\t\t" + ClientAddressProp);
            Console.WriteLine("Email:\t\t\t" + ClientEmailProp);
            //using instance variables to get account type and number via properties inherited from the base account class.
            Console.WriteLine(checkingInst.AccountTypeProp + " Account:\t" + checkingInst.AccountNumberProp);
            Console.WriteLine(savingsInst.AccountTypeProp +  " Account:\t" + savingsInst.AccountNumberProp + "\n");


        }
    }
}
