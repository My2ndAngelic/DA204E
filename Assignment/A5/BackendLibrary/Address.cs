namespace BackendLibrary
{
    public class Address
    {
        private string city;
        private Countries countries;
        private string street;
        private string zipcode;

        public Address()
        {
            city = "";
            street = "";
            zipcode = "";
            countries = Countries.United_States_of_America;
        }

        public Address(string street, string city, string zipcode, Countries countries)
        {
            this.street = street;
            this.city = city;
            this.zipcode = zipcode;
            this.countries = countries;
        }

        public Address(Address address)
        {
            street = address.street;
            city = address.city;
            zipcode = address.zipcode;
            countries = address.countries;
        }

        public override string ToString()
        {
            return $@"{street} {city} {zipcode} {countries.ToString().Replace("_", " ")}";
        }

        public string GetAddressInfo()
        {
            return $@"{street} {city} {zipcode} {countries.ToString().Replace("_", " ")}";
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Zipcode
        {
            get { return zipcode; }
            set { zipcode = value; }
        }

        public Countries Countries
        {
            get { return countries; }
            set { countries = value; }
        }

        public bool IsValidAddress()
        {
            return true;
        }
    }
}