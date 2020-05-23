namespace ProjectsManagement
{
    /// <summary>
    /// Top level customer class, if the customer is a company, CustomerCompany property is initialized, if the customer is a natural person, CustomerPerson is initialized.
    /// </summary>
    public class Customer
    {
        public Company CustomerCompany { get; set; }
        public Person CustomerPerson { get; set; }

        public Customer(Company customerCompany)
        {
            CustomerCompany = customerCompany;
        }

        public Customer(Person customerPerson)
        {
            CustomerPerson = customerPerson;
        }
    }
}
