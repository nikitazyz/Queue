using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class Cashier
    {
        private Queue<Customer> customers = new Queue<Customer>();

        public void AddOrder(Customer customer)
        {
            customers.Enque(customer);
        }
        public void DeliverOrder()
        {
            Customer customer = customers.Deque();
            Console.WriteLine(string.Format("{0} доставлен для {1}.", customer.product, customer.name));
        }
    }

    class Customer
    {
        public string name;
        public string product;
        public Customer(string name, string product)
        {
            this.name = name;
            this.product = product;
        }
    }
}
