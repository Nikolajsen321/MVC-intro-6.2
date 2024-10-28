namespace StartUp_CORE.Models
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private string _zip;
        private string _city;
        private List<string> _phoneNumbers = new List<string>();

       public Person(string firstName, string lastName, string address, string zip, string city)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _zip = zip;
            _city = city;
       
        }

        // Properties
        public string FirstName
        {
            get { return _firstName; }
        }

        public string LastName
        {
            get { return _lastName; }
        }

        public string Address
        {
            get { return _address; }
        }

        public string Zip
        {
            get { return _zip; }
        }

        public string City
        {
            get { return _city; }
        }

        public List<string>PhoneNumber
        {
            get { return new List<string>(_phoneNumbers); }
            set { _phoneNumbers = value; }
        }

        public void AddPhoneNumber(string phoneNumber)
        {
            _phoneNumbers.Add(phoneNumber);
        }

    }
}
