namespace BackendLibrary
{
    public class Contact
    {
        private Countries countries;
        private Email email;
        private Phone phone;

        public Contact()
        {
            countries = Countries.Sverige;
            email = new Email("", "");
            phone = new Phone();
        }

        public Contact(Countries countries, Email email, Phone phone)
        {
            this.countries = countries;
            this.email = email;
            this.phone = phone;
        }

        public Contact(Contact contact)
        {
            countries = contact.countries;
            email = contact.email;
            phone = contact.phone;
        }

        public Countries Countries
        {
            get => countries;
            set => countries = value;
        }

        public Email Email
        {
            get => email;
            set => email = value;
        }

        public Phone Phone
        {
            get => phone;
            set => phone = value;
        }
    }
}