namespace HSACareerTech.BL
{
    public class Customer
    {
        #region Public Properties

        public Customer()
        {
                
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public int CustomerId { get; private set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                var fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                        fullName += ", ";
                    fullName += FirstName;
                }

                return fullName;
            }
        }

        #endregion Public Properties

        #region Public Methods

        public bool Validate()
        {
            return !(string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(EmailAddress));
        }

        public void SaveCustomer(Customer customer)
        {

        }

        public Customer RetrieveCustomer()
        {
            return new Customer();
        }

        public Customer RetrieveCustomer(int id)
        {
            return new Customer();
        }
        #endregion Public Methods
    }
}