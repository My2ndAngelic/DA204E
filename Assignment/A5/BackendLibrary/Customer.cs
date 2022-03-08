namespace BackendLibrary
{
    public class Customer
    {
        private Contact contact;

        public Customer()
        {
        }

        public Customer(Contact contact)
        {
            this.contact = contact;
        }

        public Customer(Customer customer)
        {
            contact = customer.Contact;
        }

        public Contact Contact
        {
            get { return contact; }
            set { contact = value; }
        }
    }
}