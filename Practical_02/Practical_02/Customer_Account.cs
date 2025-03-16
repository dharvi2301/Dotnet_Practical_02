using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_02
{

    public class Customer_Account
    {
        // Member variables
        public string bank_name { get; set; }
        public long customer_accountNo { get; set; }
        public string customer_name { get; set; }

        /// <summary>
        /// Parameterized constructor to initialize customer account details.
        /// </summary>
        /// <param name="accountNo">Customer's account number</param>
        /// <param name="customerName">Customer's name</param>
        public Customer_Account(long customer_accountNo, string customer_name)
        {
            this.customer_accountNo = customer_accountNo;
            this.customer_name = customer_name;
        }
        /// <summary>
        /// Sets the bank name.
        /// </summary>
        /// <param name="bankName">Name of the bank</param>
        public void SetBankName(string bankName)
        {
            bank_name = bankName;
        }

        /// <summary>
        /// Prints all the details of the customer account.
        /// </summary>
        public void printInfo()
        {
            Console.WriteLine("Bank Name: " + bank_name);
            Console.WriteLine("Customer Account Number: " + customer_accountNo);
            Console.WriteLine("Customer Name: " + customer_name);
        }
    }
}