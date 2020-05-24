namespace ProjectsManagement.Person
{
    public class Company
    {
        #region Fields
        public NaturalPerson ContactPerson { get; set; }
        public NaturalPerson SecondContactPerson { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string OfficeAddress { get; set; } 
        #endregion

        #region Constructors
        public Company()
        {
        }

        public Company(NaturalPerson contactPerson, string companyName, string country, string officeAddress)
        {
            ContactPerson = contactPerson;
            CompanyName = companyName;
            Country = country;
            OfficeAddress = officeAddress;
        }

        public Company(NaturalPerson contactPerson, NaturalPerson secondContactPerson, string companyName, string country, string officeAddress)
        {
            ContactPerson = contactPerson;
            SecondContactPerson = secondContactPerson;
            CompanyName = companyName;
            Country = country;
            OfficeAddress = officeAddress;
        } 
        #endregion
    }
}
