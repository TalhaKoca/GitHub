using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerName = "Mesut";
            customer1.CustomerLastName = "ÖZİL";
            customer1.PhoneNumber = 0123545688;

            Customer customer2 = new Customer();
            customer2.CustomerName = "Erol";
            customer2.CustomerLastName = "BULUT";
            customer2.PhoneNumber = 0313254979;

            Customer[] customers = new Customer[] { customer1, customer2};

            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("---------------Addition-------------");
            customerManager.AddClient(customer1);
            customerManager.AddClient(customer2);

            Console.WriteLine("---------------Remove---------------");
            customerManager.RemoveCLient(customer1);
            customerManager.RemoveCLient(customer2);

            Console.WriteLine("---------------Array----------------");
            customerManager.Array(customers);
        }
    }
}
