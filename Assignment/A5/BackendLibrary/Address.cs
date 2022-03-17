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
            countries = Countries.Sverige;
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

        /// <summary>
        /// ToString method
        /// </summary>
        /// <returns>To String</returns>
        public override string ToString()
        {
            return $@"{street} {city} {zipcode} {countries.ToString().Replace("_", " ")}";
        }

        /// <summary>
        /// To the list of string
        /// </summary>
        /// <returns>Array of strings</returns>
        public string[] ToStringArray()
        {
            return new[] {street, city, zipcode, countries.ToString().Replace("_", " ")};
        }

        public bool IsValidStreet()
        {
            return !string.IsNullOrEmpty(street);
        }
        
        /// <summary>
        /// Check if valid city
        /// </summary>
        /// <returns>True if valid</returns>
        public bool IsValidCity()
        {
            return !string.IsNullOrEmpty(city);
        }
        
        /// <summary>
        /// Check if valid zipcode
        /// </summary>
        /// <returns>Zipcode is not empty</returns>
        public bool IsValidZipcode()
        {
            return !string.IsNullOrEmpty(zipcode);
        }
        
        /// <summary>
        /// Check if valid country
        /// </summary>
        /// <returns>True if valid</returns>
        public bool IsValidCountry()
        {
            return countries.GetType() == typeof(Countries);
        }
        
        
        /// <summary>
        /// Check Address validity
        /// </summary>
        /// <returns>True if valid</returns>
        public bool IsValidAddress()
        {
            return IsValidStreet() && IsValidCity() && IsValidZipcode() && IsValidCountry();
        }
    }
}