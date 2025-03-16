using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Customer_Account
            Customer_Account customer = new Customer_Account(1234567890, "John Doe");

            // Initialize the bank name
            customer.SetBankName("ABC Bank");

            // Display customer account details
            customer.printInfo();

            Console.ReadLine();
        }
    }
}
