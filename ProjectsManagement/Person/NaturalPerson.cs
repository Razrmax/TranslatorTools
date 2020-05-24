namespace ProjectsManagement.Person
{
    /// <summary>
    /// Bottom level customer class, represents a natural person (used as either contact person for a company, or a person for a natural person client)
    /// </summary>
    public class NaturalPerson
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public NaturalPerson()
        {
        }

        public NaturalPerson(string name, string address, int phoneNumber, string email)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public NaturalPerson(string name, string address, string email)
        {
            Name = name;
            Address = address;
            PhoneNumber = -1;
            Email = email;
        }

        public NaturalPerson(string name, string address, int phoneNumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = "N/A";
        }
    }
}
