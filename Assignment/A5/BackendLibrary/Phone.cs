using System.Linq;
using System.Text.RegularExpressions;

namespace BackendLibrary
{
    public class Phone
    {
        private string officeNumber;
        private string personalNumber;

        /// <summary>
        ///     Default constructor
        /// </summary>
        public Phone()
        {
            officeNumber = "";
            personalNumber = "";
        }

        /// <summary>
        ///     All exposed argument constructor
        /// </summary>
        /// <param name="officeNumber">Office number</param>
        /// <param name="personalNumber">Personal number</param>
        public Phone(string officeNumber, string personalNumber)
        {
            this.officeNumber = officeNumber;
            this.personalNumber = personalNumber;
        }

        /// <summary>
        ///     Chained constructor
        /// </summary>
        /// <param name="phone">Phone class</param>
        public Phone(Phone phone)
        {
            officeNumber = phone.officeNumber;
            personalNumber = phone.personalNumber;
        }

        /// <summary>
        ///     One argument constructor
        /// </summary>
        /// <param name="officeNumber">Office number</param>
        public Phone(string officeNumber) : this(officeNumber, string.Empty)
        {
        }

        public string OfficeNumber
        {
            get { return officeNumber; }
            set { officeNumber = value; }
        }

        public string PersonalNumber
        {
            get { return personalNumber; }
            set { personalNumber = value; }
        }

        /// <summary>
        ///     Check if valid phone format
        /// </summary>
        /// <param name="phone">Input Phone</param>
        /// <returns>True if valid</returns>
        private bool IsValidPhoneFormat(string phone)
        {
            /*
             * First character could be +, remove it if necessary 
             * Replace all (, ), -, <space> with empty string
             * Check if the result contains only number 
             */
            return Regex.Replace(phone[0] == '+' ? phone.Remove(0, 1) : phone, @"\(|\)|-| ", string.Empty)
                .All(char.IsDigit);
        }

        /// <summary>
        ///     Check if valid office phone
        /// </summary>
        /// <returns>True if valid</returns>
        public bool IsValidOfficePhone()
        {
            return IsValidPhoneFormat(officeNumber);
        }

        /// <summary>
        ///     Check if valid personal phone
        /// </summary>
        /// <returns>True if valid</returns>
        public bool IsValidHomePhone()
        {
            return personalNumber.Equals(string.Empty) || IsValidPhoneFormat(personalNumber);
        }

        /// <summary>
        ///     Check if both office and personal phone are valid
        /// </summary>
        /// <returns>True if valid</returns>
        public bool IsValidPhone()
        {
            return IsValidHomePhone() && IsValidOfficePhone();
        }
    }
}