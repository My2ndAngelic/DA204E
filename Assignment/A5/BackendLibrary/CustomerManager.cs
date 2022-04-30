using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BackendLibrary
{
    public class CustomerManager : IList<Customer>
    {
        private List<Customer> customers;

        /// <summary>
        ///     Default constructor
        /// </summary>
        public CustomerManager()
        {
            customers = new List<Customer>();
        }

        /// <summary>
        ///     Constructor with existing list of customers
        /// </summary>
        /// <param name="customers">List of customers</param>
        public CustomerManager(List<Customer> customers)
        {
            this.customers = customers;
        }

        /// <summary>
        ///     Constructor with existing Customer Manager object
        /// </summary>
        /// <param name="customerManager">Customer object</param>
        public CustomerManager(CustomerManager customerManager)
        {
            customers = customerManager.customers;
        }

        public List<Customer> Customers
        {
            get { return customers; }
        }

        /// <summary>
        ///     Add customer to the list
        /// </summary>
        /// <param name="customer">Customer data</param>
        public void Add(Customer customer)
        {
            if (customer != null)
                customers.Add(customer);
        }

        /// <summary>
        ///     Clear the list
        /// </summary>
        public void Clear()
        {
            customers = new List<Customer>();
        }

        /// <summary>
        ///     Check if customer is in the list
        /// </summary>
        /// <param name="item">Customer info</param>
        /// <returns>True if exist</returns>
        public bool Contains(Customer item)
        {
            return customers.Contains(item);
        }

        /// <summary>
        ///     Copy customer array to a new list
        /// </summary>
        /// <param name="array">Destination array</param>
        /// <param name="arrayIndex">From which customer in the list</param>
        public void CopyTo(Customer[] array, int arrayIndex)
        {
            customers.CopyTo(array, arrayIndex);
        }

        /// <summary>
        ///     Remove customer at position in the list
        /// </summary>
        /// <param name="item">Customer</param>
        /// <returns>True if successful</returns>
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

        /// <summary>
        ///     Insert customer at the position
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        public void Insert(int index, Customer item)
        {
            customers.Insert(index, item);
        }

        /// <summary>
        ///     Remove customer at specific location
        /// </summary>
        /// <param name="index">Customer ID to remove</param>
        public void RemoveAt(int index)
        {
            customers.RemoveAt(index);
        }

        /// <summary>
        ///     Getter and setter of array
        /// </summary>
        /// <param name="index">Customer ID</param>
        public Customer this[int index]
        {
            get { return customers[index]; }
            set { customers[index] = value; }
        }

        /// <summary>
        ///     Get Enumerator
        /// </summary>
        /// <returns>Enumerator</returns>
        public IEnumerator<Customer> GetEnumerator()
        {
            return customers.GetEnumerator();
        }

        /// <summary>
        ///     Get Enumerator from IEnumerator
        /// </summary>
        /// <returns>IEnumerator object</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        ///     Edit customer at position
        /// </summary>
        /// <param name="customer">Customer data</param>
        /// <param name="index">Customer ID</param>
        public void EditCustomerAt(Customer customer, int index)
        {
            customers[index] = customer;
        }

        /// <summary>
        ///     Get list of customers
        /// </summary>
        /// <returns>List of customers using IEnumerable</returns>
        public IEnumerable<Customer> GetCustomers()
        {
            return customers;
        }

        /// <summary>
        ///     Get customer info using ID
        /// </summary>
        /// <param name="index">Customer ID</param>
        /// <returns>String array of customer info using IEnumerable</returns>
        public IEnumerable<string> GetCustomerInfo(int index)
        {
            return new[] {index.ToString()}.Concat(customers[index].Contact.GetContactStrings());
        }

        /// <summary>
        ///     Get customer info using Customer info
        /// </summary>
        /// <param name="customer">Customer info</param>
        /// <returns>String array of customer info using IEnumerable</returns>
        public IEnumerable<string> GetCustomerInfo(Customer customer)
        {
            return new[] {IndexOf(customer).ToString()}.Concat(customers[IndexOf(customer)].Contact
                .GetContactStrings());
        }
    }
}
