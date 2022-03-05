namespace BackendLibrary
{
    public class Customer
    {
        private readonly Contact contact;

        public Customer()
        {
            
        }

        public Customer(Contact contact)
        {
            
        }

        public Customer(Customer customer)
        {
            contact = customer.contact;
        }
    }
}