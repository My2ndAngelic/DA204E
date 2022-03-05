using System.Collections.Generic;

namespace BackendLibrary
{
    public class CustomerManager
    {
        private readonly List<Customer> customers;

        public CustomerManager()
        {
            
        }

        public CustomerManager(List<Customer> customers)
        {
            this.customers = customers;
        }

        public CustomerManager(CustomerManager customerManager)
        {
            
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        
    }
}