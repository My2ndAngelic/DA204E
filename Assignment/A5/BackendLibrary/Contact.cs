using System.Linq;

namespace BackendLibrary
{
    public class Contact
    {
        private Address address;
        private Email email;
        private string fName;
        private string lName;
        private Phone phone;

        public Contact()
        {
            fName = "";
            lName = "";
            address = new Address();
            email = new Email();
            phone = new Phone();
        }

        public Contact(Address address, Email email, Phone phone)
        {
            this.address = address;
            this.email = email;
            this.phone = phone;
        }

        public Contact(Contact contact)
        {
            fName = contact.fName;
            lName = contact.lName;
            address = contact.address;
            email = contact.email;
            phone = contact.phone;
        }

        public Contact(string fName, string lName, Address address, Email email, Phone phone)
        {
            this.fName = fName;
            this.lName = lName;
            this.address = address;
            this.email = email;
            this.phone = phone;
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

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public bool IsValidName()
        {
            return !(fName.Any(char.IsDigit) || lName.Any(char.IsDigit));
        }

        public bool IsValidContact()
        {
            return email.IsValidEmail() && phone.IsValidPhone() && IsValidName();
        }

        public string GetContactDetail()
        {
            return
                $@"{FName} {LName} {Email.Personal} {Email.Work} {Phone.Number}";
        }
    }
}