using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BackendLibrary
{
    public class CustomerManager : IList<Customer>
    {
        private List<Customer> customers;

        public CustomerManager()
        {
            customers = new List<Customer>();
        }

        public CustomerManager(List<Customer> customers)
        {
            this.customers = customers;
        }

        public CustomerManager(CustomerManager customerManager)
        {
            customers = customerManager.customers;
        }

        public void Add(Customer customer)
        {
            if (customer != null)
                customers.Add(customer);
        }

        public void EditCustomer(Customer customer, int index)
        {
            customers[index] = customer;
        }
        
        public void Clear()
        {
            customers = new List<Customer>();
        }

        public bool Contains(Customer item)
        {
            return customers.Contains(item);
        }

        public void CopyTo(Customer[] array, int arrayIndex)
        {
            customers.CopyTo(array, arrayIndex);
        }

        public bool Remove(Customer item)
        {
            return customers.Remove(item);
        }

        public int Count
        {
            get { return customers.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public int IndexOf(Customer item)
        {
            return customers.IndexOf(item);
        }

        public void Insert(int index, Customer item)
        {
            customers.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            customers.RemoveAt(index);
        }

        public Customer this[int index]
        {
            get { return customers[index]; }
            set { customers[index] = value; }
        }

        public IEnumerator<Customer> GetEnumerator()
        {
            return customers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Customer[] GetCustomers()
        {
            return customers.ToArray();
            // return customers.Select(VARIABLE => string.Join(" ", GetCustomerInfo(VARIABLE))).ToArray();
        }

        public IEnumerable<string> GetCustomerInfo(int index)
        {
            return new string[]{index.ToString()}.Concat(customers[index].Contact.GetContactStrings());
        }
        
        public IEnumerable<string> GetCustomerInfo(Customer customer)
        {
            return new string[]{IndexOf(customer).ToString()}.Concat(customers[IndexOf(customer)].Contact.GetContactStrings());
        }
    }
}