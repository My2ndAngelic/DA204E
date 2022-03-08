using System.Linq;

namespace BackendLibrary
{
    public class Contact
    {
        private Countries countries;
        private Email email;
        private string fName;
        private string lName;
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

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        public Email Email
        {
            get { return email; }
            set { email = value; }
        }

        public Phone Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public Countries Countries
        {
            get { return countries; }
            set { countries = value; }
        }

        public bool IsValidName()
        {
            return !(fName.Any(char.IsDigit) || lName.Any(char.IsDigit));
        }

        public bool IsValidContact()
        {
            return email.IsValidEmail() && phone.IsValidPhone() && IsValidName();
        }
    }
}