using System.Collections.Generic;
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

        /// <summary>
        /// Default constructor
        /// </summary>
        public Contact()
        {
            fName = "";
            lName = "";
            address = new Address();
            email = new Email();
            phone = new Phone();
        }

        /// <summary>
        /// Constructor without name
        /// </summary>
        /// <param name="address">Address class</param>
        /// <param name="email">Email class</param>
        /// <param name="phone">Phone class</param>
        public Contact(Address address, Email email, Phone phone)
        {
            fName = "";
            lName = "";
            this.address = address;
            this.email = email;
            this.phone = phone;
        }

        /// <summary>
        /// Constructor with the info from the previous Contact class
        /// </summary>
        /// <param name="contact">Contact class</param>
        public Contact(Contact contact)
        {
            fName = contact.fName;
            lName = contact.lName;
            address = contact.address;
            email = contact.email;
            phone = contact.phone;
        }

        /// <summary>
        /// Constructor with all exposed parameter
        /// </summary>
        /// <param name="fName">First name</param>
        /// <param name="lName">Last name</param>
        /// <param name="address">Address class</param>
        /// <param name="email">Email class</param>
        /// <param name="phone">Phone class</param>
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
            set
            {
                if (string.IsNullOrEmpty(value)) return;
                lName = value;
            }
        }

        public string FName
        {
            get { return fName; }
            set
            {
                if (string.IsNullOrEmpty(value)) return;
                fName = value;
            }
        }

        public Email Email
        {
            get { return email; }
            set
            {
                if (!new Email(value).IsValidEmail()) return;
                email = value;
            }
        }

        public Phone Phone
        {
            get { return phone; }
            set
            {
                if (!new Phone(value).IsValidPhone()) return;
                phone = value;
            }
        }

        public Address Address
        {
            get { return address; }
            set
            {
                if (!new Address(value).IsValidAddress()) return;
                address = value;
            }
        }

        /// <summary>
        /// Check if first name is valid
        /// </summary>
        /// <returns>True if valid</returns>
        public bool IsValidFName()
        {
            return !string.IsNullOrEmpty(fName);
        }

        /// <summary>
        /// Check if last name is valid
        /// </summary>
        /// <returns>True if valid</returns>
        public bool IsValidLName()
        {
            return !string.IsNullOrEmpty(LName);
        }

        /// <summary>
        /// Check if name is valid by checking both first name and last name
        /// </summary>
        /// <returns>True if valid</returns>
        public bool IsValidName()
        {
            return IsValidFName() && IsValidLName();
        }

        /// <summary>
        /// Check if contact is valid by checking everything 
        /// </summary>
        /// <returns></returns>
        public bool IsValidContact()
        {
            return IsValidName() && address.IsValidAddress() && email.IsValidEmail() && phone.IsValidPhone() ;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetContactDetail()
        {
            return
                $@"{FName} {LName} {Email.Personal} {Email.Work} {Phone.OfficeNumber} {Phone.PersonalNumber} {Address.Street} {Address.City} {Address.Zipcode} {Address.Countries.ToString().Replace("_", " ")}";
        }

        /// <summary>
        /// Return all contact details in string array
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetContactStrings()
        {
            return new string[]
            {
                FName, LName,
                Email.Work, Email.Personal,
                Phone.OfficeNumber, Phone.PersonalNumber,
                Address.Street, Address.City, Address.Zipcode, Address.Countries.ToString().Replace("_", " ")
            };
        }
    }
}