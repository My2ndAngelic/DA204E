using System.Collections;
using System.Collections.Generic;

namespace BackendLibrary
{
    public class CustomerManager : IList<Customer>
    {
        private List<Customer> customers;

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

        public void Add(Customer item)
        {
            customers.Add(item);
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
            
        }

        public bool Remove(Customer item)
        {
            return customers.Remove(item);
        }

        public int Count => throw new System.NotImplementedException();

        public bool IsReadOnly => false;

        public int IndexOf(Customer item) => customers.IndexOf(item);

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
            get => customers[index];
            set => customers[index] = value;
        }

        public IEnumerator<Customer> GetEnumerator()
        {
            return customers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}