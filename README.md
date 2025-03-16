# Dotnet_Practical_02
This is the Practical 02 of LMS

# Customer Account Management in C#

## Overview
This project demonstrates a simple **Customer Account Management System** using C#. It defines a `Customer_Account` class that stores **customer details**, including the bank name, account number, and customer name. The class provides methods to **set the bank name** and **display account details**. The `Main` method in the `Program` class creates an instance of `Customer_Account`, assigns values, and prints the account details to the console.

## Features
- **Encapsulates** customer account details in a class.
- Implements a **parameterized constructor** to initialize account details.
- Provides a **method to set the bank name**.
- Displays customer details using a **print method**.
- Uses **OOP principles** like **Encapsulation, Abstraction, and Constructors**.

---

## Code Explanation

### `Customer_Account` Class
```csharp
public class Customer_Account
{
    public string bank_name { get; set; }
    public long customer_accountNo { get; set; }
    public string customer_name { get; set; }

    public Customer_Account(long customer_accountNo, string customer_name)
    {
        this.customer_accountNo = customer_accountNo;
        this.customer_name = customer_name;
    }

    public void SetBankName(string bankName)
    {
        bank_name = bankName;
    }

    public void printInfo()
    {
        Console.WriteLine("Bank Name: " + bank_name);
        Console.WriteLine("Customer Account Number: " + customer_accountNo);
        Console.WriteLine("Customer Name: " + customer_name);
    }
}

