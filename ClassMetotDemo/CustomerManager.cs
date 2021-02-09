using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddClient(Customer customer)
        {
            Console.WriteLine("The customer is added this bank system: " +
                customer.CustomerName + " " + customer.CustomerLastName);
        }

        public void RemoveCLient(Customer customer)
        {
            Console.WriteLine("This customer account removed from the bank system: " +
                customer.CustomerName + " " + customer.CustomerLastName);
        }
        public void Array(Customer[] customer)
        {
            foreach (Customer client in customer)
            {
                Console.WriteLine("Customer Name: " + client.CustomerName + 
                    "\nCustomer Surname: " + client.CustomerLastName + 
                    "\nPhone Number: " + client.PhoneNumber);
                Console.WriteLine("------------------------------------");

            }
           
        }

    }  
   
}
