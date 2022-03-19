namespace BackendLibrary
{
    public class Customer
    {
        private Contact contact;

        /// <summary>
        ///     Default constructor
        /// </summary>
        public Customer()
        {
            contact = new Contact();
        }

        /// <summary>
        ///     Constructor from existing contact data
        /// </summary>
        /// <param name="contact">Contact object</param>
        public Customer(Contact contact)
        {
            this.contact = contact;
        }

        /// <summary>
        ///     Constructor from existing customer data
        /// </summary>
        /// <param name="customer">Customer object</param>
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