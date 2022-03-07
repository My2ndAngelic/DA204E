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
            get => number;
            set => number = value;
        }

        public bool IsValidPhone()
        {
            return true;
        }
    }
}