using System.Linq;

namespace BackendLibrary
{
    public class Phone
    {
        private string officeNumber;
        private string personalNumber;

        public Phone()
        {
            officeNumber = "";
            personalNumber = "";
        }

        public Phone(string officeNumber, string personalNumber)
        {
            this.officeNumber = officeNumber;
            this.personalNumber = personalNumber;
        }

        public Phone(Phone phone)
        {
            officeNumber = phone.officeNumber;
            personalNumber = phone.personalNumber;
        }

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

        public bool IsValidOfficePhone()
        {
            return (officeNumber[0] == '+' ? officeNumber.Remove(0, 1) : officeNumber).Replace(" ", "")
                .All(char.IsDigit);
        }

        public bool IsValidHomePhone()
        {
            return personalNumber == string.Empty ||
                   (personalNumber[0] == '+' ? personalNumber.Remove(0, 1) : personalNumber).Replace(" ", "")
                   .All(char.IsDigit);
        }

        public bool IsValidPhone()
        {
            return IsValidHomePhone() && IsValidOfficePhone();
        }
    }
}