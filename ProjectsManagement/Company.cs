namespace ProjectsManagement
{
    public class Company
    {
        public Person ContactPerson { get; set; }
        public Person BackupContactPerson { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string OfficeAddress { get; set; }

        public Company()
        {
        }

        public Company(Person contactPerson, string companyName, string country, string officeAddress)
        {
            ContactPerson = contactPerson;
            CompanyName = companyName;
            Country = country;
            OfficeAddress = officeAddress;
        }
    }
}
