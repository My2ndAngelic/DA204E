using System.Linq;

namespace BackendLibrary
{
    public class Phone
    {
        private string number;

        public Phone()
        {
            Number = "";
        }

        public Phone(string number)
        {
            Number = number;
        }

        public Phone(Phone phone)
        {
            number = phone.number;
        }

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public bool IsValidPhone()
        {
            return (number[0] == '+' ? number.Remove(0, 1) : number).Replace(" ", "").Any(char.IsDigit);
        }
    }
}